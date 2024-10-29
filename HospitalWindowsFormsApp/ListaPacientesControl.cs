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
    public partial class ListaPacientesControl : UserControl
    {
        public ListView listaPacientesView { get {  return lstviewPacientes; } } 
        public ListaPacientesControl()
        {
            InitializeComponent();
        }

        private void ListaPacientesControl_Load(object sender, EventArgs e)
        {

        }

        private void lstviewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
