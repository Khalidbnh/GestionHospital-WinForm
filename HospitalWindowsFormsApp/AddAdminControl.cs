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
    public partial class AddAdminControl : UserControl
    {
        private List<Persona> personaList;

        public AddAdminControl(List<Persona> personaList)
        {
            InitializeComponent();
            this.personaList = personaList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            string nombreA = txtNombreA.Text;
            string movilA = txtMovilA.Text;
            string puestoA = txtPuestoA.Text;
            int edadA;


            bool tryE;
            tryE = int.TryParse(txtEdadA.Text, out edadA);
            if (string.IsNullOrEmpty(txtNombreA.Text))
            {
                MessageBox.Show("Nombre Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtEdadA.Text))
            {
                MessageBox.Show("Edad Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtMovilA.Text))
            {
                MessageBox.Show("Movil Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtPuestoA.Text))
            {
                MessageBox.Show("Puesto Requerido", "Error msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!tryE)
            {
                MessageBox.Show("Paciente Edad no valido", "Edad no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Administrativo a = new Administrativo(nombreA,edadA, movilA, puestoA);
                personaList.Add(a);

                MessageBox.Show("Administrativo creado con éxito!", "Doctor registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
