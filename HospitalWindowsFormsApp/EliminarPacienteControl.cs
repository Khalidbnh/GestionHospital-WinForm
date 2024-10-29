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
    public partial class EliminarPacienteControl : UserControl
    {
        private List<Persona> personaList;

        public EliminarPacienteControl(List<Persona> personaList)
        {
            InitializeComponent();
            this.personaList = personaList;

            foreach(Persona persona in personaList)
            {
                if(persona.GetType() == typeof(Paciente))
                {
                    cmbNombreP.Items.Add(persona.Nombre);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombrePacienteSelected = cmbNombreP.SelectedItem.ToString();

            if (string.IsNullOrEmpty(nombrePacienteSelected))
            {
                MessageBox.Show("Por favor seleccione un médico para eliminar", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Persona personaToRemove = personaList.FirstOrDefault(p => p.Nombre == nombrePacienteSelected && p is Paciente);

            if (personaToRemove != null)
            {
                personaList.Remove(personaToRemove);
                cmbNombreP.Items.Remove(nombrePacienteSelected);

                MessageBox.Show($"{nombrePacienteSelected} ha Eliminado.", "Medico Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
