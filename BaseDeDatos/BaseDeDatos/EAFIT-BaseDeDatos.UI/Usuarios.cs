using EAFIT_BaseDeDatos.Core.EAFIT_FACADE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAFIT_BaseDeDatos.UI
{
    public partial class Usuarios : Form
    {

        Form InstanciaPpal;
        bool Result = false;
        public Usuarios(Form ppal)
        {
            InitializeComponent();
            InstanciaPpal = ppal;
            CBClientType.SelectedIndex = CBState.SelectedIndex = 0;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            InstanciaPpal.Close();
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            TxtNameUser.Text = TxtUsuario.Text = TxtApellidos.Text = TxtEmail.Text = TxtPassword.Text = TxtPassword2.Text = string.Empty;
            CBClientType.SelectedIndex = CBState.SelectedIndex = 0;
            BtnUpdate.Enabled = BtnDelete.Enabled = false;
            BtnIngresar.Enabled = true;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            BtnIngresar.Enabled = false;
            BtnUpdate.Enabled = BtnDelete.Enabled = true;
            FacadeUsuarios InstSearch = new FacadeUsuarios();
            Dictionary<string, string> Result = new Dictionary<string, string>();
            Result = InstSearch.ValidarUsuario(TxtNameUser.Text);
            if (Result != null)
            {
                TxtUsuario.Text = Result.GetValueOrDefault("Name_User");
                TxtApellidos.Text = Result.GetValueOrDefault("LName_User");
                TxtEmail.Text = Result.GetValueOrDefault("Email");
                CBClientType.Text = Result.GetValueOrDefault("Client_Type");
                CBState.Text = Result.GetValueOrDefault("State_user");

            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            ExecuteUser(1);
            if (Result)
            {
                MessageBox.Show("Ingreso exitoso!!", "ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al ingresar el usuario, validar los datos enviados", "ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ExecuteUser(2);
            if (Result)
            {
                MessageBox.Show("Actualización exitosa!!", "Actualización de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al actualizar el usuario, validar los datos enviados", "Actualización de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FacadeUsuarios InstInactivar = new FacadeUsuarios();
            bool Result = InstInactivar.InactivarUsuario(TxtNameUser.Text);
            if (Result)
            {
                MessageBox.Show("Inactivación exitosa!!", "Inactivación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al Inactivar el usuario, validar los datos enviados", "Inactivación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        internal bool ExecuteUser(int Accion)
        {
            Result = false;
            if (string.IsNullOrEmpty(TxtUsuario.Text) || string.IsNullOrEmpty(TxtApellidos.Text) || string.IsNullOrEmpty(TxtEmail.Text)
                   || string.IsNullOrEmpty(TxtNameUser.Text) || string.IsNullOrEmpty(TxtPassword.Text) ||
                   CBClientType.Text == "--Seleccionar--" || CBState.Text == "--Seleccionar--" ||
                   (string.IsNullOrEmpty(TxtPassword.Text) != string.IsNullOrEmpty(TxtPassword2.Text)))
            {
                MessageBox.Show("Validar los datos ingresados, faltan datos o no son correctos" + Environment.NewLine + " Por favor validar " + Environment.NewLine +
                    " ● contraseñas --> Deben ser iguales " + Environment.NewLine + " ● Valores ingresados --> todos obligatorios" + Environment.NewLine + " ● Valores seleccionados --> diferente a 'Seleccionar'",
                    "Error al ingresar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Dictionary<string, string> ValuesInsert = new Dictionary<string, string>();
                ValuesInsert.Add("Name_User", TxtUsuario.Text);
                ValuesInsert.Add("LName_User", TxtApellidos.Text);
                ValuesInsert.Add("Email", TxtEmail.Text);
                ValuesInsert.Add("UserApps", TxtNameUser.Text);
                ValuesInsert.Add("Password", TxtPassword.Text);
                ValuesInsert.Add("Client_Type", CBClientType.Text.ToString().Trim());
                ValuesInsert.Add("State_user", CBState.Text.ToString().Trim());
                FacadeUsuarios InstInsertar = new FacadeUsuarios();
                if (Accion == 1)
                    Result = InstInsertar.InsertarUsuario(ValuesInsert);
                else if (Accion == 2)
                    Result = InstInsertar.ActualizarUsuario(ValuesInsert);

            }
            return Result;
        }


    }
}
