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
    public partial class EliminarMedicoControl : UserControl
    {
        private List<Persona> PersonasList;
        public EliminarMedicoControl(List<Persona> PersonasList)
        {
            InitializeComponent();
            this.PersonasList = PersonasList;
            foreach (Persona persona in PersonasList)
            {
                if (persona.GetType() == typeof(Medico))
                {
                    cmbNombreM.Items.Add(persona.Nombre);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreMedicoSelected = cmbNombreM.SelectedItem.ToString();

            if(string.IsNullOrEmpty(nombreMedicoSelected) )
            {
                MessageBox.Show("Por favor seleccione un médico para eliminar", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Persona personaToRemove = PersonasList.FirstOrDefault(p=> p.Nombre == nombreMedicoSelected && p is Medico);

            if (personaToRemove != null)
            {
                PersonasList.Remove(personaToRemove);
                cmbNombreM.Items.Remove(nombreMedicoSelected);

                MessageBox.Show($"{nombreMedicoSelected} ha Eliminado.", "Medico Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           

        }
    }
}
