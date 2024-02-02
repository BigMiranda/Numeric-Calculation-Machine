namespace Trabalho_do_Marcio
{
	partial class frTutorialInterpolacaoSI
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
			this.btnProsseguir = new System.Windows.Forms.Button();
			this.imgSlide = new System.Windows.Forms.PictureBox();
			this.btnAnterior = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
			this.SuspendLayout();
			// 
			// btnProsseguir
			// 
			this.btnProsseguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProsseguir.Location = new System.Drawing.Point(713, 392);
			this.btnProsseguir.Name = "btnProsseguir";
			this.btnProsseguir.Size = new System.Drawing.Size(63, 46);
			this.btnProsseguir.TabIndex = 1;
			this.btnProsseguir.Text = "Próximo";
			this.btnProsseguir.UseVisualStyleBackColor = true;
			this.btnProsseguir.Click += new System.EventHandler(this.button1_Click);
			// 
			// imgSlide
			// 
			this.imgSlide.BackgroundImage = global::Trabalho_do_Marcio.Properties.Resources.interpolação__01;
			this.imgSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.imgSlide.Location = new System.Drawing.Point(0, 0);
			this.imgSlide.Name = "imgSlide";
			this.imgSlide.Size = new System.Drawing.Size(799, 451);
			this.imgSlide.TabIndex = 0;
			this.imgSlide.TabStop = false;
			// 
			// btnAnterior
			// 
			this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnterior.Location = new System.Drawing.Point(617, 392);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(63, 46);
			this.btnAnterior.TabIndex = 2;
			this.btnAnterior.Text = "Anterior";
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.button2_Click);
			// 
			// frTutorialInterpolacaoSI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.btnProsseguir);
			this.Controls.Add(this.imgSlide);
			this.Name = "frTutorialInterpolacaoSI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frTutorialInterpolacaoSI";
			((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox imgSlide;
		private System.Windows.Forms.Button btnProsseguir;
		private System.Windows.Forms.Button btnAnterior;
	}
}