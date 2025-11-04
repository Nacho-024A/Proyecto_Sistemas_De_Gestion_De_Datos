
namespace EAFIT_BaseDeDatos.UI
{
    partial class Horarios
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
            LblID = new Label();
            TxtIDHorario = new TextBox();
            LblCurso = new Label();
            TxtCursoID = new TextBox();
            LblSalon = new Label();
            TxtSalonID = new TextBox();
            LblDia = new Label();
            TxtDiaSemana = new TextBox();
            LblInicio = new Label();
            LblFin = new Label();
            DtpHoraInicio = new DateTimePicker();
            DtpHoraFin = new DateTimePicker();
            BtnIngresar = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnConsultar = new Button();
            BtnSalir = new Button();
            BtnNuevo = new Button();
            LblTitle = new Label();
            SuspendLayout();
            // 
            // LblID
            // 
            LblID.AutoSize = true;
            LblID.Location = new Point(61, 76);
            LblID.Name = "LblID";
            LblID.Size = new Size(64, 15);
            LblID.TabIndex = 0;
            LblID.Text = "ID Horario:";
            // 
            // TxtIDHorario
            // 
            TxtIDHorario.Location = new Point(271, 76);
            TxtIDHorario.Name = "TxtIDHorario";
            TxtIDHorario.Size = new Size(150, 23);
            TxtIDHorario.TabIndex = 1;
            // 
            // LblCurso
            // 
            LblCurso.AutoSize = true;
            LblCurso.Location = new Point(61, 116);
            LblCurso.Name = "LblCurso";
            LblCurso.Size = new Size(55, 15);
            LblCurso.TabIndex = 2;
            LblCurso.Text = "ID Curso:";
            // 
            // TxtCursoID
            // 
            TxtCursoID.Location = new Point(271, 116);
            TxtCursoID.Name = "TxtCursoID";
            TxtCursoID.Size = new Size(150, 23);
            TxtCursoID.TabIndex = 3;
            // 
            // LblSalon
            // 
            LblSalon.AutoSize = true;
            LblSalon.Location = new Point(61, 156);
            LblSalon.Name = "LblSalon";
            LblSalon.Size = new Size(53, 15);
            LblSalon.TabIndex = 4;
            LblSalon.Text = "ID Salón:";
            // 
            // TxtSalonID
            // 
            TxtSalonID.Location = new Point(271, 156);
            TxtSalonID.Name = "TxtSalonID";
            TxtSalonID.Size = new Size(150, 23);
            TxtSalonID.TabIndex = 5;
            // 
            // LblDia
            // 
            LblDia.AutoSize = true;
            LblDia.Location = new Point(61, 196);
            LblDia.Name = "LblDia";
            LblDia.Size = new Size(72, 15);
            LblDia.TabIndex = 6;
            LblDia.Text = "Día Semana:";
            // 
            // TxtDiaSemana
            // 
            TxtDiaSemana.Location = new Point(271, 196);
            TxtDiaSemana.Name = "TxtDiaSemana";
            TxtDiaSemana.Size = new Size(150, 23);
            TxtDiaSemana.TabIndex = 7;
            // 
            // LblInicio
            // 
            LblInicio.AutoSize = true;
            LblInicio.Location = new Point(61, 236);
            LblInicio.Name = "LblInicio";
            LblInicio.Size = new Size(68, 15);
            LblInicio.TabIndex = 8;
            LblInicio.Text = "Hora Inicio:";
            // 
            // LblFin
            // 
            LblFin.AutoSize = true;
            LblFin.Location = new Point(61, 276);
            LblFin.Name = "LblFin";
            LblFin.Size = new Size(55, 15);
            LblFin.TabIndex = 10;
            LblFin.Text = "Hora Fin:";
            // 
            // DtpHoraInicio
            // 
            DtpHoraInicio.Format = DateTimePickerFormat.Time;
            DtpHoraInicio.Location = new Point(271, 236);
            DtpHoraInicio.Name = "DtpHoraInicio";
            DtpHoraInicio.Size = new Size(150, 23);
            DtpHoraInicio.TabIndex = 11;
            DtpHoraInicio.Value = new DateTime(2025, 11, 4, 0, 0, 0, 0);
            // 
            // DtpHoraFin
            // 
            DtpHoraFin.Format = DateTimePickerFormat.Time;
            DtpHoraFin.Location = new Point(271, 276);
            DtpHoraFin.Name = "DtpHoraFin";
            DtpHoraFin.Size = new Size(150, 23);
            DtpHoraFin.TabIndex = 12;
            DtpHoraFin.Value = new DateTime(2025, 11, 4, 12, 0, 0, 0);
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = SystemColors.MenuHighlight;
            BtnIngresar.Font = new Font("Segoe UI", 13F);
            BtnIngresar.Location = new Point(93, 349);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(80, 40);
            BtnIngresar.TabIndex = 13;
            BtnIngresar.Text = "Insertar";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = SystemColors.MenuHighlight;
            BtnUpdate.Font = new Font("Segoe UI", 13F);
            BtnUpdate.Location = new Point(203, 349);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(100, 40);
            BtnUpdate.TabIndex = 14;
            BtnUpdate.Text = "Actualizar";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = SystemColors.MenuHighlight;
            BtnDelete.Font = new Font("Segoe UI", 13F);
            BtnDelete.Location = new Point(333, 349);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(100, 40);
            BtnDelete.TabIndex = 15;
            BtnDelete.Text = "Eliminar";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnConsultar
            // 
            BtnConsultar.BackColor = SystemColors.MenuHighlight;
            BtnConsultar.Font = new Font("Segoe UI", 13F);
            BtnConsultar.Location = new Point(463, 349);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(100, 40);
            BtnConsultar.TabIndex = 16;
            BtnConsultar.Text = "Consultar";
            BtnConsultar.UseVisualStyleBackColor = false;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = SystemColors.MenuHighlight;
            BtnSalir.Font = new Font("Segoe UI", 13F);
            BtnSalir.Location = new Point(542, 12);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 40);
            BtnSalir.TabIndex = 17;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = SystemColors.MenuHighlight;
            BtnNuevo.Font = new Font("Segoe UI", 13F);
            BtnNuevo.Location = new Point(483, 175);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(80, 40);
            BtnNuevo.TabIndex = 18;
            BtnNuevo.Text = "Limpiar";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.BackColor = SystemColors.Highlight;
            LblTitle.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = SystemColors.InactiveCaptionText;
            LblTitle.Location = new Point(61, 17);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(123, 26);
            LblTitle.TabIndex = 19;
            LblTitle.Text = "Horarios";
            LblTitle.Click += label1_Click;
            // 
            // Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(624, 396);
            Controls.Add(LblTitle);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnSalir);
            Controls.Add(BtnConsultar);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnIngresar);
            Controls.Add(DtpHoraFin);
            Controls.Add(DtpHoraInicio);
            Controls.Add(LblFin);
            Controls.Add(LblInicio);
            Controls.Add(TxtDiaSemana);
            Controls.Add(LblDia);
            Controls.Add(TxtSalonID);
            Controls.Add(LblSalon);
            Controls.Add(TxtCursoID);
            Controls.Add(LblCurso);
            Controls.Add(TxtIDHorario);
            Controls.Add(LblID);
            Name = "Horarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Horarios";
            Load += Horarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label LblID;
        private TextBox TxtIDHorario;
        private Label LblCurso;
        private TextBox TxtCursoID;
        private Label LblSalon;
        private TextBox TxtSalonID;
        private Label LblDia;
        private TextBox TxtDiaSemana;
        private Label LblInicio;
        private Label LblFin;
        private DateTimePicker DtpHoraInicio;
        private DateTimePicker DtpHoraFin;
        private Button BtnIngresar;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnConsultar;
        private Button BtnSalir;
        private Button BtnNuevo;
        private Label LblTitle;
    }
}