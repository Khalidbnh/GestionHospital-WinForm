using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalWindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<Persona> personaList = new List<Persona>();
        AddDoctorControl AddDoctorControl;
        AddPacienteControl AddPacienteControl;
        AddAdminControl AddAdminControl;
        ListaMedicosControl listDoctorsControl;
        ListaPacientesControl listaPacientesControl;
        ListaAdministrativosControl listaAdministrativosControl;
        EliminarMedicoControl EliminarMedicoControl;
        EliminarPacienteControl EliminarPacienteControl;
        EliminarAdministrativoControl EliminarAdministrativoControl;

        public Form1()
        {
            InitializeComponent();
            personaList = new List<Persona>();
            grpMedico.Visible   = false;
            grpPaciente.Visible = false;
            grpAdmin.Visible = false;
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

            if (listaPacientesControl != null)
            {
                this.Controls.Remove(listaPacientesControl);
                listaPacientesControl.Dispose();
                listaPacientesControl = null;
            }

            if (listaAdministrativosControl != null)
            {
                this.Controls.Remove(listaAdministrativosControl);
                listaAdministrativosControl.Dispose();
                listaAdministrativosControl = null;
            }

            if (EliminarMedicoControl != null)
            {
                this.Controls.Remove(EliminarMedicoControl);
                EliminarMedicoControl.Dispose();
                EliminarMedicoControl = null;
            }

            if (EliminarPacienteControl != null)
            {
                this.Controls.Remove(EliminarPacienteControl);
                EliminarPacienteControl.Dispose();
                EliminarPacienteControl = null;
            }

            if (EliminarAdministrativoControl != null)
            {
                this.Controls.Remove(EliminarAdministrativoControl);
                EliminarAdministrativoControl.Dispose();
                EliminarAdministrativoControl = null;
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

        private void btnListaPacientes_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            listaPacientesControl = new ListaPacientesControl();

            this.Controls.Add(listaPacientesControl);

            foreach(Persona person in personaList)
            {
                if(person.GetType() == typeof(Paciente))
                {
                    Paciente paciente = (Paciente)person;
                    ListViewItem item = new ListViewItem(paciente.Nombre);

                    item.SubItems.Add(paciente.Age.ToString());
                    item.SubItems.Add(paciente.Movil);
                    item.SubItems.Add(paciente.Enfermedad);
                    item.SubItems.Add(paciente.Peso.ToString());
                    item.SubItems.Add(paciente.Altura.ToString());
                    item.SubItems.Add(paciente.MedicoAsignados.Nombre);


                    listaPacientesControl.listaPacientesView.Items.Add(item);

                }
            }

        }

        private void btnListaAdmin_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            listaAdministrativosControl = new ListaAdministrativosControl();

            this.Controls.Add(listaAdministrativosControl);

            foreach (Persona persona in personaList)
            {
                if(persona.GetType() == typeof(Administrativo))
                {
                    Administrativo administrativo = (Administrativo)persona;
                    ListViewItem item = new ListViewItem(administrativo.Nombre);

                    item.SubItems.Add(administrativo.Age.ToString());
                    item.SubItems.Add(administrativo.Movil);
                    item.SubItems.Add(administrativo.Puesto);

                    listaAdministrativosControl.listaAdministrativos.Items.Add(item);
                }
            }
        }

        private void btnDeleteMedico_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            EliminarMedicoControl = new EliminarMedicoControl(personaList);

            

            this.Controls.Add(EliminarMedicoControl);
        }

        private void btnDeletePaciente_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            EliminarPacienteControl = new EliminarPacienteControl(personaList);
            this.Controls.Add(EliminarPacienteControl);
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();
            EliminarAdministrativoControl = new EliminarAdministrativoControl(personaList);
            this.Controls.Add(EliminarAdministrativoControl);
        }

        private void btnListaPersonas_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();
            grpPaciente.Visible = false;
            grpAdmin.Visible = false;
            grpMedico.Visible = true;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();
            grpMedico.Visible = false;
            grpAdmin.Visible = false;
            grpPaciente.Location = new Point(24, 69);
            grpPaciente.Visible = true;
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();
            grpMedico.Visible=false;
            grpPaciente.Visible=false ;
            grpAdmin.Location = new Point(24, 69);
            grpAdmin.Visible = true;
        }

        private void btnEditarMedico_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPaciente_Click(object sender, EventArgs e)
        {

        }

        private void EditAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteMDLista_Click(object sender, EventArgs e)
        {

            if (listDoctorsControl.ListDoctorsView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Get the selected item from ListView (first item if single selection)
            var selectedItem = listDoctorsControl.ListDoctorsView.SelectedItems[0];

            // Retrieve values from each column (assuming column order is: nombre, edad, movil, especialidad)
            string nombre = selectedItem.SubItems[0].Text;
            string edad = selectedItem.SubItems[1].Text;
            string movil = selectedItem.SubItems[2].Text;
            string especialidad = selectedItem.SubItems[3].Text;

            // Find the matching persona in personaList based on unique properties (e.g., movil)
            Persona personaToRemove = personaList.FirstOrDefault(p => p.Nombre == nombre && p is Medico);

            if (personaToRemove != null)
            {
                personaList.Remove(personaToRemove); // Remove from the data source
                listDoctorsControl.ListDoctorsView.Items.Remove(selectedItem); // Remove from ListView

                MessageBox.Show($"{nombre} deleted.", "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selected item not found in the data source.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePDLista_Click(object sender, EventArgs e)
        {
            if(listaPacientesControl.listaPacientesView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listaPacientesControl.listaPacientesView.SelectedItems[0];
            string nombre = selectedItem.SubItems[0].Text;
            


            Persona persona = personaList.FirstOrDefault(p=> p.Nombre == nombre && p is Paciente);
            if(persona != null)
            {
                personaList.Remove(persona);
                listaPacientesControl.listaPacientesView.Items.Remove(selectedItem);
                MessageBox.Show($"{nombre} deleted.", "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteADlista_Click(object sender, EventArgs e)
        {
            if (listaAdministrativosControl.listaAdministrativos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listaAdministrativosControl.listaAdministrativos.Items[0];
            string nombre = selectedItem.SubItems[0].Text;

            Persona persona = personaList.FirstOrDefault(p => p.Nombre == nombre && p is Administrativo);

            if (persona != null)
            {
                personaList.Remove(persona);
                listaAdministrativosControl.listaAdministrativos.Items.Remove(selectedItem);
                MessageBox.Show($"{nombre} deleted.", "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
