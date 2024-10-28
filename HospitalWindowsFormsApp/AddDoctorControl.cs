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
    public partial class AddDoctorControl : UserControl
    {
        private List<Persona> PersonasList;

        public AddDoctorControl(List<Persona> personasList)
        {
            InitializeComponent();
            this.PersonasList = personasList;
            
        }

        private void AddDoctorControl_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            string nombreM = txtNombreDoctor.Text;
            string movilM = txtMovilDoctor.Text;
            string especialidadM = txtEspecialidadDoctor.Text;
            int edadM;
            bool tryP;

            tryP = int.TryParse(txtEdadDoctor.Text, out edadM);

            if (!tryP)
            {
                MessageBox.Show("Medico Edad no valido", "Edad no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Medico medico = new Medico(nombreM, edadM, movilM, especialidadM);
                PersonasList.Add(medico);

                MessageBox.Show("Doctor creado con éxito!", "Doctor registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
