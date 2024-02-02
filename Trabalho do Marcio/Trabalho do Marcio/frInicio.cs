using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_do_Marcio
{
	public partial class frInicio : Form
	{
		public frInicio ( )
		{
			InitializeComponent ();
		}

		private void button2_Click ( object sender, EventArgs e )
		{
			frInterpolacaoSI telaInterpolacao = new frInterpolacaoSI ();
			Visible = false;
			telaInterpolacao.ShowDialog ();
			Visible = true;
		}

		private void btnBisseccao_Click ( object sender, EventArgs e )
		{
			frBisseccao telaBisseccao = new frBisseccao ();
			Visible = false;
			telaBisseccao.ShowDialog ();
			Visible = true;
		}

		private void button1_Click ( object sender, EventArgs e )
		{
			frSobre telaSobre = new frSobre ();
			telaSobre.ShowDialog ();
		}

		private void button3_Click ( object sender, EventArgs e )
		{
			frTutorialBisseccao telaTuto = new frTutorialBisseccao ();
			Visible = false;
			telaTuto.ShowDialog ();
			Visible = true;
		}

		private void button4_Click ( object sender, EventArgs e )
		{
			frTutorialInterpolacaoSI telaTuto = new frTutorialInterpolacaoSI ();
			Visible = false;
			telaTuto.ShowDialog ();
			Visible = true;
		}
	}
}
