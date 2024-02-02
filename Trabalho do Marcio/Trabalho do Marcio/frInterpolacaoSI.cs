using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_do_Marcio
{
	public partial class frInterpolacaoSI : Form
	{
		public frInterpolacaoSI ( )
		{
			InitializeComponent ();
		}

		private bool Validar (TextBox txt)
		{
			try
			{
				Double.Parse ( txt.Text );
				return true;
			}
			catch
			{
				errorProvider1.SetError ( txt, "Valor inválido!" );
				return false;
			}
		}

		private void btnInterpolar_Click ( object sender, EventArgs e )
		{
			if(rbt3Pontos.Checked)
			{
				double[,] mInicial = new double[3,4];

				/*
					[0,0]	[0,1]	[0,2]	[0,3]
					[1,0]	[1,1]	[1,2]	[1,3]
					[2,0]	[2,1]	[2,2]	[2,3]
				 */

				if (Validar ( txtX1 ) && Validar ( txtX2 ) && Validar ( txtX3 )
				&& Validar ( txtY1 ) && Validar ( txtY2 ) && Validar ( txtY3 ))
				{
					double x1 = Convert.ToDouble ( txtX1.Text );
					double x2 = Convert.ToDouble ( txtX2.Text );
					double x3 = Convert.ToDouble ( txtX3.Text );
					double y1 = Convert.ToDouble ( txtY1.Text );
					double y2 = Convert.ToDouble ( txtY2.Text );
					double y3 = Convert.ToDouble ( txtY3.Text );

					mInicial[0, 0] = mInicial[1, 0] = mInicial[2, 0] = 1;

					mInicial[0, 1] = x1;
					mInicial[1, 1] = x2;
					mInicial[2, 1] = x3;

					mInicial[0, 2] = Math.Pow ( x1, 2 );
					mInicial[1, 2] = Math.Pow ( x2, 2 );
					mInicial[2, 2] = Math.Pow ( x3, 2 );

					mInicial[0, 3] = y1;
					mInicial[1, 3] = y2;
					mInicial[2, 3] = y3;

					double[,] mInter = new double[2, 3];
					/*
						[0,0]	[0,1]	[0,2]	[0,3]
						[1,0]	[1,1]	[1,2]	[1,3]
						[2,0]	[2,1]	[2,2]	[2,3]
					*/


					/*
							[0,0]	[0,1]	[0,2]
							[1,0]	[1,1]	[1,2]
					*/

					mInter[0, 0] = mInicial[0, 0] * mInicial[1, 1] - mInicial[1, 0] * mInicial[0, 1];
					mInter[1, 0] = mInicial[0, 0] * mInicial[2, 1] - mInicial[2, 0] * mInicial[0, 1];

					mInter[0, 1] = mInicial[0, 0] * mInicial[1, 2] - mInicial[1, 0] * mInicial[0, 2];
					mInter[1, 1] = mInicial[0, 0] * mInicial[2, 2] - mInicial[2, 0] * mInicial[0, 2];

					mInter[0, 2] = mInicial[0, 0] * mInicial[1, 3] - mInicial[1, 0] * mInicial[0, 3];
					mInter[1, 2] = mInicial[0, 0] * mInicial[2, 3] - mInicial[2, 0] * mInicial[0, 3];

					double[,] mFinal = new double[1, 2];
					/*
							[0,0]	[0,1]	[0,2]
							[1,0]	[1,1]	[1,2]
					*/

					/*
							[0,0]	[0,1]
					*/

					mFinal[0, 0] = mInter[0, 0] * mInter[1, 1] - mInter[1, 0] * mInter[0, 1];
					mFinal[0, 1] = mInter[0, 0] * mInter[1, 2] - mInter[1, 0] * mInter[0, 2];

					double a0, a1, a2;

					a2 = mFinal[0, 1] / mFinal[0, 0];

					a1 = (mInter[0, 2] - mInter[0, 1] * a2) / mInter[0, 0];

					a0 = (mInicial[0, 3] - mInicial[0, 2] * a2 - mInicial[0, 1] * a1) / mInicial[0, 0];

					int n = int.Parse ( txtCasasVirgula.Text );

					if (rbtArredondar.Checked)
					{
						txtGrau0.Text = Math.Round ( a0, n ).ToString ();
						txtGrau1.Text = Math.Round ( a1, n ).ToString ();
						txtGrau2.Text = Math.Round ( a2, n ).ToString ();
					}
					else
					{
						string A0 = a0.ToString ();
						string A1 = a1.ToString ();
						string A2 = a2.ToString ();

						if(n == 0)
						{
							txtGrau0.Text = A0.Remove ( A0.IndexOf ( ',' ) + n );
							txtGrau1.Text = A1.Remove ( A1.IndexOf ( ',' ) + n );
							txtGrau2.Text = A2.Remove ( A2.IndexOf ( ',' ) + n );
						}
						else
						{
							txtGrau0.Text = A0.Remove ( A0.IndexOf ( ',' ) + n + 1 );
							txtGrau1.Text = A1.Remove ( A1.IndexOf ( ',' ) + n + 1 );
							txtGrau2.Text = A2.Remove ( A2.IndexOf ( ',' ) + n + 1 );
						}						
					}													   
				}
			}
			else
			{
				if (Validar ( txtX1 ) && Validar ( txtX2 ) && Validar ( txtX3 ) && Validar ( txtX4 )
				&& Validar ( txtY1 ) && Validar ( txtY2 ) && Validar ( txtY3 ) && Validar ( txtY4 ))
				{
					double[,] m4 = new double[4, 5];
					/*
							[0,0]	[0,1]	[0,2]	[0,3]	[0,4]
							[1,0]	[1,1]	[1,2]	[1,3]	[1,4]
							[2,0]	[2,1]	[2,2]	[2,3]	[2,4]
							[3,0]	[3,1]	[3,2]	[3,3]	[3,4]
					*/

					m4[0, 0] = m4[1, 0] = m4[2, 0] = m4[3, 0] = 1;

					double x0 = Convert.ToDouble ( txtX1.Text );
					double x1 = Convert.ToDouble ( txtX2.Text );
					double x2 = Convert.ToDouble ( txtX3.Text );
					double x3 = Convert.ToDouble ( txtX4.Text );
					double y0 = Convert.ToDouble ( txtY1.Text );
					double y1 = Convert.ToDouble ( txtY2.Text );
					double y2 = Convert.ToDouble ( txtY3.Text );
					double y3 = Convert.ToDouble ( txtY4.Text );

					m4[0, 1] = x0;
					m4[1, 1] = x1;
					m4[2, 1] = x2;
					m4[3, 1] = x3;

					m4[0, 2] = Math.Pow(x0, 2);
					m4[1, 2] = Math.Pow(x1, 2);
					m4[2, 2] = Math.Pow(x2, 2);
					m4[3, 2] = Math.Pow(x3, 2);

					m4[0, 3] = Math.Pow(x0, 3);
					m4[1, 3] = Math.Pow(x1, 3);
					m4[2, 3] = Math.Pow(x2, 3);
					m4[3, 3] = Math.Pow(x3, 3);

					m4[0, 4] = y0;
					m4[1, 4] = y1;
					m4[2, 4] = y2;
					m4[3, 4] = y3;

					double[,] m3 = new double[3, 4];
					/*
							[0,0]	[0,1]	[0,2]	[0,3]	[0,4]
							[1,0]	[1,1]	[1,2]	[1,3]	[1,4]
							[2,0]	[2,1]	[2,2]	[2,3]	[2,4]
							[3,0]	[3,1]	[3,2]	[3,3]	[3,4]
					*/

					/*
							[0,0]	[0,1]	[0,2]	[0,3]
							[1,0]	[1,1]	[1,2]	[1,3]
							[2,0]	[2,1]	[2,2]	[2,3]
					*/

					m3[0, 0] = m4[0, 0] * m4[1, 1] - m4[1, 0] * m4[0, 1];
					m3[1, 0] = m4[0, 0] * m4[2, 1] - m4[2, 0] * m4[0, 1];
					m3[2, 0] = m4[0, 0] * m4[3, 1] - m4[3, 0] * m4[0, 1];

					m3[0, 1] = m4[0, 0] * m4[1, 2] - m4[1, 0] * m4[0, 2];
					m3[1, 1] = m4[0, 0] * m4[2, 2] - m4[2, 0] * m4[0, 2];
					m3[2, 1] = m4[0, 0] * m4[3, 2] - m4[3, 0] * m4[0, 2];

					m3[0, 2] = m4[0, 0] * m4[1, 3] - m4[1, 0] * m4[0, 3];
					m3[1, 2] = m4[0, 0] * m4[2, 3] - m4[2, 0] * m4[0, 3];
					m3[2, 2] = m4[0, 0] * m4[3, 3] - m4[3, 0] * m4[0, 3];

					m3[0, 3] = m4[0, 0] * m4[1, 4] - m4[1, 0] * m4[0, 4];
					m3[1, 3] = m4[0, 0] * m4[2, 4] - m4[2, 0] * m4[0, 4];
					m3[2, 3] = m4[0, 0] * m4[3, 4] - m4[3, 0] * m4[0, 4];

					/*
							[0,0]	[0,1]	[0,2]	[0,3]
							[1,0]	[1,1]	[1,2]	[1,3]
							[2,0]	[2,1]	[2,2]	[2,3]
					*/
					/*
							[0,0]	[0,1]	[0,2]
							[1,0]	[1,1]	[1,2]							
					*/

					double[,] m2 = new double[2, 3];

					m2[0, 0] = m3[0, 0] * m3[1, 1] - m3[1, 0] * m3[0, 1];
					m2[1, 0] = m3[0, 0] * m3[2, 1] - m3[2, 0] * m3[0, 1];

					m2[0, 1] = m3[0, 0] * m3[1, 2] - m3[1, 0] * m3[0, 2];
					m2[1, 1] = m3[0, 0] * m3[2, 2] - m3[2, 0] * m3[0, 2];

					m2[0, 2] = m3[0, 0] * m3[1, 3] - m3[1, 0] * m3[0, 3];
					m2[1, 2] = m3[0, 0] * m3[2, 3] - m3[2, 0] * m3[0, 3];

					/*
							[0,0]	[0,1]	[0,2]	[0,3]	[0,4]
							[1,0]	[1,1]	[1,2]	[1,3]	[1,4]
							[2,0]	[2,1]	[2,2]	[2,3]	[2,4]
							[3,0]	[3,1]	[3,2]	[3,3]	[3,4]
					*/

					/*
							[0,0]	[0,1]	[0,2]	[0,3]
							[1,0]	[1,1]	[1,2]	[1,3]
							[2,0]	[2,1]	[2,2]	[2,3]
					*/
					/*
							[0,0]	[0,1]	[0,2]
							[1,0]	[1,1]	[1,2]							
					*/
					/*
							[0,0]	[0,1]						
					*/

					double[,] m1 = new double[1, 2];

					m1[0, 0] = m2[0, 0] * m2[1, 1] - m2[1, 0] * m2[0, 1];
					m1[0, 1] = m2[0, 0] * m2[1, 2] - m2[1, 0] * m2[0, 2];

					double a0, a1, a2, a3;

					a3 = m1[0, 1] / m1[0, 0];

					a2 = (m2[0, 2] - m2[0, 1] * a3) / m2[0, 0];

					a1 = (m3[0, 3] - m3[0, 2] * a3 - m3[0, 1] * a2) / m3[0, 0];

					a0 = (m4[0, 4] - m4[0, 3] * a3 - m4[0, 2] * a2 - m4[0, 1] * a1) / m4[0, 0];

					int n = int.Parse ( txtCasasVirgula.Text );

					if (rbtArredondar.Checked)
					{
						txtGrau0.Text = Math.Round ( a0, n ).ToString ();
						txtGrau1.Text = Math.Round ( a1, n ).ToString ();
						txtGrau2.Text = Math.Round ( a2, n ).ToString ();
						txtGrau3.Text = Math.Round ( a3, n ).ToString ();
					}
					else
					{
						string A0 = a0.ToString ();
						string A1 = a1.ToString ();
						string A2 = a2.ToString ();
						string A3 = a3.ToString ();

						if (n == 0)
						{
							txtGrau0.Text = A0.Remove ( A0.IndexOf ( ',' ) + n);
							txtGrau1.Text = A1.Remove ( A1.IndexOf ( ',' ) + n);
							txtGrau2.Text = A2.Remove ( A2.IndexOf ( ',' ) + n);
							txtGrau3.Text = A3.Remove ( A3.IndexOf ( ',' ) + n);
						}
						else
						{
							txtGrau0.Text = A0.Remove ( A0.IndexOf ( ',' ) + n + 1 );
							txtGrau1.Text = A1.Remove ( A1.IndexOf ( ',' ) + n + 1 );
							txtGrau2.Text = A2.Remove ( A2.IndexOf ( ',' ) + n + 1 );
							txtGrau3.Text = A3.Remove ( A3.IndexOf ( ',' ) + n + 1 );
						}						
					}
				}
			}
		}

		private void rbt4Pontos_CheckedChanged ( object sender, EventArgs e )
		{
			if(rbt4Pontos.Checked == true)
			{
				txtX4.Visible = true;
				txtY4.Visible = true;
				txtGrau3.Visible = true;
				lblGrau3.Visible = true;
			}
			else
			{
				txtX4.Visible = false;
				txtY4.Visible = false;
				txtGrau3.Visible = false;
				lblGrau3.Visible = false;
			}
			txtX1.Focus ();
		}

		private void btnLimpar_Click ( object sender, EventArgs e )
		{
			txtX1.Clear();
			txtX2.Clear();
			txtX3.Clear();
			txtX4.Clear();
			
			txtY1.Clear();
			txtY2.Clear();
			txtY3.Clear();
			txtY4.Clear();

			txtGrau0.Clear();
			txtGrau1.Clear();
			txtGrau2.Clear();
			txtGrau3.Clear();

		}

		private void btnAjuda_Click ( object sender, EventArgs e )
		{
			frTutorialInterpolacaoSI telaTutorial = new frTutorialInterpolacaoSI ();
			telaTutorial.ShowDialog ();
		}
	}
}
