namespace EAFIT_BaseDeDatos.UI
{
    partial class Productos
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
            BtnSalir = new Button();
            SuspendLayout();
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Navy;
            BtnSalir.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(640, 376);
            BtnSalir.Margin = new Padding(4, 5, 4, 5);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(147, 60);
            BtnSalir.TabIndex = 12;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSalir);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSalir;
    }
}