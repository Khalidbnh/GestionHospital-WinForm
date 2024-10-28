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
    public partial class AddPacienteControl : UserControl
    {
        private List<Persona> PersonasList;

        public AddPacienteControl(List<Persona> PersonasList)
        {
            InitializeComponent();
            this.PersonasList = PersonasList;
            foreach (Persona persona in PersonasList)
            {
                if (persona.GetType() == typeof(Medico))
                {
                    cmbMedicoAsignado.Items.Add(persona.Nombre);
                }
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            string nombreM = txtNombreP.Text;
            string movilM = txtMovilP.Text;
            string enfermedad = txtEnfermedad.Text;
            double peso = double.Parse(txtPeso.Text);
            int altura = int.Parse(txtAltura.Text);
            int edadP;
            bool tryP;


            tryP = int.TryParse(txtEdadP.Text, out edadP);

            if (string.IsNullOrEmpty(txtNombreP.Text))
            {
                MessageBox.Show("Nombre Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtEdadP.Text))
            {
                MessageBox.Show("Edad Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtMovilP.Text))
            {
                MessageBox.Show("Movil Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtEnfermedad.Text))
            {
                MessageBox.Show("Enfermedad Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtPeso.Text))
            {
                MessageBox.Show("Peso Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtAltura.Text))
            {
                MessageBox.Show("Altura Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbMedicoAsignado.SelectedItem == null)
            {
                MessageBox.Show("You must select at least one Medico from the list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          

            if (!tryP)
            {
                MessageBox.Show("Paciente Edad no valido", "Edad no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string nombreDoctor = cmbMedicoAsignado.SelectedItem.ToString();
                Medico assignedDoctor = PersonasList.OfType<Medico>().FirstOrDefault(d => d.Nombre == nombreDoctor);

                Paciente paciente = new Paciente(nombreM, edadP, movilM, enfermedad, peso, altura, assignedDoctor);
                PersonasList.Add(paciente);

                MessageBox.Show("Paciente creado con éxito!", "Paciente registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
