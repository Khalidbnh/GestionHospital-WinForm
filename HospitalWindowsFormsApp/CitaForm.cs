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
    public partial class CitaForm : Form
    {
        private List<Medico> MedicosList;
        private List<Paciente> PacientesList;
        private List<Cita> CitasList = new List<Cita>();

        public CitaForm(List<Medico> medicos, List<Paciente> pacientes)
        {
            InitializeComponent();
            MedicosList = medicos;
            PacientesList = pacientes;
            LoadDataGridViews();
        }

        private void CitaForm_Load(object sender, EventArgs e)
        {

        }


        private void LoadDataGridViews()
        {
            // Load Medicos into DataGridView
            dgvMedicos.DataSource = MedicosList;

            // Load Pacientes into DataGridView
            dgvPacientes.DataSource = PacientesList;
        }

        private void btnPedirCita_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count == 0 || dgvPacientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select both a Medico and a Paciente.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Medico selectedMedico = (Medico)dgvMedicos.SelectedRows[0].DataBoundItem;
            Paciente selectedPaciente = (Paciente)dgvPacientes.SelectedRows[0].DataBoundItem;
            DateTime selectedDate = datetimeCita.Value;

            Cita newCita = new Cita(selectedMedico, selectedPaciente, selectedDate);
            CitasList.Add(newCita);

            MessageBox.Show("Cita added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateCitasList();


        }

        private void UpdateCitasList()
        {
            // Display all Citas in a ListView or DataGridView, depending on your form design
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = CitasList;
        }
    }
}
