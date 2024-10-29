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
    public partial class ListaAdministrativosControl : UserControl
    {
        public ListView listaAdministrativos { get { return lstViewAdmins; } }
        public ListaAdministrativosControl()
        {
            InitializeComponent();
        }

        private void lstViewAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
