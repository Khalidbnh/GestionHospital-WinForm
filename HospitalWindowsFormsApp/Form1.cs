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
    public partial class Form1 : Form
    {
        List<Persona> personaList = new List<Persona>();
        AddDoctorControl AddDoctorControl;
        AddPacienteControl AddPacienteControl;
        AddAdminControl AddAdminControl;
        private ListaMedicosControl listDoctorsControl;

        public Form1()
        {
            InitializeComponent();
            personaList = new List<Persona>();
        }

        private void btnAddMedico_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();
            AddDoctorControl = new AddDoctorControl(personaList);
            this.Controls.Add(AddDoctorControl);
        }

        private void btnAddPaciente_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();
            AddPacienteControl = new AddPacienteControl(personaList);
            this.Controls.Add(AddPacienteControl);
        }



        private void RemoveOtherControls()
        {
            if (AddDoctorControl != null)
            {
                this.Controls.Remove(AddDoctorControl);
                AddDoctorControl.Dispose();
                AddDoctorControl = null;
            }

            if (AddPacienteControl != null)
            {
                this.Controls.Remove(AddPacienteControl);
                AddPacienteControl.Dispose();
                AddPacienteControl = null;
            }

            if(AddAdminControl != null)
            {
                this.Controls.Remove(AddAdminControl);
                AddAdminControl.Dispose();
                AddAdminControl = null;
            }

            if(listDoctorsControl != null)
            {
                this.Controls.Remove(listDoctorsControl);
                listDoctorsControl.Dispose(); 
                listDoctorsControl = null;
            }

            
        }

        private void btnAddAdministrativo_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();
            AddAdminControl = new AddAdminControl(personaList); this.Controls.Add(AddAdminControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListaMedicos_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            listDoctorsControl = new ListaMedicosControl();

            this.Controls.Add(listDoctorsControl);

            foreach (Persona person in personaList)
            {
                if (person.GetType() == typeof(Medico))
                {
                    Medico doctor = (Medico)person;
                    ListViewItem item = new ListViewItem(doctor.Nombre);

                    item.SubItems.Add(doctor.Age.ToString());
                    item.SubItems.Add(doctor.Movil);
                    item.SubItems.Add(doctor.Especialidad);

                    listDoctorsControl.ListDoctorsView.Items.Add(item);
                }
            }
        }
    }
}
