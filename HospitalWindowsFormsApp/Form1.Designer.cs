namespace HospitalWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddMedico = new System.Windows.Forms.Button();
            this.btnAddPaciente = new System.Windows.Forms.Button();
            this.btnAddAdministrativo = new System.Windows.Forms.Button();
            this.btnListaMedicos = new System.Windows.Forms.Button();
            this.btnListaPacientes = new System.Windows.Forms.Button();
            this.btnListaAdmin = new System.Windows.Forms.Button();
            this.btnListaPersonas = new System.Windows.Forms.Button();
            this.btnDeleteMedico = new System.Windows.Forms.Button();
            this.btnDeletePaciente = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMedico
            // 
            this.btnAddMedico.Location = new System.Drawing.Point(22, 29);
            this.btnAddMedico.Name = "btnAddMedico";
            this.btnAddMedico.Size = new System.Drawing.Size(223, 51);
            this.btnAddMedico.TabIndex = 0;
            this.btnAddMedico.Text = "Añadir Medico";
            this.btnAddMedico.UseVisualStyleBackColor = true;
            this.btnAddMedico.Click += new System.EventHandler(this.btnAddMedico_Click);
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.Location = new System.Drawing.Point(289, 29);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(223, 51);
            this.btnAddPaciente.TabIndex = 0;
            this.btnAddPaciente.Text = "Añadir Paciente";
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            this.btnAddPaciente.Click += new System.EventHandler(this.btnAddPaciente_Click);
            // 
            // btnAddAdministrativo
            // 
            this.btnAddAdministrativo.Location = new System.Drawing.Point(556, 29);
            this.btnAddAdministrativo.Name = "btnAddAdministrativo";
            this.btnAddAdministrativo.Size = new System.Drawing.Size(223, 51);
            this.btnAddAdministrativo.TabIndex = 0;
            this.btnAddAdministrativo.Text = "Añadir Administrativo";
            this.btnAddAdministrativo.UseVisualStyleBackColor = true;
            this.btnAddAdministrativo.Click += new System.EventHandler(this.btnAddAdministrativo_Click);
            // 
            // btnListaMedicos
            // 
            this.btnListaMedicos.Location = new System.Drawing.Point(22, 104);
            this.btnListaMedicos.Name = "btnListaMedicos";
            this.btnListaMedicos.Size = new System.Drawing.Size(172, 51);
            this.btnListaMedicos.TabIndex = 0;
            this.btnListaMedicos.Text = "Lista de Medicos";
            this.btnListaMedicos.UseVisualStyleBackColor = true;
            this.btnListaMedicos.Click += new System.EventHandler(this.btnListaMedicos_Click);
            // 
            // btnListaPacientes
            // 
            this.btnListaPacientes.Location = new System.Drawing.Point(214, 104);
            this.btnListaPacientes.Name = "btnListaPacientes";
            this.btnListaPacientes.Size = new System.Drawing.Size(172, 51);
            this.btnListaPacientes.TabIndex = 0;
            this.btnListaPacientes.Text = "Lista de Pacientes";
            this.btnListaPacientes.UseVisualStyleBackColor = true;
            this.btnListaPacientes.Click += new System.EventHandler(this.btnListaPacientes_Click);
            // 
            // btnListaAdmin
            // 
            this.btnListaAdmin.Location = new System.Drawing.Point(410, 104);
            this.btnListaAdmin.Name = "btnListaAdmin";
            this.btnListaAdmin.Size = new System.Drawing.Size(172, 51);
            this.btnListaAdmin.TabIndex = 0;
            this.btnListaAdmin.Text = "Lista de Administrativos";
            this.btnListaAdmin.UseVisualStyleBackColor = true;
            // 
            // btnListaPersonas
            // 
            this.btnListaPersonas.Location = new System.Drawing.Point(607, 104);
            this.btnListaPersonas.Name = "btnListaPersonas";
            this.btnListaPersonas.Size = new System.Drawing.Size(172, 51);
            this.btnListaPersonas.TabIndex = 0;
            this.btnListaPersonas.Text = "Lista de Personas de hospital";
            this.btnListaPersonas.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMedico
            // 
            this.btnDeleteMedico.Location = new System.Drawing.Point(22, 181);
            this.btnDeleteMedico.Name = "btnDeleteMedico";
            this.btnDeleteMedico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteMedico.Size = new System.Drawing.Size(223, 51);
            this.btnDeleteMedico.TabIndex = 0;
            this.btnDeleteMedico.Text = "Eliminar Medico by ID";
            this.btnDeleteMedico.UseVisualStyleBackColor = true;
            // 
            // btnDeletePaciente
            // 
            this.btnDeletePaciente.Location = new System.Drawing.Point(289, 181);
            this.btnDeletePaciente.Name = "btnDeletePaciente";
            this.btnDeletePaciente.Size = new System.Drawing.Size(223, 51);
            this.btnDeletePaciente.TabIndex = 0;
            this.btnDeletePaciente.Text = "Eliminar Paciente by ID";
            this.btnDeletePaciente.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(556, 181);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(223, 51);
            this.btnDeleteAdmin.TabIndex = 0;
            this.btnDeleteAdmin.Text = "Eliminar Administrativos by ID";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 677);
            this.Controls.Add(this.btnAddAdministrativo);
            this.Controls.Add(this.btnAddPaciente);
            this.Controls.Add(this.btnListaPersonas);
            this.Controls.Add(this.btnListaAdmin);
            this.Controls.Add(this.btnListaPacientes);
            this.Controls.Add(this.btnListaMedicos);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Controls.Add(this.btnDeletePaciente);
            this.Controls.Add(this.btnDeleteMedico);
            this.Controls.Add(this.btnAddMedico);
            this.Name = "Form1";
            this.Text = "Gestion Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMedico;
        private System.Windows.Forms.Button btnAddPaciente;
        private System.Windows.Forms.Button btnAddAdministrativo;
        private System.Windows.Forms.Button btnListaMedicos;
        private System.Windows.Forms.Button btnListaPacientes;
        private System.Windows.Forms.Button btnListaAdmin;
        private System.Windows.Forms.Button btnListaPersonas;
        private System.Windows.Forms.Button btnDeleteMedico;
        private System.Windows.Forms.Button btnDeletePaciente;
        private System.Windows.Forms.Button btnDeleteAdmin;
    }
}

