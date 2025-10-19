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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBConfig).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Navy;
            LblTitulo.Location = new Point(403, 31);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(266, 58);
            LblTitulo.TabIndex = 13;
            LblTitulo.Text = "Aplicación Base De Datos\r\n           Menú Principal ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 14);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Navy;
            BtnSalir.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(728, 368);
            BtnSalir.Margin = new Padding(4, 5, 4, 5);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(147, 60);
            BtnSalir.TabIndex = 11;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // PBClientes
            // 
            PBClientes.Image = Properties.Resources.Users;
            PBClientes.Location = new Point(56, 157);
            PBClientes.Name = "PBClientes";
            PBClientes.Size = new Size(149, 137);
            PBClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            PBClientes.TabIndex = 14;
            PBClientes.TabStop = false;
            PBClientes.Click += PBUsuarios_Click;
            // 
            // PBProductos
            // 
            PBProductos.Image = Properties.Resources.Products;
            PBProductos.Location = new Point(281, 155);
            PBProductos.Name = "PBProductos";
            PBProductos.Size = new Size(149, 138);
            PBProductos.SizeMode = PictureBoxSizeMode.StretchImage;
            PBProductos.TabIndex = 15;
            PBProductos.TabStop = false;
            PBProductos.Click += PBProductos_Click;
            // 
            // PBCategorias
            // 
            PBCategorias.Image = Properties.Resources.categorias;
            PBCategorias.Location = new Point(472, 155);
            PBCategorias.Name = "PBCategorias";
            PBCategorias.Size = new Size(149, 138);
            PBCategorias.SizeMode = PictureBoxSizeMode.StretchImage;
            PBCategorias.TabIndex = 17;
            PBCategorias.TabStop = false;
            PBCategorias.Click += PBCategorias_Click;
            // 
            // PBConfig
            // 
            PBConfig.Image = Properties.Resources.Configuration;
            PBConfig.Location = new Point(662, 157);
            PBConfig.Name = "PBConfig";
            PBConfig.Size = new Size(140, 137);
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
            LLClientes.Location = new Point(24, 308);
            LLClientes.Name = "LLClientes";
            LLClientes.Size = new Size(201, 29);
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
            LLProductos.Location = new Point(300, 308);
            LLProductos.Name = "LLProductos";
            LLProductos.Size = new Size(116, 29);
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
            LLCategorias.Location = new Point(486, 308);
            LLCategorias.Name = "LLCategorias";
            LLCategorias.Size = new Size(120, 29);
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
            LLConfiguracion.Location = new Point(662, 308);
            LLConfiguracion.Name = "LLConfiguracion";
            LLConfiguracion.Size = new Size(152, 29);
            LLConfiguracion.TabIndex = 21;
            LLConfiguracion.TabStop = true;
            LLConfiguracion.Text = "Configuración";
            LLConfiguracion.Click += PBConfig_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(889, 450);
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
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EAFIT - Menu Principal logeo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBConfig).EndInit();
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
    }
}