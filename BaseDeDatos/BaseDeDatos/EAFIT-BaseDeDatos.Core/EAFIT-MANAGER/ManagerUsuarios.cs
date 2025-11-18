using EAFIT_BaseDeDatos.Core.EAFIT_BROKER;
using EAFIT_BaseDeDatos.Core.EAFIT_ENTITIES;
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

        // FLAG para controlar eventos en cascada
        private bool estaCargandoDatos = false;

        public Usuarios(Form ppal)
        {
            InitializeComponent();
            InstanciaPpal = ppal;
            CBEstado.SelectedIndex = 0;

            // Inicializar combos
            cboFacultades.Text = "--Seleccionar--";
            cboCarreras.Text = "--Seleccionar--";
            cboPensums.Text = "--Seleccionar--";

            CargarFacultades();
            // Suscribir eventos DESPUÉS de cargar
            cboFacultades.SelectedIndexChanged += cboFacultades_SelectedIndexChanged;
            cboCarreras.SelectedIndexChanged += cboCarreras_SelectedIndexChanged;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal FrmPpal = new MenuPrincipal(InstanciaPpal);
            FrmPpal.Show();
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            // Limpiar todos los TextBox existentes (según Usuarios.Designer.cs)
            TxtId.Text = TxtTipoDocumento.Text = TxtNumeroDocumento.Text =
            TxtNombre.Text = TxTApellido.Text = TxtEmail.Text =
            TxTTelefono.Text = TxTDireccion.Text = TxTFechaNacimiento.Text =
            TxTGenero.Text = TxTFechaVinculacion.Text = TxTSalario.Text =
            TxTSemestre.Text = TxtCargo.Text = string.Empty;

            CBEstado.SelectedIndex = 0;
            cboCarreras.Text = cboFacultades.Text = cboPensums.Text = "--Seleccionar--";
            BtnUpdate.Enabled = BtnDelete.Enabled = false;
            BtnIngresar.Enabled = true;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            BtnIngresar.Enabled = false;
            BtnUpdate.Enabled = BtnDelete.Enabled = true;

            FacadeUsuarios InstSearch = new FacadeUsuarios();
            Dictionary<string, string> Result = InstSearch.ValidarUsuario(TxtId.Text);

            if (Result != null)
            {
                // ⭐ ACTIVAR FLAG antes de cargar datos
                estaCargandoDatos = true;

                // === Campos de texto ===
                TxtId.Text = Result.GetValueOrDefault("Id");
                TxtTipoDocumento.Text = Result.GetValueOrDefault("Tipo_Documento");
                TxtNumeroDocumento.Text = Result.GetValueOrDefault("Numero_Documento");
                TxtNombre.Text = Result.GetValueOrDefault("Nombres");
                TxTApellido.Text = Result.GetValueOrDefault("Apellidos");
                TxtEmail.Text = Result.GetValueOrDefault("Email");
                TxTTelefono.Text = Result.GetValueOrDefault("Telefono");
                TxTDireccion.Text = Result.GetValueOrDefault("Direccion");
                TxTFechaNacimiento.Text = Result.GetValueOrDefault("Fecha_Nacimiento");
                TxTGenero.Text = Result.GetValueOrDefault("Genero");
                TxTFechaVinculacion.Text = Result.GetValueOrDefault("Fecha_Vinculacion");
                TxTSalario.Text = Result.GetValueOrDefault("Salario");
                TxTSemestre.Text = Result.GetValueOrDefault("Semestre");
                TxtCargo.Text = Result.GetValueOrDefault("Cargo");

                // === Estado ===
                string estado = Result.GetValueOrDefault("Nombre_Estado");
                if (estado == "Activo")
                    CBEstado.SelectedIndex = 1;
                else if (estado == "Inactivo")
                    CBEstado.SelectedIndex = 2;
                else
                    CBEstado.SelectedIndex = 0;

                // === Obtener nombres de Facultad, Carrera y Pensum ===
                string nombreFacultad = Result.GetValueOrDefault("Nombre_Facultad");
                string nombreCarrera = Result.GetValueOrDefault("Nombre_Carrera");
                string nombrePensum = Result.GetValueOrDefault("Nombre_Pensum");

                var facade = new FacadeUsuarios();

                // 1️⃣ Cargar TODAS las facultades
                var facultades = facade.ObtenerFacultades();
                cboFacultades.DataSource = facultades;
                cboFacultades.DisplayMember = "Value";
                cboFacultades.ValueMember = "Key";

                // 2️⃣ Buscar y seleccionar la facultad del usuario
                var facultadSeleccionada = facultades.FirstOrDefault(f => f.Value == nombreFacultad);
                if (!facultadSeleccionada.Equals(default(KeyValuePair<int, string>)))
                {
                    cboFacultades.SelectedValue = facultadSeleccionada.Key;

                    // 3️⃣ Cargar carreras de esa facultad
                    var carreras = facade.ObtenerCarreras(facultadSeleccionada.Key);
                    cboCarreras.DataSource = carreras;
                    cboCarreras.DisplayMember = "Value";
                    cboCarreras.ValueMember = "Key";

                    // 4️⃣ Buscar y seleccionar la carrera del usuario
                    var carreraSeleccionada = carreras.FirstOrDefault(c => c.Value == nombreCarrera);
                    if (!carreraSeleccionada.Equals(default(KeyValuePair<int, string>)))
                    {
                        cboCarreras.SelectedValue = carreraSeleccionada.Key;

                        // 5️⃣ Cargar pensums de esa carrera
                        var pensums = facade.ObtenerPensums(carreraSeleccionada.Key);
                        cboPensums.DataSource = pensums;
                        cboPensums.DisplayMember = "Value";
                        cboPensums.ValueMember = "Key";

                        // 6️⃣ Buscar y seleccionar el pensum del usuario
                        var pensumSeleccionado = pensums.FirstOrDefault(p => p.Value == nombrePensum);
                        if (!pensumSeleccionado.Equals(default(KeyValuePair<int, string>)))
                        {
                            cboPensums.SelectedValue = pensumSeleccionado.Key;
                        }
                    }
                }

                // ⭐ DESACTIVAR FLAG después de cargar todo
                estaCargandoDatos = false;

                MessageBox.Show("Usuario cargado correctamente", "Consulta exitosa",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Consultar usuario",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                BtnIngresar.Enabled = true;
                BtnUpdate.Enabled = BtnDelete.Enabled = false;
            }
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "")
            {
                ExecuteUser(1, out Dictionary<string, string> ValuesInsert);
                FacadeUsuarios facade = new FacadeUsuarios();
                var resultado = facade.InsertarUsuario(ValuesInsert);
                bool ok = resultado.Item1;
                string mensaje = resultado.Item2;

                if (ok)
                {
                    MessageBox.Show(
                        $"Se creó el usuario con el ID = {mensaje}",
                        "Usuario creado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(
                        $"Error al crear el usuario: {mensaje}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else {
                MessageBox.Show(
                "El campo ID debe estar vacío para crear un nuevo usuario.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                LimpiarFormulario();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            bool ok = ExecuteUser(2, out Dictionary<string, string> ValuesInsert);

            if (!ok)
                return;

            FacadeUsuarios f = new FacadeUsuarios();
            bool updated = f.ActualizarUsuario(ValuesInsert);

            if (updated)
            {
                MessageBox.Show("Actualización exitosa!!");
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("No se actualizó ningún registro. Verifique el ID.");
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (CBEstado.SelectedIndex == 2)
            {
                MessageBox.Show("El usuario ya se encuentra inactivo", "Inactivación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro de inactivar el usuario?", "Inactivación de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            FacadeUsuarios InstDelete = new FacadeUsuarios();
            Result = InstDelete.InactivarUsuario(TxtId.Text);
            if (Result)
            {
                MessageBox.Show("Inactivación exitosa!!", "Inactivación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al Inactivar el usuario, validar los datos enviados", "Inactivación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (CBEstado.SelectedIndex == 1)
            {
                MessageBox.Show("El usuario ya se encuentra activo", "Activacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("¿Está seguro de activar el usuario?", "Activacion de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            FacadeUsuarios InstActivate = new FacadeUsuarios();
            Result = InstActivate.ActivarUsuario(TxtId.Text);
            if (Result)
            {
                MessageBox.Show("Activacion exitosa!!", "Activacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al Activar el usuario, validar los datos enviados", "Activacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        internal bool ExecuteUser(int Accion, out Dictionary<string, string> ValuesInsert)
        {
            ValuesInsert = new Dictionary<string, string>();
            // Validación mínima de campos obligatorios (ajuste según reglas de negocio)
            if (string.IsNullOrEmpty(TxtNumeroDocumento.Text) ||
                string.IsNullOrEmpty(TxtTipoDocumento.Text) ||
                string.IsNullOrEmpty(TxtNombre.Text) ||
                string.IsNullOrEmpty(TxTApellido.Text) ||
                string.IsNullOrEmpty(TxtEmail.Text) ||
                CBEstado.Text == "--Seleccionar--" ||
                cboCarreras.Text == "--Seleccionar--" ||
                cboFacultades.Text == "--Seleccionar--" ||
                cboPensums.Text == "--Seleccionar--")   
            {
                MessageBox.Show("Validar los datos ingresados, faltan datos o no son correctos" + Environment.NewLine + " Por favor validar " + Environment.NewLine +
                    " ● Campos obligatorios --> Documento, Nombre, Apellido, Correo" + Environment.NewLine + " ● Valores seleccionados --> diferente a 'Seleccionar'",
                    "Error al ingresar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Accion == 2 && string.IsNullOrWhiteSpace(TxtId.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario antes de actualizar.");
                return false;
            }

            string fechaNacimiento = ConvertirFechaAFormatoBD(TxTFechaNacimiento.Text, "Fecha de Nacimiento");
            if (fechaNacimiento == null) return false;

            string fechaVinculacion = ConvertirFechaAFormatoBD(TxTFechaVinculacion.Text, "Fecha de Vinculación");
            if (fechaVinculacion == null) return false;

            ValuesInsert.Add("Id", TxtId.Text.Trim());
            ValuesInsert.Add("Tipo_Documento", TxtTipoDocumento.Text.Trim());
            ValuesInsert.Add("Numero_Documento", TxtNumeroDocumento.Text.Trim());
            ValuesInsert.Add("Nombres", TxtNombre.Text.Trim());
            ValuesInsert.Add("Apellidos", TxTApellido.Text.Trim());
            ValuesInsert.Add("Email", TxtEmail.Text.Trim());
            ValuesInsert.Add("Telefono", TxTTelefono.Text.Trim());
            ValuesInsert.Add("Direccion", TxTDireccion.Text.Trim());
            ValuesInsert.Add("Fecha_Nacimiento", fechaNacimiento);
            ValuesInsert.Add("Genero", TxTGenero.Text.Trim());
            ValuesInsert.Add("Fecha_Vinculacion", fechaVinculacion);
            ValuesInsert.Add("Cargo", TxtCargo.Text.Trim());
            ValuesInsert.Add("Salario", TxTSalario.Text.Trim());
            ValuesInsert.Add("Semestre", TxTSemestre.Text.Trim());
            ValuesInsert.Add("Carrera_Id", cboCarreras.SelectedValue.ToString());
            ValuesInsert.Add("Pensum_Id", cboPensums.SelectedValue.ToString());
            if (CBEstado.SelectedIndex == 1)
            {
                ValuesInsert.Add("Estado", "1");
            }
            else
            {
                ValuesInsert.Add("Estado", "2");
            }
            return true;
        }

        private void CargarFacultades()
        {
            var facade = new FacadeUsuarios();
            var facultades = facade.ObtenerFacultades();

            estaCargandoDatos = true;
            cboFacultades.DataSource = facultades;
            cboFacultades.DisplayMember = "Value";
            cboFacultades.ValueMember = "Key";
            cboFacultades.SelectedIndex = -1;
            cboFacultades.Text = "--Seleccionar--";

            cboCarreras.DataSource = null;
            cboCarreras.Text = "--Seleccionar--";

            cboPensums.DataSource = null;
            cboPensums.Text = "--Seleccionar--";

            estaCargandoDatos = false;
        }

        private void cboFacultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ⭐ NO ejecutar si estamos cargando datos programáticamente
            if (estaCargandoDatos) return;

            // Limpiar combos dependientes
            cboCarreras.DataSource = null;
            cboCarreras.Text = "--Seleccionar--";

            cboPensums.DataSource = null;
            cboPensums.Text = "--Seleccionar--";

            if (cboFacultades.SelectedItem is KeyValuePair<int, string> seleccion)
            {
                var facade = new FacadeUsuarios();
                var carreras = facade.ObtenerCarreras(seleccion.Key);

                estaCargandoDatos = true;
                cboCarreras.DataSource = carreras;
                cboCarreras.DisplayMember = "Value";
                cboCarreras.ValueMember = "Key";
                cboCarreras.SelectedIndex = -1;
                cboCarreras.Text = "--Seleccionar--";
                estaCargandoDatos = false;
            }
        }

        private void cboCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ⭐ NO ejecutar si estamos cargando datos programáticamente
            if (estaCargandoDatos) return;

            // Limpiar pensums
            cboPensums.DataSource = null;
            cboCarreras.Text = "--Seleccionar--";

            if (cboCarreras.SelectedItem is KeyValuePair<int, string> seleccion)
            {
                var facade = new FacadeUsuarios();
                var pensums = facade.ObtenerPensums(seleccion.Key); // Necesitas crear este método

                estaCargandoDatos = true;
                cboPensums.DataSource = pensums;
                cboPensums.DisplayMember = "Value";
                cboPensums.ValueMember = "Key";
                cboPensums.SelectedIndex = -1;
                cboPensums.Text = "--Seleccionar--";
                estaCargandoDatos = false;
            }
        }

        private string ConvertirFechaAFormatoBD(string fechaTexto, string nombreCampo)
        {
            if (DateTime.TryParse(fechaTexto, out DateTime fecha))
            {
                return fecha.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show(
                    $"El formato de {nombreCampo} no es válido: '{fechaTexto}'" + Environment.NewLine +
                    "Use formatos como: dd/MM/yyyy, yyyy-MM-dd, dd-MM-yyyy",
                    "Error en fecha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return null;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtNameUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
