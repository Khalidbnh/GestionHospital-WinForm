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
    public partial class EditarMedicoControl : UserControl
    {
        List<Persona> personaList;
        Medico MedicoToEdit;
        public EditarMedicoControl(List<Persona> personaList, Medico medicoToEdit)
        {
            InitializeComponent();
            this.personaList = personaList;
            this.MedicoToEdit = medicoToEdit;
        }

        private void EditarMedicoControl_Load(object sender, EventArgs e)
        {

            if (MedicoToEdit != null)
            {
                txtNombreDoctor.Text = MedicoToEdit.Nombre;
                txtEdadDoctor.Text = MedicoToEdit.Age.ToString();
                txtMovilDoctor.Text = MedicoToEdit.Movil;
                txtEspecialidadDoctor.Text = MedicoToEdit.Especialidad;
            }

        }

        private void btnEditM_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out int edadM)) return;

            // Update the properties of the selected Medico
            MedicoToEdit.Nombre = txtNombreDoctor.Text;
            MedicoToEdit.Age = edadM;
            MedicoToEdit.Movil = txtMovilDoctor.Text;
            MedicoToEdit.Especialidad = txtEspecialidadDoctor.Text;

            MessageBox.Show("Medico Mofificado successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool ValidateInputs(out int edad)
        {
            edad = 0;

            // Validate fields
            if (string.IsNullOrWhiteSpace(txtNombreDoctor.Text))
            {
                ShowError("Nombre es requerido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEdadDoctor.Text))
            {
                ShowError("Edad es requerida.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMovilDoctor.Text))
            {
                ShowError("Movil es requerido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEspecialidadDoctor.Text))
            {
                ShowError("Especialidad es requerida.");
                return false;
            }

            // Check if edad is a valid integer
            if (!int.TryParse(txtEdadDoctor.Text, out edad))
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        
    }
}
