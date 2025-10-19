namespace EAFIT_BaseDeDatos.UI
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            BtnSalir = new Button();
            BtnIngresar = new Button();
            TxtApellidos = new TextBox();
            TxtUsuario = new TextBox();
            LblPassword = new Label();
            LblUsuario = new Label();
            LblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtNameUser = new TextBox();
            CBClientType = new ComboBox();
            TxtPassword = new TextBox();
            label5 = new Label();
            TxtPassword2 = new TextBox();
            label6 = new Label();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            TxtEmail = new TextBox();
            CBState = new ComboBox();
            BtnNewUser = new Button();
            BtnConsultar = new Button();
            SuspendLayout();
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Navy;
            BtnSalir.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(1071, 658);
            BtnSalir.Margin = new Padding(4, 5, 4, 5);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(162, 58);
            BtnSalir.TabIndex = 15;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.Navy;
            BtnIngresar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(674, 544);
            BtnIngresar.Margin = new Padding(4, 5, 4, 5);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(162, 58);
            BtnIngresar.TabIndex = 11;
            BtnIngresar.Text = "Guardar!!";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // TxtApellidos
            // 
            TxtApellidos.Font = new Font("Candara Light", 10F);
            TxtApellidos.Location = new Point(349, 404);
            TxtApellidos.Margin = new Padding(4, 5, 4, 5);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new Size(265, 32);
            TxtApellidos.TabIndex = 5;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font("Candara Light", 10F);
            TxtUsuario.Location = new Point(349, 335);
            TxtUsuario.Margin = new Padding(4, 5, 4, 5);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(265, 32);
            TxtUsuario.TabIndex = 4;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPassword.ForeColor = Color.Navy;
            LblPassword.Location = new Point(87, 412);
            LblPassword.Margin = new Padding(4, 0, 4, 0);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(195, 29);
            LblPassword.TabIndex = 17;
            LblPassword.Text = "Apellidos Usuario:";
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsuario.ForeColor = Color.Navy;
            LblUsuario.Location = new Point(87, 337);
            LblUsuario.Margin = new Padding(4, 0, 4, 0);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(185, 29);
            LblUsuario.TabIndex = 16;
            LblUsuario.Text = "Nombre Usuario:";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Navy;
            LblTitulo.Location = new Point(475, 78);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(385, 29);
            LblTitulo.TabIndex = 19;
            LblTitulo.Text = "Administración de usuarios y clientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(87, 560);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 23;
            label1.Text = "Cliente / Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(87, 480);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 29);
            label2.TabIndex = 22;
            label2.Text = "Correo Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(87, 643);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 29);
            label3.TabIndex = 24;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(87, 268);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(233, 29);
            label4.TabIndex = 25;
            label4.Text = "Usuario de aplicación:";
            // 
            // TxtNameUser
            // 
            TxtNameUser.Font = new Font("Candara Light", 10F);
            TxtNameUser.Location = new Point(349, 265);
            TxtNameUser.Margin = new Padding(4, 5, 4, 5);
            TxtNameUser.Name = "TxtNameUser";
            TxtNameUser.Size = new Size(265, 32);
            TxtNameUser.TabIndex = 3;
            // 
            // CBClientType
            // 
            CBClientType.Font = new Font("Candara Light", 10F);
            CBClientType.FormattingEnabled = true;
            CBClientType.Items.AddRange(new object[] { "--Seleccionar--", "   Cliente", "   Usuario", "   Otro..." });
            CBClientType.Location = new Point(349, 560);
            CBClientType.Name = "CBClientType";
            CBClientType.Size = new Size(265, 32);
            CBClientType.TabIndex = 7;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Candara Light", 10F);
            TxtPassword.Location = new Point(937, 336);
            TxtPassword.Margin = new Padding(4, 5, 4, 5);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '☻';
            TxtPassword.Size = new Size(265, 32);
            TxtPassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(662, 339);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 29);
            label5.TabIndex = 30;
            label5.Text = "Contraseña:";
            // 
            // TxtPassword2
            // 
            TxtPassword2.Font = new Font("Candara Light", 10F);
            TxtPassword2.Location = new Point(937, 403);
            TxtPassword2.Margin = new Padding(4, 5, 4, 5);
            TxtPassword2.Name = "TxtPassword2";
            TxtPassword2.PasswordChar = '☺';
            TxtPassword2.Size = new Size(265, 32);
            TxtPassword2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(662, 406);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(242, 29);
            label6.TabIndex = 32;
            label6.Text = "Confirmar Contraseña:";
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.Navy;
            BtnUpdate.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(871, 544);
            BtnUpdate.Margin = new Padding(4, 5, 4, 5);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(162, 58);
            BtnUpdate.TabIndex = 13;
            BtnUpdate.Text = "Actualizar!!";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Navy;
            BtnDelete.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.ForeColor = Color.White;
            BtnDelete.Location = new Point(1071, 545);
            BtnDelete.Margin = new Padding(4, 5, 4, 5);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(162, 58);
            BtnDelete.TabIndex = 14;
            BtnDelete.Text = "Inactivar!!";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Candara Light", 10F);
            TxtEmail.Location = new Point(349, 481);
            TxtEmail.Margin = new Padding(4, 5, 4, 5);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(265, 32);
            TxtEmail.TabIndex = 6;
            // 
            // CBState
            // 
            CBState.Font = new Font("Candara Light", 10F);
            CBState.FormattingEnabled = true;
            CBState.Items.AddRange(new object[] { "--Seleccionar--", "   Activo", "   Inactivo" });
            CBState.Location = new Point(349, 644);
            CBState.Name = "CBState";
            CBState.Size = new Size(265, 32);
            CBState.TabIndex = 8;
            // 
            // BtnNewUser
            // 
            BtnNewUser.BackColor = Color.Navy;
            BtnNewUser.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNewUser.ForeColor = Color.White;
            BtnNewUser.Location = new Point(87, 155);
            BtnNewUser.Margin = new Padding(4, 5, 4, 5);
            BtnNewUser.Name = "BtnNewUser";
            BtnNewUser.Size = new Size(162, 58);
            BtnNewUser.TabIndex = 1;
            BtnNewUser.Text = "Nuevo!!";
            BtnNewUser.UseVisualStyleBackColor = false;
            BtnNewUser.Click += BtnNewUser_Click;
            // 
            // BtnConsultar
            // 
            BtnConsultar.BackColor = Color.Navy;
            BtnConsultar.Font = new Font("Candara", 9F);
            BtnConsultar.ForeColor = Color.White;
            BtnConsultar.Location = new Point(662, 259);
            BtnConsultar.Margin = new Padding(4, 5, 4, 5);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(135, 44);
            BtnConsultar.TabIndex = 12;
            BtnConsultar.Text = "Consultar!!";
            BtnConsultar.UseVisualStyleBackColor = false;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1246, 730);
            Controls.Add(BtnConsultar);
            Controls.Add(BtnNewUser);
            Controls.Add(CBState);
            Controls.Add(TxtEmail);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(TxtPassword2);
            Controls.Add(label6);
            Controls.Add(TxtPassword);
            Controls.Add(label5);
            Controls.Add(CBClientType);
            Controls.Add(TxtNameUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(LblTitulo);
            Controls.Add(TxtApellidos);
            Controls.Add(TxtUsuario);
            Controls.Add(LblPassword);
            Controls.Add(LblUsuario);
            Controls.Add(BtnIngresar);
            Controls.Add(BtnSalir);
            Font = new Font("Candara Light", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EAFIT - Administración de usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalir;
        private Button BtnIngresar;
        private TextBox TxtApellidos;
        private TextBox TxtUsuario;
        private Label LblPassword;
        private Label LblUsuario;
        private Label LblTitulo;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtNameUser;
        private ComboBox comboBox1;
        private ComboBox CBClientType;
        private TextBox TxtPassword;
        private Label label5;
        private TextBox TxtPassword2;
        private Label label6;
        private Button BtnUpdate;
        private Button BtnDelete;
        private TextBox TxtEmail;
        private ComboBox CBState;
        private Button BtnNewUser;
        private Button BtnConsultar;
    }
}