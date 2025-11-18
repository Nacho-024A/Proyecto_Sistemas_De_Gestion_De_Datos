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
            TxtNombre = new TextBox();
            TxtTipoDocumento = new TextBox();
            LblPassword = new Label();
            LblUsuario = new Label();
            LblTitulo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtId = new TextBox();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            TxtEmail = new TextBox();
            CBEstado = new ComboBox();
            BtnNewUser = new Button();
            BtnConsultar = new Button();
            TxtNumeroDocumento = new TextBox();
            TxTApellido = new TextBox();
            label7 = new Label();
            TxTTelefono = new TextBox();
            label8 = new Label();
            TxTDireccion = new TextBox();
            label9 = new Label();
            TxTFechaNacimiento = new TextBox();
            label10 = new Label();
            TxTGenero = new TextBox();
            label5 = new Label();
            TxTSalario = new TextBox();
            label6 = new Label();
            TxTFechaVinculacion = new TextBox();
            label11 = new Label();
            TxTSemestre = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label1 = new Label();
            TxtCargo = new TextBox();
            label15 = new Label();
            cboFacultades = new ComboBox();
            cboCarreras = new ComboBox();
            btnActivate = new Button();
            cboPensums = new ComboBox();
            SuspendLayout();
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Navy;
            BtnSalir.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(1351, 532);
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
            BtnIngresar.Location = new Point(1351, 445);
            BtnIngresar.Margin = new Padding(4, 5, 4, 5);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(162, 58);
            BtnIngresar.TabIndex = 11;
            BtnIngresar.Text = "Guardar";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Candara Light", 10F);
            TxtNombre.Location = new Point(267, 288);
            TxtNombre.Margin = new Padding(4, 5, 4, 5);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(328, 28);
            TxtNombre.TabIndex = 5;
            // 
            // TxtTipoDocumento
            // 
            TxtTipoDocumento.Font = new Font("Candara Light", 10F);
            TxtTipoDocumento.Location = new Point(267, 227);
            TxtTipoDocumento.Margin = new Padding(4, 5, 4, 5);
            TxtTipoDocumento.Name = "TxtTipoDocumento";
            TxtTipoDocumento.Size = new Size(92, 28);
            TxtTipoDocumento.TabIndex = 4;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPassword.ForeColor = Color.Navy;
            LblPassword.Location = new Point(68, 288);
            LblPassword.Margin = new Padding(4, 0, 4, 0);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(83, 24);
            LblPassword.TabIndex = 17;
            LblPassword.Text = "Nombre:";
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsuario.ForeColor = Color.Navy;
            LblUsuario.Location = new Point(68, 227);
            LblUsuario.Margin = new Padding(4, 0, 4, 0);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(114, 24);
            LblUsuario.TabIndex = 16;
            LblUsuario.Text = "Documento:";
            LblUsuario.Click += LblUsuario_Click;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Navy;
            LblTitulo.Location = new Point(584, 44);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(315, 24);
            LblTitulo.TabIndex = 19;
            LblTitulo.Text = "Administración de usuarios y clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(68, 405);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 24);
            label2.TabIndex = 22;
            label2.Text = "Correo Electronico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(694, 663);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 24);
            label3.TabIndex = 24;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(68, 170);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(32, 24);
            label4.TabIndex = 25;
            label4.Text = "Id:";
            label4.Click += label4_Click;
            // 
            // TxtId
            // 
            TxtId.Font = new Font("Candara Light", 10F);
            TxtId.Location = new Point(267, 170);
            TxtId.Margin = new Padding(4, 5, 4, 5);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(92, 28);
            TxtId.TabIndex = 3;
            TxtId.TextChanged += TxtNameUser_TextChanged;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.Navy;
            BtnUpdate.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(1351, 153);
            BtnUpdate.Margin = new Padding(4, 5, 4, 5);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(162, 58);
            BtnUpdate.TabIndex = 13;
            BtnUpdate.Text = "Actualizar";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Navy;
            BtnDelete.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.ForeColor = Color.White;
            BtnDelete.Location = new Point(1351, 258);
            BtnDelete.Margin = new Padding(4, 5, 4, 5);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(162, 58);
            BtnDelete.TabIndex = 14;
            BtnDelete.Text = "Inactivar";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Candara Light", 10F);
            TxtEmail.Location = new Point(267, 405);
            TxtEmail.Margin = new Padding(4, 5, 4, 5);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(328, 28);
            TxtEmail.TabIndex = 6;
            // 
            // CBEstado
            // 
            CBEstado.Font = new Font("Candara Light", 10F);
            CBEstado.FormattingEnabled = true;
            CBEstado.Items.AddRange(new object[] { "--Seleccionar--", "   Activo", "   Inactivo" });
            CBEstado.Location = new Point(893, 658);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(328, 29);
            CBEstado.TabIndex = 8;
            CBEstado.SelectedIndexChanged += CBEstado_SelectedIndexChanged;
            // 
            // BtnNewUser
            // 
            BtnNewUser.BackColor = Color.Navy;
            BtnNewUser.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNewUser.ForeColor = Color.White;
            BtnNewUser.Location = new Point(87, 61);
            BtnNewUser.Margin = new Padding(4, 5, 4, 5);
            BtnNewUser.Name = "BtnNewUser";
            BtnNewUser.Size = new Size(162, 58);
            BtnNewUser.TabIndex = 1;
            BtnNewUser.Text = "Limpiar Formulario";
            BtnNewUser.UseVisualStyleBackColor = false;
            BtnNewUser.Click += BtnNewUser_Click;
            // 
            // BtnConsultar
            // 
            BtnConsultar.BackColor = Color.Navy;
            BtnConsultar.Font = new Font("Candara", 12F);
            BtnConsultar.ForeColor = Color.White;
            BtnConsultar.Location = new Point(289, 61);
            BtnConsultar.Margin = new Padding(4, 5, 4, 5);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(178, 56);
            BtnConsultar.TabIndex = 12;
            BtnConsultar.Text = "Consultar";
            BtnConsultar.UseVisualStyleBackColor = false;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // TxtNumeroDocumento
            // 
            TxtNumeroDocumento.Font = new Font("Candara Light", 10F);
            TxtNumeroDocumento.Location = new Point(382, 227);
            TxtNumeroDocumento.Margin = new Padding(4, 5, 4, 5);
            TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            TxtNumeroDocumento.Size = new Size(213, 28);
            TxtNumeroDocumento.TabIndex = 33;
            // 
            // TxTApellido
            // 
            TxTApellido.Font = new Font("Candara Light", 10F);
            TxTApellido.Location = new Point(267, 347);
            TxTApellido.Margin = new Padding(4, 5, 4, 5);
            TxTApellido.Name = "TxTApellido";
            TxTApellido.Size = new Size(328, 28);
            TxTApellido.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(68, 347);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 24);
            label7.TabIndex = 35;
            label7.Text = "Apellido:";
            label7.Click += label7_Click;
            // 
            // TxTTelefono
            // 
            TxTTelefono.Font = new Font("Candara Light", 10F);
            TxTTelefono.Location = new Point(267, 468);
            TxTTelefono.Margin = new Padding(4, 5, 4, 5);
            TxTTelefono.Name = "TxTTelefono";
            TxTTelefono.Size = new Size(328, 28);
            TxTTelefono.TabIndex = 36;
            TxTTelefono.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(68, 468);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 24);
            label8.TabIndex = 37;
            label8.Text = "Telefono:";
            // 
            // TxTDireccion
            // 
            TxTDireccion.Font = new Font("Candara Light", 10F);
            TxTDireccion.Location = new Point(267, 527);
            TxTDireccion.Margin = new Padding(4, 5, 4, 5);
            TxTDireccion.Name = "TxTDireccion";
            TxTDireccion.Size = new Size(328, 28);
            TxTDireccion.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(68, 527);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 24);
            label9.TabIndex = 39;
            label9.Text = "Direccion:";
            // 
            // TxTFechaNacimiento
            // 
            TxTFechaNacimiento.Font = new Font("Candara Light", 10F);
            TxTFechaNacimiento.Location = new Point(267, 595);
            TxTFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            TxTFechaNacimiento.Name = "TxTFechaNacimiento";
            TxTFechaNacimiento.Size = new Size(328, 28);
            TxTFechaNacimiento.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(68, 595);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(164, 24);
            label10.TabIndex = 41;
            label10.Text = "Fecha Nacimiento:";
            // 
            // TxTGenero
            // 
            TxTGenero.Font = new Font("Candara Light", 10F);
            TxTGenero.Location = new Point(267, 658);
            TxTGenero.Margin = new Padding(4, 5, 4, 5);
            TxTGenero.Name = "TxTGenero";
            TxTGenero.Size = new Size(328, 28);
            TxTGenero.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(68, 658);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 24);
            label5.TabIndex = 43;
            label5.Text = "Genero:";
            label5.Click += label5_Click;
            // 
            // TxTSalario
            // 
            TxTSalario.Font = new Font("Candara Light", 10F);
            TxTSalario.Location = new Point(893, 258);
            TxTSalario.Margin = new Padding(4, 5, 4, 5);
            TxTSalario.Name = "TxTSalario";
            TxTSalario.Size = new Size(328, 28);
            TxTSalario.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(694, 258);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 24);
            label6.TabIndex = 47;
            label6.Text = "Salario:";
            // 
            // TxTFechaVinculacion
            // 
            TxTFechaVinculacion.Font = new Font("Candara Light", 10F);
            TxTFechaVinculacion.Location = new Point(893, 195);
            TxTFechaVinculacion.Margin = new Padding(4, 5, 4, 5);
            TxTFechaVinculacion.Name = "TxTFechaVinculacion";
            TxTFechaVinculacion.Size = new Size(328, 28);
            TxTFechaVinculacion.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(694, 195);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(165, 24);
            label11.TabIndex = 45;
            label11.Text = "Fecha Vinculacion:";
            // 
            // TxTSemestre
            // 
            TxTSemestre.Font = new Font("Candara Light", 10F);
            TxTSemestre.Location = new Point(893, 330);
            TxTSemestre.Margin = new Padding(4, 5, 4, 5);
            TxTSemestre.Name = "TxTSemestre";
            TxTSemestre.Size = new Size(328, 28);
            TxTSemestre.TabIndex = 48;
            TxTSemestre.TextChanged += textBox1_TextChanged_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(694, 330);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(93, 24);
            label12.TabIndex = 49;
            label12.Text = "Semestre:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(694, 538);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(77, 24);
            label13.TabIndex = 51;
            label13.Text = "Carrera:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(694, 595);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(82, 24);
            label14.TabIndex = 53;
            label14.Text = "Pensum:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(694, 474);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 55;
            label1.Text = "Facultad:";
            // 
            // TxtCargo
            // 
            TxtCargo.Font = new Font("Candara Light", 10F);
            TxtCargo.Location = new Point(893, 401);
            TxtCargo.Margin = new Padding(4, 5, 4, 5);
            TxtCargo.Name = "TxtCargo";
            TxtCargo.Size = new Size(328, 28);
            TxtCargo.TabIndex = 56;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Navy;
            label15.Location = new Point(694, 401);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(65, 24);
            label15.TabIndex = 57;
            label15.Text = "Cargo:";
            // 
            // cboFacultades
            // 
            cboFacultades.Font = new Font("Candara Light", 10F);
            cboFacultades.FormattingEnabled = true;
            cboFacultades.Location = new Point(893, 474);
            cboFacultades.Name = "cboFacultades";
            cboFacultades.Size = new Size(328, 29);
            cboFacultades.TabIndex = 58;
            cboFacultades.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cboCarreras
            // 
            cboCarreras.Font = new Font("Candara Light", 10F);
            cboCarreras.FormattingEnabled = true;
            cboCarreras.Location = new Point(893, 537);
            cboCarreras.Name = "cboCarreras";
            cboCarreras.Size = new Size(328, 29);
            cboCarreras.TabIndex = 59;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.Navy;
            btnActivate.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActivate.ForeColor = Color.White;
            btnActivate.Location = new Point(1351, 347);
            btnActivate.Margin = new Padding(4, 5, 4, 5);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(162, 58);
            btnActivate.TabIndex = 60;
            btnActivate.Text = "Activar";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // cboPensums
            // 
            cboPensums.Font = new Font("Candara Light", 10F);
            cboPensums.FormattingEnabled = true;
            cboPensums.Location = new Point(893, 595);
            cboPensums.Name = "cboPensums";
            cboPensums.Size = new Size(328, 29);
            cboPensums.TabIndex = 62;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1551, 720);
            Controls.Add(cboPensums);
            Controls.Add(btnActivate);
            Controls.Add(cboCarreras);
            Controls.Add(cboFacultades);
            Controls.Add(TxtCargo);
            Controls.Add(label15);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(TxTSemestre);
            Controls.Add(label12);
            Controls.Add(TxTSalario);
            Controls.Add(label6);
            Controls.Add(TxTFechaVinculacion);
            Controls.Add(label11);
            Controls.Add(TxTGenero);
            Controls.Add(label5);
            Controls.Add(TxTFechaNacimiento);
            Controls.Add(label10);
            Controls.Add(TxTDireccion);
            Controls.Add(label9);
            Controls.Add(TxTTelefono);
            Controls.Add(label8);
            Controls.Add(TxTApellido);
            Controls.Add(label7);
            Controls.Add(TxtNumeroDocumento);
            Controls.Add(BtnConsultar);
            Controls.Add(BtnNewUser);
            Controls.Add(CBEstado);
            Controls.Add(TxtEmail);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(TxtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblTitulo);
            Controls.Add(TxtNombre);
            Controls.Add(TxtTipoDocumento);
            Controls.Add(LblPassword);
            Controls.Add(LblUsuario);
            Controls.Add(BtnIngresar);
            Controls.Add(BtnSalir);
            Font = new Font("Candara Light", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EAFIT - Administración de usuarios";
            Load += Usuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalir;
        private Button BtnIngresar;
        private TextBox TxtNombre;
        private TextBox TxtTipoDocumento;
        private Label LblPassword;
        private Label LblUsuario;
        private Label LblTitulo;
        private PictureBox pictureBox1;
        private TextBox TxTGenero;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtId;
        private ComboBox cboFacultades;
        private Button BtnUpdate;
        private Button BtnDelete;
        private TextBox TxtEmail;
        private ComboBox CBEstado;
        private Button BtnNewUser;
        private Button BtnConsultar;
        private TextBox TxtNumeroDocumento;
        private TextBox TxTApellido;
        private Label label7;
        private TextBox TxTTelefono;
        private Label label8;
        private TextBox TxTDireccion;
        private Label label9;
        private TextBox TxTFechaNacimiento;
        private Label label10;
        private Label label5;
        private TextBox TxTSalario;
        private Label label6;
        private TextBox TxTFechaVinculacion;
        private Label label11;
        private TextBox TxTSemestre;
        private Label label12;
        private TextBox TxTCarrera;
        private Label label13;
        private Label label14;
        private Label label1;
        private TextBox TxtCargo;
        private Label label15;
        private ComboBox cboCarreras;
        private Button btnActivate;
        private ComboBox cboPensums;
    }
}