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
    public partial class EliminarAdministrativoControl : UserControl
    {
        private List<Persona> PersonasList; 
        public EliminarAdministrativoControl(List<Persona> personas)
        {
            InitializeComponent();
            this.PersonasList = personas;

            foreach (Persona persona in PersonasList)
            {
                if(persona.GetType() == typeof(Administrativo))
                {
                    cmbNombreAdmin.Items.Add(persona.Nombre);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible= false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreAdminSelected = cmbNombreAdmin.SelectedItem.ToString();

            if(string.IsNullOrEmpty(nombreAdminSelected))
            {
                MessageBox.Show("Por favor seleccione un médico para eliminar", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Persona personaToRemove = PersonasList.FirstOrDefault(p=> p.Nombre == nombreAdminSelected && p is Administrativo);
            if(personaToRemove != null)
            {
                PersonasList.Remove(personaToRemove);
                cmbNombreAdmin.Items.Remove(nombreAdminSelected);
                MessageBox.Show($"{nombreAdminSelected} ha Eliminado.", "Medico Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
