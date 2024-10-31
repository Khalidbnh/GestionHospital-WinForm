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
    public partial class EditarPacienteControl : UserControl
    {
        List<Persona> personas;
        Paciente pacienteToEdit;
        public EditarPacienteControl(List<Persona> personas, Paciente pacienteToEdit)
        {
            InitializeComponent();
            this.personas = personas;
            this.pacienteToEdit = pacienteToEdit;
        }

        private void EditarPacienteControl_Load(object sender, EventArgs e)
        {
            if (pacienteToEdit != null)
            {
                txtNombreP.Text = pacienteToEdit.Nombre;
                txtEdadP.Text = pacienteToEdit.Age.ToString();
                txtMovilP.Text = pacienteToEdit.Movil;
                txtEnfermedad.Text = pacienteToEdit.Enfermedad;
                txtAltura.Text = pacienteToEdit.Altura.ToString();
                txtPeso.Text = pacienteToEdit.Peso.ToString();
                foreach (Persona persona in personas)
                {
                    if (persona.GetType() == typeof(Medico))
                    {
                        cmbMedicoAsignado.Items.Add(persona.Nombre);
                    }
                }
            }
        }


        private void btnAddPaciente_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out int edadM)) return;

            
            pacienteToEdit.Nombre = txtNombreP.Text;
            pacienteToEdit.Age = edadM;
            pacienteToEdit.Movil = txtMovilP.Text;
            pacienteToEdit.Enfermedad = txtEnfermedad.Text;
            pacienteToEdit.Altura = double.Parse(txtAltura.Text);
            pacienteToEdit.Peso = double.Parse(txtPeso.Text);
            string nombreDoctor = cmbMedicoAsignado.SelectedItem.ToString();
            Medico assignedDoctor = personas.OfType<Medico>().FirstOrDefault(d => d.Nombre == nombreDoctor);
            pacienteToEdit.MedicoAsignados = assignedDoctor;

            MessageBox.Show("Paciente Mofificado successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private bool ValidateInputs(out int edad)
        {
            edad = 0;

            // Validate fields
            if (string.IsNullOrWhiteSpace(txtNombreP.Text))
            {
                ShowError("Nombre es requerido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEdadP.Text))
            {
                ShowError("Edad es requerida.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMovilP.Text))
            {
                ShowError("Movil es requerido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEnfermedad.Text))
            {
                ShowError("Enfermedad es requerida.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                ShowError("Altura requerida");
                return false;
            }
            if(string.IsNullOrEmpty(txtPeso.Text))
            {
                ShowError("Peso requerido");
                return false;
            }

            // Check if edad is a valid integer
            if (!int.TryParse(txtEdadP.Text, out edad))
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
