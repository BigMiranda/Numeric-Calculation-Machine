using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Trabalho_do_Marcio
{
	public partial class frBisseccao : Form
	{
		public frBisseccao ( )
		{
			InitializeComponent ();
		}

		#region Validação
		private bool Validar ( )
		{
			errorProvider1.Clear ();

			if (string.IsNullOrEmpty ( txtFuncao.Text.Trim () ))
			{
				errorProvider1.SetError ( txtFuncao, "Digite a função!" );
				return false;
			}

			if (!ValidaDouble ( txtX0, "Ponto inválido" ))
			{
				return false;
			}
			if (!ValidaDouble ( txtX1, "Ponto inválido" ))
			{
				return false;
			}
			if (!ValidaDouble ( txtErro, "Erro inválido" ))
			{
				return false;
			}


			if (Convert.ToDouble ( txtX0.Text ) > Convert.ToDouble ( txtX1.Text ))
			{
				errorProvider1.SetError ( txtX0, "Coloque em ordem crescente" );
				errorProvider1.SetError ( txtX1, "Coloque em ordem crescente" );
			}

			return true;
		}

		private bool ValidaDouble ( TextBox txt, string msg )
		{
			try
			{
				Convert.ToDouble ( txt.Text );
				return true;
			}
			catch
			{
				errorProvider1.SetError ( txt, msg );
				return false;
			}
		}
		#endregion

		private void btnCalcular_Click ( object sender, EventArgs e )
		{
			if (!Validar ())
			{
				return;
			}

			double a, fa, b, fb, xk, fXk, erro;

			erro = Double.Parse ( txtErro.Text );

			Function f = new Function ( "f(x)=" + txtFuncao.Text );

			a = Convert.ToDouble ( txtX0.Text );
			b = Convert.ToDouble ( txtX1.Text );

			fa = Convert.ToDouble ( f.calculate ( double.Parse ( txtX0.Text ) ) );
			fb = Convert.ToDouble ( f.calculate ( double.Parse ( txtX1.Text ) ) );

			if (!((fa < 0 && fb > 0) || (fa > 0 && fb < 0)))
			{
				txtResposta.Text = "Não há raiz nesse intervalo...";
				return;
			}

			do
			{
				xk = (a + b) / 2;

				fXk = Convert.ToDouble ( f.calculate ( xk ) );

				if (Math.Abs ( xk - a ) > erro) //Substitui no valor correspondente
				{
					if ((fa > 0 && fXk > 0) || (fa < 0 && fXk < 0))
					{
						a = xk;
						fa = fXk;
					}
					else
					{
						b = xk;
						fb = fXk;
					}
				}
				else //se não, break pois achou a raiz!
				{
					break;
				}

			} while (true);

			int casas = int.Parse ( txtCasasVirgula.Text );
			string resp = xk.ToString ();

			if (rbtArredondar.Checked)
			{
				if (resp.IndexOf ( ',' ) + casas < resp.Length)
					txtResposta.Text = Math.Round ( xk, casas ).ToString ();
				else
					txtResposta.Text = resp;
			}
			else
			{
				if (resp.IndexOf ( ',' ) + casas < resp.Length)
				{
					if (casas == 0)
					{
						txtResposta.Text = resp.Remove ( resp.IndexOf ( ',' ) + casas );
					}
					else
						txtResposta.Text = resp.Remove ( resp.IndexOf ( ',' ) + casas + 1 );
				}
				else
					txtResposta.Text = resp;
			}
		}

		

		private void Botoes ( string botao )
		{
            int n = txtFuncao.SelectionStart;
            txtFuncao.Text = txtFuncao.Text.Insert(n, botao);
            txtFuncao.Select ( n+botao.Length, 0 );
			txtFuncao.Focus ();
        }

		private void PosicionaEntreParenteses ( )
		{
			int n = txtFuncao.SelectionStart;
			txtFuncao.Select ( n - 1, 0 );
			txtFuncao.Focus ();
		}

		#region Botões Numéricos
		private void btn0_Click ( object sender, EventArgs e )
		{
			Botoes ( "0" );
		}

		private void btn1_Click ( object sender, EventArgs e )
		{
			Botoes ( "1" );
		}

		private void btn2_Click ( object sender, EventArgs e )
		{
			Botoes ( "2" );
		}

		private void btn3_Click ( object sender, EventArgs e )
		{
			Botoes ( "3" );
		}

		private void btn4_Click ( object sender, EventArgs e )
		{
			Botoes ( "4" );
		}

		private void btn5_Click ( object sender, EventArgs e )
		{
			Botoes ( "5" );
		}

		private void btn6_Click ( object sender, EventArgs e )
		{
			Botoes ( "6" );
		}

		private void btn7_Click ( object sender, EventArgs e )
		{
			Botoes ( "7" );
		}

		private void btn8_Click ( object sender, EventArgs e )
		{
			Botoes ( "8" );
		}

		private void btn9_Click ( object sender, EventArgs e )
		{
			Botoes ( "9" );
		}
		#endregion

		#region Botões com Parenteses
		private void btnSin_Click ( object sender, EventArgs e )
		{
			Botoes ( "sin()" );
			PosicionaEntreParenteses ();
        }

		private void btnAsin_Click ( object sender, EventArgs e )
		{
			Botoes ( "asin()" );
			PosicionaEntreParenteses ();
		}

		private void btnSinh_Click ( object sender, EventArgs e )
		{
			Botoes ( "sinh()" );
			PosicionaEntreParenteses ();
		}

		private void btnCos_Click ( object sender, EventArgs e )
		{
			Botoes ( "cos()" );
			PosicionaEntreParenteses ();
		}

		private void btnAcos_Click ( object sender, EventArgs e )
		{
			Botoes ( "acos()" );
			PosicionaEntreParenteses ();
		}

		private void btnCosh_Click ( object sender, EventArgs e )
		{
			Botoes ( "cosh()" );
			PosicionaEntreParenteses ();
		}

		private void btnTag_Click ( object sender, EventArgs e )
		{
			Botoes ( "tg()" );
			PosicionaEntreParenteses ();
		}

		private void Atg_Click ( object sender, EventArgs e )
		{
			Botoes ( "atg()" );
			PosicionaEntreParenteses ();
		}

		private void btnTgh_Click ( object sender, EventArgs e )
		{
			Botoes ( "tgh()" );
			PosicionaEntreParenteses ();
		}

		private void btnLn_Click ( object sender, EventArgs e )
		{
			Botoes ( "ln()" );
			PosicionaEntreParenteses ();
		}

		private void btnLog_Click ( object sender, EventArgs e )
		{
			Botoes ( "log10()" );
			PosicionaEntreParenteses ();		
		}
		#endregion

		private void btnDeletar_Click ( object sender, EventArgs e )
		{
			txtFuncao.Clear ();
		}

		private void btnMultiplicar_Click ( object sender, EventArgs e )
		{
			Botoes ( "*" );
		}

		private void btnDividir_Click ( object sender, EventArgs e )
		{
			Botoes ( "/" );
		}

		private void btnSomar_Click ( object sender, EventArgs e )
		{
			Botoes ( "+" );
		}

		private void btnSubtrair_Click ( object sender, EventArgs e )
		{
			Botoes ( "-" );
		}

		private void btnVirgula_Click ( object sender, EventArgs e )
		{
			Botoes ( "." );
		}

		private void btnX_Click ( object sender, EventArgs e )
		{
			Botoes ( "x" );
		}

		private void btnParentesesEsquerdo_Click ( object sender, EventArgs e )
		{
			Botoes ( "(" );
		}

		private void btnParenteseDireito_Click ( object sender, EventArgs e )
		{
			Botoes ( ")" );
		}

		private void btnPi_Click ( object sender, EventArgs e )
		{
			Botoes ( "pi" );
		}

		private void btnE_Click ( object sender, EventArgs e )
		{
			Botoes ( "e^()" );
			PosicionaEntreParenteses ();
		}

		private void btnQuadrado_Click ( object sender, EventArgs e )
		{
			Botoes ( "^2" );
		}

		private void btnElevado_Click ( object sender, EventArgs e )
		{
			Botoes ( "^()" );
			PosicionaEntreParenteses ();
		}

		private void btnRaizQuadrada_Click ( object sender, EventArgs e )
		{
			Botoes ( "sqrt()" );
			PosicionaEntreParenteses ();
		}

		private void btnRaizQualquer_Click ( object sender, EventArgs e )
		{
			Botoes ( "^(1/)" );
			PosicionaEntreParenteses ();
		}

		private void btnAjuda_Click ( object sender, EventArgs e )
		{
			frTutorialBisseccao telaTutorial = new frTutorialBisseccao ();
			telaTutorial.ShowDialog ();
		}
	}
}