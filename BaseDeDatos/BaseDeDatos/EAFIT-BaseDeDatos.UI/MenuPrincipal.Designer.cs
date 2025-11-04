namespace EAFIT_BaseDeDatos.UI
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            LblTitulo = new Label();
            pictureBox1 = new PictureBox();
            BtnSalir = new Button();
            PBClientes = new PictureBox();
            PBProductos = new PictureBox();
            PBCategorias = new PictureBox();
            PBConfig = new PictureBox();
            LLClientes = new LinkLabel();
            LLProductos = new LinkLabel();
            LLCategorias = new LinkLabel();
            LLConfiguracion = new LinkLabel();
            LLHorarios = new LinkLabel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Navy;
            LblTitulo.Location = new Point(282, 19);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(177, 38);
            LblTitulo.TabIndex = 13;
            LblTitulo.Text = "Aplicación Base De Datos\r\n           Menú Principal ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Navy;
            BtnSalir.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(572, 303);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(103, 36);
            BtnSalir.TabIndex = 11;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // PBClientes
            // 
            PBClientes.Image = Properties.Resources.Users;
            PBClientes.Location = new Point(39, 94);
            PBClientes.Margin = new Padding(2);
            PBClientes.Name = "PBClientes";
            PBClientes.Size = new Size(104, 82);
            PBClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            PBClientes.TabIndex = 14;
            PBClientes.TabStop = false;
            PBClientes.Click += PBUsuarios_Click;
            // 
            // PBProductos
            // 
            PBProductos.Image = Properties.Resources.Products;
            PBProductos.Location = new Point(197, 93);
            PBProductos.Margin = new Padding(2);
            PBProductos.Name = "PBProductos";
            PBProductos.Size = new Size(104, 83);
            PBProductos.SizeMode = PictureBoxSizeMode.StretchImage;
            PBProductos.TabIndex = 15;
            PBProductos.TabStop = false;
            PBProductos.Click += PBProductos_Click;
            // 
            // PBCategorias
            // 
            PBCategorias.Image = Properties.Resources.categorias;
            PBCategorias.Location = new Point(330, 93);
            PBCategorias.Margin = new Padding(2);
            PBCategorias.Name = "PBCategorias";
            PBCategorias.Size = new Size(104, 83);
            PBCategorias.SizeMode = PictureBoxSizeMode.StretchImage;
            PBCategorias.TabIndex = 17;
            PBCategorias.TabStop = false;
            PBCategorias.Click += PBCategorias_Click;
            // 
            // PBConfig
            // 
            PBConfig.Image = Properties.Resources.Configuration;
            PBConfig.Location = new Point(463, 94);
            PBConfig.Margin = new Padding(2);
            PBConfig.Name = "PBConfig";
            PBConfig.Size = new Size(98, 82);
            PBConfig.SizeMode = PictureBoxSizeMode.StretchImage;
            PBConfig.TabIndex = 16;
            PBConfig.TabStop = false;
            PBConfig.Click += PBConfig_Click;
            // 
            // LLClientes
            // 
            LLClientes.AutoSize = true;
            LLClientes.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LLClientes.LinkBehavior = LinkBehavior.NeverUnderline;
            LLClientes.LinkColor = Color.Black;
            LLClientes.Location = new Point(17, 185);
            LLClientes.Margin = new Padding(2, 0, 2, 0);
            LLClientes.Name = "LLClientes";
            LLClientes.Size = new Size(134, 19);
            LLClientes.TabIndex = 18;
            LLClientes.TabStop = true;
            LLClientes.Text = "Clientes y Usuarios";
            LLClientes.Click += PBUsuarios_Click;
            // 
            // LLProductos
            // 
            LLProductos.AutoSize = true;
            LLProductos.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LLProductos.LinkBehavior = LinkBehavior.NeverUnderline;
            LLProductos.LinkColor = Color.Black;
            LLProductos.Location = new Point(210, 185);
            LLProductos.Margin = new Padding(2, 0, 2, 0);
            LLProductos.Name = "LLProductos";
            LLProductos.Size = new Size(79, 19);
            LLProductos.TabIndex = 19;
            LLProductos.TabStop = true;
            LLProductos.Text = "Productos";
            LLProductos.Click += PBProductos_Click;
            // 
            // LLCategorias
            // 
            LLCategorias.AutoSize = true;
            LLCategorias.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LLCategorias.LinkBehavior = LinkBehavior.NeverUnderline;
            LLCategorias.LinkColor = Color.Black;
            LLCategorias.Location = new Point(340, 185);
            LLCategorias.Margin = new Padding(2, 0, 2, 0);
            LLCategorias.Name = "LLCategorias";
            LLCategorias.Size = new Size(80, 19);
            LLCategorias.TabIndex = 20;
            LLCategorias.TabStop = true;
            LLCategorias.Text = "Categorias";
            LLCategorias.Click += PBCategorias_Click;
            // 
            // LLConfiguracion
            // 
            LLConfiguracion.AutoSize = true;
            LLConfiguracion.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LLConfiguracion.LinkBehavior = LinkBehavior.NeverUnderline;
            LLConfiguracion.LinkColor = Color.Black;
            LLConfiguracion.Location = new Point(463, 185);
            LLConfiguracion.Margin = new Padding(2, 0, 2, 0);
            LLConfiguracion.Name = "LLConfiguracion";
            LLConfiguracion.Size = new Size(102, 19);
            LLConfiguracion.TabIndex = 21;
            LLConfiguracion.TabStop = true;
            LLConfiguracion.Text = "Configuración";
            LLConfiguracion.Click += PBConfig_Click;
            // 
            // LLHorarios
            // 
            LLHorarios.AutoSize = true;
            LLHorarios.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LLHorarios.LinkBehavior = LinkBehavior.NeverUnderline;
            LLHorarios.LinkColor = Color.Black;
            LLHorarios.Location = new Point(52, 327);
            LLHorarios.Margin = new Padding(2, 0, 2, 0);
            LLHorarios.Name = "LLHorarios";
            LLHorarios.Size = new Size(65, 19);
            LLHorarios.TabIndex = 23;
            LLHorarios.TabStop = true;
            LLHorarios.Text = "Horarios";
            LLHorarios.Click += PBHorarios_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(39, 235);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += PBHorarios_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(732, 405);
            Controls.Add(LLHorarios);
            Controls.Add(pictureBox2);
            Controls.Add(LLConfiguracion);
            Controls.Add(LLCategorias);
            Controls.Add(LLProductos);
            Controls.Add(LLClientes);
            Controls.Add(PBCategorias);
            Controls.Add(PBConfig);
            Controls.Add(PBProductos);
            Controls.Add(PBClientes);
            Controls.Add(LblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EAFIT - Menu Principal logeo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private PictureBox pictureBox1;
        private Button BtnSalir;
        private PictureBox PBClientes;
        private PictureBox PBProductos;
        private PictureBox PBCategorias;
        private PictureBox PBConfig;
        private LinkLabel LLClientes;
        private LinkLabel LLProductos;
        private LinkLabel LLCategorias;
        private LinkLabel LLConfiguracion;
        private LinkLabel LLHorarios;
        private PictureBox pictureBox2;
    }
}