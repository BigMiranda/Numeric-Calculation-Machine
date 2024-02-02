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
	public partial class frTutorialBisseccao : Form
	{
		public frTutorialBisseccao ( )
		{
			InitializeComponent ();
			contagem = 0;
			
		}
		int contagem ;
		private void frTutorialBisseccao_Load ( object sender, EventArgs e )
		{
			 
		}
		
		private void btnProsseguir_Click ( object sender, EventArgs e )
		{
			if (contagem < 23)
			{
				contagem++;
			}
			

			if (contagem == 0)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_01;
			if(contagem==1)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_02;
			if (contagem == 2)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_03;
			if (contagem == 3)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_04;
			if (contagem == 4)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_05;
			if (contagem == 5)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_06;
			if (contagem == 6)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_07;
			if (contagem == 7)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_08;
			if (contagem == 8)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_09;
			if (contagem == 9)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_10;
			if (contagem == 10)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_11;
			if (contagem == 11)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_12;
			if (contagem == 12)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_13;
			if (contagem == 13)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_14;
			if (contagem == 14)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_15;
			if (contagem == 15)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_16;
			if (contagem == 16)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_17;
			if (contagem == 17)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_18;
			if (contagem == 18)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_19;
			if (contagem == 19)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_20;
			if (contagem == 20)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_21;
			if (contagem == 21)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_22;
			if (contagem == 22)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_23;
			if (contagem == 23)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_24;


		}

		private void button1_Click ( object sender, EventArgs e )
		{
			if (contagem >= 0)
			{
				contagem--;
			}
			

			if (contagem == 0)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_01;
			if (contagem == 1)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_02;
			if (contagem == 2)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_03;
			if (contagem == 3)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_04;
			if (contagem == 4)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_05;
			if (contagem == 5)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_06;
			if (contagem == 6)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_07;
			if (contagem == 7)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_08;
			if (contagem == 8)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_09;
			if (contagem == 9)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_10;
			if (contagem == 10)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_11;
			if (contagem == 11)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_12;
			if (contagem == 12)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_13;
			if (contagem == 13)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_14;
			if (contagem == 14)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_16;
			if (contagem == 15)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_17;
			if (contagem == 16)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_18;
			if (contagem == 17)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_19;
			if (contagem == 18)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_20;
			if (contagem == 19)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_21;
			if (contagem == 20)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_22;
			if (contagem == 21)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_23;
			if (contagem == 22)
				imgSlide1.BackgroundImage = Trabalho_do_Marcio.Properties.Resources.bissecção_slide_24;
		}
	}
}
