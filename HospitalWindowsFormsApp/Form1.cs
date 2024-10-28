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
        
        public Form1()
        {
            InitializeComponent();
            personaList = new List<Persona>();
        }

        private void btnAddMedico_Click(object sender, EventArgs e)
        {
            AddDoctorControl = new AddDoctorControl(personaList);
            this.Controls.Add(AddDoctorControl);
        }
    }
}
