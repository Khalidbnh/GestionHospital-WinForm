using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWindowsFormsApp
{
    public partial class EditarAdminControl : UserControl
    {
        List<Persona> personaList;
        Administrativo AdministrativoToEdit;

        public EditarAdminControl(List<Persona> personaList, Administrativo administrativo)
        {
            InitializeComponent();
            this.personaList = personaList;
            this.AdministrativoToEdit = administrativo;
        }

        private void EditarAdminControl_Load(object sender, EventArgs e)
        {
            if(AdministrativoToEdit != null)
            {
                txtNombreA.Text = AdministrativoToEdit.Nombre;
                txtEdadA.Text = AdministrativoToEdit.Age.ToString();
                txtMovilA.Text = AdministrativoToEdit.Movil;
                txtPuestoA.Text = AdministrativoToEdit.Puesto;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out int edadA)) return;

            AdministrativoToEdit.Nombre = txtNombreA.Text;
            AdministrativoToEdit.Age = edadA;
            AdministrativoToEdit.Movil = txtMovilA.Text;
            AdministrativoToEdit.Puesto = txtPuestoA.Text;

            MessageBox.Show("Administratio Mofificado successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateInputs(out int edad)
        {
            edad = 0;

            // Validate fields
            if (string.IsNullOrWhiteSpace(txtNombreA.Text))
            {
                ShowError("Nombre es requerido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEdadA.Text))
            {
                ShowError("Edad es requerida.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMovilA.Text))
            {
                ShowError("Movil es requerido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPuestoA.Text))
            {
                ShowError("Puesto es requerido.");
                return false;
            }

            // Check if edad is a valid integer
            if (!int.TryParse(txtEdadA.Text, out edad))
            {
                ShowError("Edad debe ser un número válido.");
                return false;
            }

            return true;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
