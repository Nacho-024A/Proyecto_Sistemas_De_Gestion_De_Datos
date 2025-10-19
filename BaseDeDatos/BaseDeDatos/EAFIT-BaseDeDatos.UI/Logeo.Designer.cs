namespace EAFIT_BaseDeDatos.UI
{
    partial class Logeo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logeo));
            LblTitulo = new Label();
            pictureBox1 = new PictureBox();
            TxtPassword = new TextBox();
            TxtUsuario = new TextBox();
            LblPassword = new Label();
            LblUsuario = new Label();
            BtnIngresar = new Button();
            BtnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Navy;
            LblTitulo.Location = new Point(233, 59);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(266, 58);
            LblTitulo.TabIndex = 15;
            LblTitulo.Text = "Aplicación Base De Datos\r\n                   Logeo ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 14);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPassword.Location = new Point(232, 211);
            TxtPassword.Margin = new Padding(4, 5, 4, 5);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '&';
            TxtPassword.Size = new Size(241, 37);
            TxtPassword.TabIndex = 2;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsuario.Location = new Point(232, 149);
            TxtUsuario.Margin = new Padding(4, 5, 4, 5);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(241, 37);
            TxtUsuario.TabIndex = 1;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPassword.ForeColor = Color.Navy;
            LblPassword.Location = new Point(87, 212);
            LblPassword.Margin = new Padding(4, 0, 4, 0);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(135, 29);
            LblPassword.TabIndex = 11;
            LblPassword.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsuario.ForeColor = Color.Navy;
            LblUsuario.Location = new Point(87, 151);
            LblUsuario.Margin = new Padding(4, 0, 4, 0);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(97, 29);
            LblUsuario.TabIndex = 10;
            LblUsuario.Text = "Usuario:";
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.Navy;
            BtnIngresar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(143, 309);
            BtnIngresar.Margin = new Padding(4, 5, 4, 5);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(147, 60);
            BtnIngresar.TabIndex = 3;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Navy;
            BtnSalir.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(328, 309);
            BtnSalir.Margin = new Padding(4, 5, 4, 5);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(147, 60);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // Logeo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(538, 425);
            Controls.Add(LblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsuario);
            Controls.Add(LblPassword);
            Controls.Add(LblUsuario);
            Controls.Add(BtnIngresar);
            Controls.Add(BtnSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Logeo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Universidad EAFIT - Base De Datos - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private PictureBox pictureBox1;
        private TextBox TxtPassword;
        private TextBox TxtUsuario;
        private Label LblPassword;
        private Label LblUsuario;
        private Button BtnIngresar;
        private Button BtnSalir;
    }
}