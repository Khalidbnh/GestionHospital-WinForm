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
    public partial class ListaMedicosControl : UserControl
    {
        public ListView ListDoctorsView { get { return lstViewMedicos; } }
        public ListaMedicosControl()
        {
            InitializeComponent();
        }

        private void ListaMedicosControl_Load(object sender, EventArgs e)
        {

        }

        private void lstViewMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
