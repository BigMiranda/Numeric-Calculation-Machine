namespace Trabalho_do_Marcio
{
	partial class frBisseccao
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBisseccao));
			this.label1 = new System.Windows.Forms.Label();
			this.txtFuncao = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtX0 = new System.Windows.Forms.TextBox();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.txtErro = new System.Windows.Forms.TextBox();
			this.txtCasasVirgula = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.txtResposta = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.rbtTruncar = new System.Windows.Forms.RadioButton();
			this.rbtArredondar = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSin = new System.Windows.Forms.Button();
			this.btnAsin = new System.Windows.Forms.Button();
			this.btnSinh = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btnCos = new System.Windows.Forms.Button();
			this.btnAcos = new System.Windows.Forms.Button();
			this.btnTag = new System.Windows.Forms.Button();
			this.Atg = new System.Windows.Forms.Button();
			this.btnTgh = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btnLn = new System.Windows.Forms.Button();
			this.btnE = new System.Windows.Forms.Button();
			this.btnX = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btnPi = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btnVirgula = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btnSubtrair = new System.Windows.Forms.Button();
			this.btnSomar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.btnElevado = new System.Windows.Forms.Button();
			this.btnRaizQualquer = new System.Windows.Forms.Button();
			this.btnRaizQuadrada = new System.Windows.Forms.Button();
			this.btnQuadrado = new System.Windows.Forms.Button();
			this.btnParenteseDireito = new System.Windows.Forms.Button();
			this.btnParentesesEsquerdo = new System.Windows.Forms.Button();
			this.btnLog = new System.Windows.Forms.Button();
			this.btnCosh = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnAjuda = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.txtCasasVirgula)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(257, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bissecção";
			// 
			// txtFuncao
			// 
			this.txtFuncao.Location = new System.Drawing.Point(80, 83);
			this.txtFuncao.Name = "txtFuncao";
			this.txtFuncao.Size = new System.Drawing.Size(469, 29);
			this.txtFuncao.TabIndex = 1;
			this.toolTip1.SetToolTip(this.txtFuncao, "Ao referenciar simbolos ( x, e, pi), use * para multiplicar.");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "f(x) =";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(696, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Intervalo:";
			// 
			// txtX0
			// 
			this.txtX0.Location = new System.Drawing.Point(802, 83);
			this.txtX0.Name = "txtX0";
			this.txtX0.Size = new System.Drawing.Size(92, 29);
			this.txtX0.TabIndex = 2;
			// 
			// txtX1
			// 
			this.txtX1.Location = new System.Drawing.Point(802, 129);
			this.txtX1.Name = "txtX1";
			this.txtX1.Size = new System.Drawing.Size(92, 29);
			this.txtX1.TabIndex = 3;
			// 
			// txtErro
			// 
			this.txtErro.Location = new System.Drawing.Point(1036, 86);
			this.txtErro.Name = "txtErro";
			this.txtErro.Size = new System.Drawing.Size(92, 29);
			this.txtErro.TabIndex = 4;
			// 
			// txtCasasVirgula
			// 
			this.txtCasasVirgula.Location = new System.Drawing.Point(985, 258);
			this.txtCasasVirgula.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.txtCasasVirgula.Name = "txtCasasVirgula";
			this.txtCasasVirgula.ReadOnly = true;
			this.txtCasasVirgula.Size = new System.Drawing.Size(110, 29);
			this.txtCasasVirgula.TabIndex = 6;
			this.txtCasasVirgula.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(702, 445);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 36);
			this.label6.TabIndex = 13;
			this.label6.Text = "Resposta:";
			// 
			// txtResposta
			// 
			this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResposta.Location = new System.Drawing.Point(802, 435);
			this.txtResposta.Name = "txtResposta";
			this.txtResposta.ReadOnly = true;
			this.txtResposta.Size = new System.Drawing.Size(381, 38);
			this.txtResposta.TabIndex = 8;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCalcular.Location = new System.Drawing.Point(882, 328);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(152, 73);
			this.btnCalcular.TabIndex = 7;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider1.ContainerControl = this;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(966, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 24);
			this.label4.TabIndex = 20;
			this.label4.Text = "Erro:";
			// 
			// rbtTruncar
			// 
			this.rbtTruncar.AutoSize = true;
			this.rbtTruncar.Location = new System.Drawing.Point(24, 17);
			this.rbtTruncar.Name = "rbtTruncar";
			this.rbtTruncar.Size = new System.Drawing.Size(94, 28);
			this.rbtTruncar.TabIndex = 5;
			this.rbtTruncar.TabStop = true;
			this.rbtTruncar.Text = "Truncar";
			this.rbtTruncar.UseVisualStyleBackColor = true;
			// 
			// rbtArredondar
			// 
			this.rbtArredondar.AutoSize = true;
			this.rbtArredondar.Checked = true;
			this.rbtArredondar.Location = new System.Drawing.Point(24, 52);
			this.rbtArredondar.Name = "rbtArredondar";
			this.rbtArredondar.Size = new System.Drawing.Size(124, 28);
			this.rbtArredondar.TabIndex = 22;
			this.rbtArredondar.TabStop = true;
			this.rbtArredondar.Text = "Arredondar";
			this.rbtArredondar.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtTruncar);
			this.groupBox1.Controls.Add(this.rbtArredondar);
			this.groupBox1.Location = new System.Drawing.Point(710, 207);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(183, 92);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(980, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(187, 24);
			this.label7.TabIndex = 24;
			this.label7.Text = "Casas após a virgula:";
			// 
			// btnSin
			// 
			this.btnSin.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSin.Location = new System.Drawing.Point(80, 167);
			this.btnSin.Name = "btnSin";
			this.btnSin.Size = new System.Drawing.Size(70, 45);
			this.btnSin.TabIndex = 25;
			this.btnSin.TabStop = false;
			this.btnSin.Text = "sin";
			this.btnSin.UseVisualStyleBackColor = false;
			this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
			// 
			// btnAsin
			// 
			this.btnAsin.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsin.Location = new System.Drawing.Point(156, 166);
			this.btnAsin.Name = "btnAsin";
			this.btnAsin.Size = new System.Drawing.Size(70, 45);
			this.btnAsin.TabIndex = 26;
			this.btnAsin.TabStop = false;
			this.btnAsin.Text = "asin";
			this.btnAsin.UseVisualStyleBackColor = false;
			this.btnAsin.Click += new System.EventHandler(this.btnAsin_Click);
			// 
			// btnSinh
			// 
			this.btnSinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSinh.Location = new System.Drawing.Point(232, 166);
			this.btnSinh.Name = "btnSinh";
			this.btnSinh.Size = new System.Drawing.Size(70, 45);
			this.btnSinh.TabIndex = 27;
			this.btnSinh.TabStop = false;
			this.btnSinh.Text = "sinh";
			this.btnSinh.UseVisualStyleBackColor = false;
			this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
			// 
			// btn7
			// 
			this.btn7.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.Location = new System.Drawing.Point(308, 166);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(70, 45);
			this.btn7.TabIndex = 28;
			this.btn7.TabStop = false;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = false;
			this.btn7.Click += new System.EventHandler(this.btn7_Click);
			// 
			// btnCos
			// 
			this.btnCos.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCos.Location = new System.Drawing.Point(80, 235);
			this.btnCos.Name = "btnCos";
			this.btnCos.Size = new System.Drawing.Size(70, 45);
			this.btnCos.TabIndex = 29;
			this.btnCos.TabStop = false;
			this.btnCos.Text = "cos";
			this.btnCos.UseVisualStyleBackColor = false;
			this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
			// 
			// btnAcos
			// 
			this.btnAcos.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAcos.Location = new System.Drawing.Point(156, 234);
			this.btnAcos.Name = "btnAcos";
			this.btnAcos.Size = new System.Drawing.Size(70, 45);
			this.btnAcos.TabIndex = 30;
			this.btnAcos.TabStop = false;
			this.btnAcos.Text = "acos";
			this.btnAcos.UseVisualStyleBackColor = false;
			this.btnAcos.Click += new System.EventHandler(this.btnAcos_Click);
			// 
			// btnTag
			// 
			this.btnTag.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTag.Location = new System.Drawing.Point(80, 303);
			this.btnTag.Name = "btnTag";
			this.btnTag.Size = new System.Drawing.Size(70, 45);
			this.btnTag.TabIndex = 32;
			this.btnTag.TabStop = false;
			this.btnTag.Text = "tg";
			this.btnTag.UseVisualStyleBackColor = false;
			this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
			// 
			// Atg
			// 
			this.Atg.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Atg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Atg.Location = new System.Drawing.Point(156, 303);
			this.Atg.Name = "Atg";
			this.Atg.Size = new System.Drawing.Size(70, 45);
			this.Atg.TabIndex = 33;
			this.Atg.TabStop = false;
			this.Atg.Text = "atg";
			this.Atg.UseVisualStyleBackColor = false;
			this.Atg.Click += new System.EventHandler(this.Atg_Click);
			// 
			// btnTgh
			// 
			this.btnTgh.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTgh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTgh.Location = new System.Drawing.Point(232, 303);
			this.btnTgh.Name = "btnTgh";
			this.btnTgh.Size = new System.Drawing.Size(70, 45);
			this.btnTgh.TabIndex = 34;
			this.btnTgh.TabStop = false;
			this.btnTgh.Text = "tgh";
			this.btnTgh.UseVisualStyleBackColor = false;
			this.btnTgh.Click += new System.EventHandler(this.btnTgh_Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.Location = new System.Drawing.Point(308, 234);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(70, 45);
			this.btn4.TabIndex = 35;
			this.btn4.TabStop = false;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// btnLn
			// 
			this.btnLn.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLn.Location = new System.Drawing.Point(80, 371);
			this.btnLn.Name = "btnLn";
			this.btnLn.Size = new System.Drawing.Size(70, 45);
			this.btnLn.TabIndex = 37;
			this.btnLn.TabStop = false;
			this.btnLn.Text = "ln";
			this.btnLn.UseVisualStyleBackColor = false;
			this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
			// 
			// btnE
			// 
			this.btnE.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnE.Location = new System.Drawing.Point(156, 371);
			this.btnE.Name = "btnE";
			this.btnE.Size = new System.Drawing.Size(70, 45);
			this.btnE.TabIndex = 38;
			this.btnE.TabStop = false;
			this.btnE.Text = "e^x";
			this.btnE.UseVisualStyleBackColor = false;
			this.btnE.Click += new System.EventHandler(this.btnE_Click);
			// 
			// btnX
			// 
			this.btnX.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnX.Location = new System.Drawing.Point(232, 371);
			this.btnX.Name = "btnX";
			this.btnX.Size = new System.Drawing.Size(70, 45);
			this.btnX.TabIndex = 39;
			this.btnX.TabStop = false;
			this.btnX.Text = "x";
			this.btnX.UseVisualStyleBackColor = false;
			this.btnX.Click += new System.EventHandler(this.btnX_Click);
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(308, 303);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(70, 45);
			this.btn1.TabIndex = 40;
			this.btn1.TabStop = false;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btnPi
			// 
			this.btnPi.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPi.Location = new System.Drawing.Point(308, 371);
			this.btnPi.Name = "btnPi";
			this.btnPi.Size = new System.Drawing.Size(70, 45);
			this.btnPi.TabIndex = 41;
			this.btnPi.TabStop = false;
			this.btnPi.Text = "pi";
			this.btnPi.UseVisualStyleBackColor = false;
			this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
			// 
			// btn0
			// 
			this.btn0.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.Location = new System.Drawing.Point(384, 371);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(70, 45);
			this.btn0.TabIndex = 45;
			this.btn0.TabStop = false;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = false;
			this.btn0.Click += new System.EventHandler(this.btn0_Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(384, 303);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(70, 45);
			this.btn2.TabIndex = 44;
			this.btn2.TabStop = false;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.Location = new System.Drawing.Point(384, 234);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(70, 45);
			this.btn5.TabIndex = 43;
			this.btn5.TabStop = false;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = false;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			// 
			// btn8
			// 
			this.btn8.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.Location = new System.Drawing.Point(384, 166);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(70, 45);
			this.btn8.TabIndex = 42;
			this.btn8.TabStop = false;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = false;
			this.btn8.Click += new System.EventHandler(this.btn8_Click);
			// 
			// btnVirgula
			// 
			this.btnVirgula.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVirgula.Location = new System.Drawing.Point(460, 371);
			this.btnVirgula.Name = "btnVirgula";
			this.btnVirgula.Size = new System.Drawing.Size(70, 45);
			this.btnVirgula.TabIndex = 49;
			this.btnVirgula.TabStop = false;
			this.btnVirgula.Text = ".";
			this.btnVirgula.UseVisualStyleBackColor = false;
			this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.Location = new System.Drawing.Point(460, 303);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(70, 45);
			this.btn3.TabIndex = 48;
			this.btn3.TabStop = false;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.Location = new System.Drawing.Point(460, 234);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(70, 45);
			this.btn6.TabIndex = 47;
			this.btn6.TabStop = false;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = false;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			// 
			// btn9
			// 
			this.btn9.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.Location = new System.Drawing.Point(460, 166);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(70, 45);
			this.btn9.TabIndex = 46;
			this.btn9.TabStop = false;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = false;
			this.btn9.Click += new System.EventHandler(this.btn9_Click);
			// 
			// btnSubtrair
			// 
			this.btnSubtrair.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubtrair.Location = new System.Drawing.Point(536, 371);
			this.btnSubtrair.Name = "btnSubtrair";
			this.btnSubtrair.Size = new System.Drawing.Size(70, 45);
			this.btnSubtrair.TabIndex = 53;
			this.btnSubtrair.TabStop = false;
			this.btnSubtrair.Text = "-";
			this.btnSubtrair.UseVisualStyleBackColor = false;
			this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
			// 
			// btnSomar
			// 
			this.btnSomar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSomar.Location = new System.Drawing.Point(536, 303);
			this.btnSomar.Name = "btnSomar";
			this.btnSomar.Size = new System.Drawing.Size(70, 45);
			this.btnSomar.TabIndex = 52;
			this.btnSomar.TabStop = false;
			this.btnSomar.Text = "+";
			this.btnSomar.UseVisualStyleBackColor = false;
			this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
			// 
			// btnDividir
			// 
			this.btnDividir.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDividir.Location = new System.Drawing.Point(536, 234);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(70, 45);
			this.btnDividir.TabIndex = 51;
			this.btnDividir.TabStop = false;
			this.btnDividir.Text = "/";
			this.btnDividir.UseVisualStyleBackColor = false;
			this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicar.Location = new System.Drawing.Point(536, 166);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(70, 45);
			this.btnMultiplicar.TabIndex = 50;
			this.btnMultiplicar.TabStop = false;
			this.btnMultiplicar.Text = "*";
			this.btnMultiplicar.UseVisualStyleBackColor = false;
			this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
			// 
			// btnDeletar
			// 
			this.btnDeletar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDeletar.Location = new System.Drawing.Point(555, 76);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(70, 45);
			this.btnDeletar.TabIndex = 54;
			this.btnDeletar.TabStop = false;
			this.btnDeletar.Text = "AC";
			this.btnDeletar.UseVisualStyleBackColor = false;
			this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
			// 
			// btnElevado
			// 
			this.btnElevado.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnElevado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnElevado.Location = new System.Drawing.Point(384, 435);
			this.btnElevado.Name = "btnElevado";
			this.btnElevado.Size = new System.Drawing.Size(70, 45);
			this.btnElevado.TabIndex = 56;
			this.btnElevado.TabStop = false;
			this.btnElevado.Text = "X^y";
			this.btnElevado.UseVisualStyleBackColor = false;
			this.btnElevado.Click += new System.EventHandler(this.btnElevado_Click);
			// 
			// btnRaizQualquer
			// 
			this.btnRaizQualquer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnRaizQualquer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRaizQualquer.Location = new System.Drawing.Point(536, 435);
			this.btnRaizQualquer.Name = "btnRaizQualquer";
			this.btnRaizQualquer.Size = new System.Drawing.Size(70, 45);
			this.btnRaizQualquer.TabIndex = 55;
			this.btnRaizQualquer.TabStop = false;
			this.btnRaizQualquer.Text = "x√";
			this.btnRaizQualquer.UseVisualStyleBackColor = false;
			this.btnRaizQualquer.Click += new System.EventHandler(this.btnRaizQualquer_Click);
			// 
			// btnRaizQuadrada
			// 
			this.btnRaizQuadrada.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnRaizQuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRaizQuadrada.Location = new System.Drawing.Point(460, 435);
			this.btnRaizQuadrada.Name = "btnRaizQuadrada";
			this.btnRaizQuadrada.Size = new System.Drawing.Size(70, 45);
			this.btnRaizQuadrada.TabIndex = 65;
			this.btnRaizQuadrada.TabStop = false;
			this.btnRaizQuadrada.Text = "√";
			this.btnRaizQuadrada.UseVisualStyleBackColor = false;
			this.btnRaizQuadrada.Click += new System.EventHandler(this.btnRaizQuadrada_Click);
			// 
			// btnQuadrado
			// 
			this.btnQuadrado.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuadrado.Location = new System.Drawing.Point(308, 435);
			this.btnQuadrado.Name = "btnQuadrado";
			this.btnQuadrado.Size = new System.Drawing.Size(70, 45);
			this.btnQuadrado.TabIndex = 63;
			this.btnQuadrado.TabStop = false;
			this.btnQuadrado.Text = "x^2";
			this.btnQuadrado.UseVisualStyleBackColor = false;
			this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
			// 
			// btnParenteseDireito
			// 
			this.btnParenteseDireito.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnParenteseDireito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnParenteseDireito.Location = new System.Drawing.Point(232, 435);
			this.btnParenteseDireito.Name = "btnParenteseDireito";
			this.btnParenteseDireito.Size = new System.Drawing.Size(70, 45);
			this.btnParenteseDireito.TabIndex = 62;
			this.btnParenteseDireito.TabStop = false;
			this.btnParenteseDireito.Text = ")";
			this.btnParenteseDireito.UseVisualStyleBackColor = false;
			this.btnParenteseDireito.Click += new System.EventHandler(this.btnParenteseDireito_Click);
			// 
			// btnParentesesEsquerdo
			// 
			this.btnParentesesEsquerdo.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnParentesesEsquerdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnParentesesEsquerdo.Location = new System.Drawing.Point(156, 435);
			this.btnParentesesEsquerdo.Name = "btnParentesesEsquerdo";
			this.btnParentesesEsquerdo.Size = new System.Drawing.Size(70, 45);
			this.btnParentesesEsquerdo.TabIndex = 61;
			this.btnParentesesEsquerdo.TabStop = false;
			this.btnParentesesEsquerdo.Text = "(";
			this.btnParentesesEsquerdo.UseVisualStyleBackColor = false;
			this.btnParentesesEsquerdo.Click += new System.EventHandler(this.btnParentesesEsquerdo_Click);
			// 
			// btnLog
			// 
			this.btnLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLog.Location = new System.Drawing.Point(80, 435);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(70, 45);
			this.btnLog.TabIndex = 59;
			this.btnLog.TabStop = false;
			this.btnLog.Text = "log";
			this.btnLog.UseVisualStyleBackColor = false;
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			// 
			// btnCosh
			// 
			this.btnCosh.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCosh.Location = new System.Drawing.Point(232, 234);
			this.btnCosh.Name = "btnCosh";
			this.btnCosh.Size = new System.Drawing.Size(70, 45);
			this.btnCosh.TabIndex = 31;
			this.btnCosh.TabStop = false;
			this.btnCosh.Text = "cosh";
			this.btnCosh.UseVisualStyleBackColor = false;
			this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 50;
			this.toolTip1.AutoPopDelay = 50000;
			this.toolTip1.InitialDelay = 50;
			this.toolTip1.ReshowDelay = 10;
			// 
			// btnAjuda
			// 
			this.btnAjuda.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAjuda.Location = new System.Drawing.Point(-1, 479);
			this.btnAjuda.Name = "btnAjuda";
			this.btnAjuda.Size = new System.Drawing.Size(57, 45);
			this.btnAjuda.TabIndex = 66;
			this.btnAjuda.TabStop = false;
			this.btnAjuda.Text = "?";
			this.btnAjuda.UseVisualStyleBackColor = false;
			this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
			// 
			// frBisseccao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(1204, 524);
			this.Controls.Add(this.btnAjuda);
			this.Controls.Add(this.btnRaizQuadrada);
			this.Controls.Add(this.btnQuadrado);
			this.Controls.Add(this.btnParenteseDireito);
			this.Controls.Add(this.btnParentesesEsquerdo);
			this.Controls.Add(this.btnLog);
			this.Controls.Add(this.btnElevado);
			this.Controls.Add(this.btnRaizQualquer);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnSubtrair);
			this.Controls.Add(this.btnSomar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnVirgula);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btnPi);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btnX);
			this.Controls.Add(this.btnE);
			this.Controls.Add(this.btnLn);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btnTgh);
			this.Controls.Add(this.Atg);
			this.Controls.Add(this.btnTag);
			this.Controls.Add(this.btnCosh);
			this.Controls.Add(this.btnAcos);
			this.Controls.Add(this.btnCos);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btnSinh);
			this.Controls.Add(this.btnAsin);
			this.Controls.Add(this.btnSin);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtResposta);
			this.Controls.Add(this.txtCasasVirgula);
			this.Controls.Add(this.txtErro);
			this.Controls.Add(this.txtX1);
			this.Controls.Add(this.txtX0);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFuncao);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frBisseccao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Método da Bissecção";
			((System.ComponentModel.ISupportInitialize)(this.txtCasasVirgula)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFuncao;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtX0;
		private System.Windows.Forms.TextBox txtX1;
		private System.Windows.Forms.TextBox txtErro;
		private System.Windows.Forms.NumericUpDown txtCasasVirgula;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtResposta;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbtTruncar;
		private System.Windows.Forms.RadioButton rbtArredondar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnRaizQuadrada;
		private System.Windows.Forms.Button btnQuadrado;
		private System.Windows.Forms.Button btnParenteseDireito;
		private System.Windows.Forms.Button btnParentesesEsquerdo;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.Button btnElevado;
		private System.Windows.Forms.Button btnRaizQualquer;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.Button btnSubtrair;
		private System.Windows.Forms.Button btnSomar;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnVirgula;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btnPi;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btnX;
		private System.Windows.Forms.Button btnE;
		private System.Windows.Forms.Button btnLn;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btnTgh;
		private System.Windows.Forms.Button Atg;
		private System.Windows.Forms.Button btnTag;
		private System.Windows.Forms.Button btnCosh;
		private System.Windows.Forms.Button btnAcos;
		private System.Windows.Forms.Button btnCos;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btnSinh;
		private System.Windows.Forms.Button btnAsin;
		private System.Windows.Forms.Button btnSin;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnAjuda;
	}
}