namespace CalculadoraUTEC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtPantalla = new TextBox();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnCuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSiete = new Button();
            btnOcho = new Button();
            btnNueve = new Button();
            btnCero = new Button();
            btnDivision = new Button();
            btnResultado = new Button();
            btnMultiplicar = new Button();
            btnBorrar = new Button();
            btnResta = new Button();
            btnPunto = new Button();
            btnSuma = new Button();
            lblHistorial = new Label();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.BorderStyle = BorderStyle.None;
            txtPantalla.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPantalla.Location = new Point(27, 54);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(229, 28);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.FlatStyle = FlatStyle.Flat;
            btnUno.ImeMode = ImeMode.NoControl;
            btnUno.Location = new Point(27, 186);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(41, 35);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += btnUno_Click;
            // 
            // btnDos
            // 
            btnDos.FlatStyle = FlatStyle.Flat;
            btnDos.ImeMode = ImeMode.NoControl;
            btnDos.Location = new Point(74, 186);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(41, 35);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += btnUno_Click;
            // 
            // btnTres
            // 
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.ImeMode = ImeMode.NoControl;
            btnTres.Location = new Point(121, 186);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(41, 35);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnUno_Click;
            // 
            // btnCuatro
            // 
            btnCuatro.FlatStyle = FlatStyle.Flat;
            btnCuatro.ImeMode = ImeMode.NoControl;
            btnCuatro.Location = new Point(27, 145);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(41, 35);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += btnUno_Click;
            // 
            // btnCinco
            // 
            btnCinco.FlatStyle = FlatStyle.Flat;
            btnCinco.ImeMode = ImeMode.NoControl;
            btnCinco.Location = new Point(74, 145);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(41, 35);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnUno_Click;
            // 
            // btnSeis
            // 
            btnSeis.FlatStyle = FlatStyle.Flat;
            btnSeis.ImeMode = ImeMode.NoControl;
            btnSeis.Location = new Point(121, 145);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(41, 35);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnUno_Click;
            // 
            // btnSiete
            // 
            btnSiete.FlatStyle = FlatStyle.Flat;
            btnSiete.ImeMode = ImeMode.NoControl;
            btnSiete.Location = new Point(27, 104);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(41, 35);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += btnUno_Click;
            // 
            // btnOcho
            // 
            btnOcho.FlatStyle = FlatStyle.Flat;
            btnOcho.ImeMode = ImeMode.NoControl;
            btnOcho.Location = new Point(74, 104);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(41, 35);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += btnUno_Click;
            // 
            // btnNueve
            // 
            btnNueve.FlatStyle = FlatStyle.Flat;
            btnNueve.ImeMode = ImeMode.NoControl;
            btnNueve.Location = new Point(121, 104);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(41, 35);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += btnUno_Click;
            // 
            // btnCero
            // 
            btnCero.FlatStyle = FlatStyle.Flat;
            btnCero.ImeMode = ImeMode.NoControl;
            btnCero.Location = new Point(27, 227);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(88, 35);
            btnCero.TabIndex = 10;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += btnUno_Click;
            // 
            // btnDivision
            // 
            btnDivision.FlatStyle = FlatStyle.Flat;
            btnDivision.ImeMode = ImeMode.NoControl;
            btnDivision.Location = new Point(168, 104);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(41, 35);
            btnDivision.TabIndex = 11;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnSuma_Click;
            // 
            // btnResultado
            // 
            btnResultado.FlatStyle = FlatStyle.Flat;
            btnResultado.ImeMode = ImeMode.NoControl;
            btnResultado.Location = new Point(215, 145);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(41, 117);
            btnResultado.TabIndex = 12;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.FlatStyle = FlatStyle.Flat;
            btnMultiplicar.ImeMode = ImeMode.NoControl;
            btnMultiplicar.Location = new Point(168, 145);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(41, 35);
            btnMultiplicar.TabIndex = 13;
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnSuma_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ImeMode = ImeMode.NoControl;
            btnBorrar.Location = new Point(215, 104);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(41, 35);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "C";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnResta
            // 
            btnResta.FlatStyle = FlatStyle.Flat;
            btnResta.ImeMode = ImeMode.NoControl;
            btnResta.Location = new Point(168, 186);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(41, 35);
            btnResta.TabIndex = 15;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnSuma_Click;
            // 
            // btnPunto
            // 
            btnPunto.FlatStyle = FlatStyle.Flat;
            btnPunto.ImeMode = ImeMode.NoControl;
            btnPunto.Location = new Point(121, 227);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(41, 35);
            btnPunto.TabIndex = 16;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnUno_Click;
            // 
            // btnSuma
            // 
            btnSuma.FlatStyle = FlatStyle.Flat;
            btnSuma.ImeMode = ImeMode.NoControl;
            btnSuma.Location = new Point(168, 227);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(41, 35);
            btnSuma.TabIndex = 17;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistorial.ForeColor = SystemColors.ButtonShadow;
            lblHistorial.Location = new Point(209, 34);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.RightToLeft = RightToLeft.No;
            lblHistorial.Size = new Size(0, 17);
            lblHistorial.TabIndex = 18;
            lblHistorial.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 304);
            Controls.Add(lblHistorial);
            Controls.Add(btnSuma);
            Controls.Add(btnPunto);
            Controls.Add(btnResta);
            Controls.Add(btnBorrar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnResultado);
            Controls.Add(btnDivision);
            Controls.Add(btnCero);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtPantalla);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnCuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSiete;
        private Button btnOcho;
        private Button btnNueve;
        private Button btnCero;
        private Button btnDivision;
        private Button btnResultado;
        private Button btnMultiplicar;
        private Button btnBorrar;
        private Button btnResta;
        private Button btnPunto;
        private Button btnSuma;
        private Label lblHistorial;
    }
}
