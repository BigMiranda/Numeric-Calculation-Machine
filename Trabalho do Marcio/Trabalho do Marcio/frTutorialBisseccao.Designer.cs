namespace Trabalho_do_Marcio
{
	partial class frTutorialBisseccao
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnProsseguir = new System.Windows.Forms.Button();
			this.imgSlide1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imgSlide1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
			this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnterior.Location = new System.Drawing.Point(516, 421);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(63, 46);
			this.btnAnterior.TabIndex = 1;
			this.btnAnterior.Text = "Anterior";
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnProsseguir
			// 
			this.btnProsseguir.BackColor = System.Drawing.Color.Transparent;
			this.btnProsseguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProsseguir.Location = new System.Drawing.Point(634, 421);
			this.btnProsseguir.Name = "btnProsseguir";
			this.btnProsseguir.Size = new System.Drawing.Size(63, 46);
			this.btnProsseguir.TabIndex = 2;
			this.btnProsseguir.Text = "Próximo";
			this.btnProsseguir.UseVisualStyleBackColor = false;
			this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
			// 
			// imgSlide1
			// 
			this.imgSlide1.BackgroundImage = global::Trabalho_do_Marcio.Properties.Resources.bissecção_slide_01;
			this.imgSlide1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.imgSlide1.Location = new System.Drawing.Point(-2, -96);
			this.imgSlide1.Name = "imgSlide1";
			this.imgSlide1.Size = new System.Drawing.Size(846, 671);
			this.imgSlide1.TabIndex = 0;
			this.imgSlide1.TabStop = false;
			// 
			// frTutorialBisseccao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 479);
			this.Controls.Add(this.btnProsseguir);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.imgSlide1);
			this.Name = "frTutorialBisseccao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frTutorialBisseccao";
			this.Load += new System.EventHandler(this.frTutorialBisseccao_Load);
			((System.ComponentModel.ISupportInitialize)(this.imgSlide1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox imgSlide1;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnProsseguir;
	}
}