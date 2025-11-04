using EAFIT_BaseDeDatos.Core.EAFIT_FACADE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EAFIT_BaseDeDatos.UI
{
    public partial class Horarios : Form
    {
        Form InstanciaPpal;
        bool Result = false;

        public Horarios(Form ppal)
        {
            InitializeComponent();
            InstanciaPpal = ppal;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            InstanciaPpal.Close();
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            TxtIDHorario.Text = "";
            TxtCursoID.Text = "";
            TxtSalonID.Text = "";
            TxtDiaSemana.Text = "";
            DtpHoraInicio.Text = "";
            DtpHoraFin.Text = "";

            BtnIngresar.Enabled = true;
            BtnUpdate.Enabled = BtnDelete.Enabled = false;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIDHorario.Text))
            {
                MessageBox.Show("Debe ingresar un ID de horario para consultar.", "Consulta de Horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHorario;
            if (!int.TryParse(TxtIDHorario.Text, out idHorario))
            {
                MessageBox.Show("El ID del horario debe ser un número entero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BtnIngresar.Enabled = false;
            BtnUpdate.Enabled = BtnDelete.Enabled = true;

            FacadeHorarios InstSearch = new FacadeHorarios();
            Dictionary<string, string> Result = InstSearch.ConsultarHorario(idHorario);

            if (Result != null && Result.Count > 0)
            {
                TxtCursoID.Text = Result.GetValueOrDefault("curso_id_curso");
                TxtSalonID.Text = Result.GetValueOrDefault("salon_id_salon");
                TxtDiaSemana.Text = Result.GetValueOrDefault("dia_semana");
                DtpHoraInicio.Text = Result.GetValueOrDefault("hora_inicio");
                DtpHoraFin.Text = Result.GetValueOrDefault("hora_fin");
            }
            else
            {
                MessageBox.Show("No se encontró el horario especificado.", "Consulta de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            ExecuteHorario(1);
            if (Result)
            {
                MessageBox.Show("Horario insertado correctamente.", "Ingreso de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Error al insertar el horario. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ExecuteHorario(2);
            if (Result)
            {
                MessageBox.Show("Horario actualizado correctamente.", "Actualización de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Error al actualizar el horario. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIDHorario.Text))
            {
                MessageBox.Show("Debe ingresar el ID del horario a eliminar.", "Eliminación de Horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHorario;
            if (!int.TryParse(TxtIDHorario.Text, out idHorario))
            {
                MessageBox.Show("El ID del horario debe ser numérico.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FacadeHorarios InstEliminar = new FacadeHorarios();
            bool Result = InstEliminar.EliminarHorario(idHorario);

            if (Result)
            {
                MessageBox.Show("Horario eliminado correctamente.", "Eliminación de Horario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Error al eliminar el horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        internal bool ExecuteHorario(int Accion)
        {
            Result = false;

            if (string.IsNullOrEmpty(TxtCursoID.Text) ||
                string.IsNullOrEmpty(TxtSalonID.Text) ||
                string.IsNullOrEmpty(TxtDiaSemana.Text) ||
                string.IsNullOrEmpty(DtpHoraInicio.Text) ||
                string.IsNullOrEmpty(DtpHoraFin.Text))
            {
                MessageBox.Show("Debe completar todos los campos para continuar.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Dictionary<string, string> ValuesInsert = new Dictionary<string, string>();
            ValuesInsert.Add("id_horario", TxtIDHorario.Text);
            ValuesInsert.Add("curso_id_curso", TxtCursoID.Text);
            ValuesInsert.Add("salon_id_salon", TxtSalonID.Text);
            ValuesInsert.Add("dia_semana", TxtDiaSemana.Text);
            ValuesInsert.Add("hora_inicio", DtpHoraInicio.Text);
            ValuesInsert.Add("hora_fin", DtpHoraFin.Text);

            FacadeHorarios InstHorario = new FacadeHorarios();

            if (Accion == 1)
                Result = InstHorario.InsertarHorario(ValuesInsert);
            else if (Accion == 2)
                Result = InstHorario.ActualizarHorario(ValuesInsert);

            return Result;
        }

        private void Horarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
