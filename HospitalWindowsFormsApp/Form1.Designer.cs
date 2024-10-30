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
            this.btnDeleteMedico = new System.Windows.Forms.Button();
            this.btnDeletePaciente = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.grpMedico = new System.Windows.Forms.GroupBox();
            this.btnEditarMedico = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarAdmin = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.grpMedico.SuspendLayout();
            this.grpPaciente.SuspendLayout();
            this.grpAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMedico
            // 
            this.btnAddMedico.Location = new System.Drawing.Point(228, 21);
            this.btnAddMedico.Name = "btnAddMedico";
            this.btnAddMedico.Size = new System.Drawing.Size(162, 51);
            this.btnAddMedico.TabIndex = 0;
            this.btnAddMedico.Text = "Añadir Medico";
            this.btnAddMedico.UseVisualStyleBackColor = true;
            this.btnAddMedico.Click += new System.EventHandler(this.btnAddMedico_Click);
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.Location = new System.Drawing.Point(228, 16);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(162, 51);
            this.btnAddPaciente.TabIndex = 0;
            this.btnAddPaciente.Text = "Añadir Paciente";
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            this.btnAddPaciente.Click += new System.EventHandler(this.btnAddPaciente_Click);
            // 
            // btnAddAdministrativo
            // 
            this.btnAddAdministrativo.Location = new System.Drawing.Point(228, 21);
            this.btnAddAdministrativo.Name = "btnAddAdministrativo";
            this.btnAddAdministrativo.Size = new System.Drawing.Size(162, 51);
            this.btnAddAdministrativo.TabIndex = 0;
            this.btnAddAdministrativo.Text = "Añadir Administrativo";
            this.btnAddAdministrativo.UseVisualStyleBackColor = true;
            this.btnAddAdministrativo.Click += new System.EventHandler(this.btnAddAdministrativo_Click);
            // 
            // btnListaMedicos
            // 
            this.btnListaMedicos.Location = new System.Drawing.Point(6, 21);
            this.btnListaMedicos.Name = "btnListaMedicos";
            this.btnListaMedicos.Size = new System.Drawing.Size(186, 51);
            this.btnListaMedicos.TabIndex = 0;
            this.btnListaMedicos.Text = "Lista de Medicos";
            this.btnListaMedicos.UseVisualStyleBackColor = true;
            this.btnListaMedicos.Click += new System.EventHandler(this.btnListaMedicos_Click);
            // 
            // btnListaPacientes
            // 
            this.btnListaPacientes.Location = new System.Drawing.Point(6, 21);
            this.btnListaPacientes.Name = "btnListaPacientes";
            this.btnListaPacientes.Size = new System.Drawing.Size(186, 46);
            this.btnListaPacientes.TabIndex = 0;
            this.btnListaPacientes.Text = "Lista de Pacientes";
            this.btnListaPacientes.UseVisualStyleBackColor = true;
            this.btnListaPacientes.Click += new System.EventHandler(this.btnListaPacientes_Click);
            // 
            // btnListaAdmin
            // 
            this.btnListaAdmin.Location = new System.Drawing.Point(6, 21);
            this.btnListaAdmin.Name = "btnListaAdmin";
            this.btnListaAdmin.Size = new System.Drawing.Size(186, 51);
            this.btnListaAdmin.TabIndex = 0;
            this.btnListaAdmin.Text = "Lista de Administrativos";
            this.btnListaAdmin.UseVisualStyleBackColor = true;
            this.btnListaAdmin.Click += new System.EventHandler(this.btnListaAdmin_Click);
            // 
            // btnDeleteMedico
            // 
            this.btnDeleteMedico.Location = new System.Drawing.Point(583, 21);
            this.btnDeleteMedico.Name = "btnDeleteMedico";
            this.btnDeleteMedico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteMedico.Size = new System.Drawing.Size(174, 51);
            this.btnDeleteMedico.TabIndex = 0;
            this.btnDeleteMedico.Text = "Eliminar Medico";
            this.btnDeleteMedico.UseVisualStyleBackColor = true;
            this.btnDeleteMedico.Click += new System.EventHandler(this.btnDeleteMedico_Click);
            // 
            // btnDeletePaciente
            // 
            this.btnDeletePaciente.Location = new System.Drawing.Point(583, 16);
            this.btnDeletePaciente.Name = "btnDeletePaciente";
            this.btnDeletePaciente.Size = new System.Drawing.Size(174, 51);
            this.btnDeletePaciente.TabIndex = 0;
            this.btnDeletePaciente.Text = "Eliminar Paciente";
            this.btnDeletePaciente.UseVisualStyleBackColor = true;
            this.btnDeletePaciente.Click += new System.EventHandler(this.btnDeletePaciente_Click);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(583, 21);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(174, 51);
            this.btnDeleteAdmin.TabIndex = 0;
            this.btnDeleteAdmin.Text = "Eliminar Administrativo";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // grpMedico
            // 
            this.grpMedico.Controls.Add(this.btnAddMedico);
            this.grpMedico.Controls.Add(this.btnEditarMedico);
            this.grpMedico.Controls.Add(this.btnDeleteMedico);
            this.grpMedico.Controls.Add(this.btnListaMedicos);
            this.grpMedico.Location = new System.Drawing.Point(24, 69);
            this.grpMedico.Name = "grpMedico";
            this.grpMedico.Size = new System.Drawing.Size(757, 92);
            this.grpMedico.TabIndex = 1;
            this.grpMedico.TabStop = false;
            this.grpMedico.Text = "grpMedico";
            // 
            // btnEditarMedico
            // 
            this.btnEditarMedico.Location = new System.Drawing.Point(396, 21);
            this.btnEditarMedico.Name = "btnEditarMedico";
            this.btnEditarMedico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditarMedico.Size = new System.Drawing.Size(181, 51);
            this.btnEditarMedico.TabIndex = 0;
            this.btnEditarMedico.Text = "Editar Medico";
            this.btnEditarMedico.UseVisualStyleBackColor = true;
            this.btnEditarMedico.Click += new System.EventHandler(this.btnDeleteMedico_Click);
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Location = new System.Drawing.Point(396, 16);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditarPaciente.Size = new System.Drawing.Size(181, 51);
            this.btnEditarPaciente.TabIndex = 0;
            this.btnEditarPaciente.Text = "Editar Paciente";
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnDeleteMedico_Click);
            // 
            // btnEliminarAdmin
            // 
            this.btnEliminarAdmin.Location = new System.Drawing.Point(396, 21);
            this.btnEliminarAdmin.Name = "btnEliminarAdmin";
            this.btnEliminarAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarAdmin.Size = new System.Drawing.Size(181, 51);
            this.btnEliminarAdmin.TabIndex = 0;
            this.btnEliminarAdmin.Text = "Editar Administrativo";
            this.btnEliminarAdmin.UseVisualStyleBackColor = true;
            this.btnEliminarAdmin.Click += new System.EventHandler(this.btnDeleteMedico_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Location = new System.Drawing.Point(24, 12);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(232, 51);
            this.btnMedicos.TabIndex = 2;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(287, 12);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(232, 51);
            this.btnPacientes.TabIndex = 2;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.Location = new System.Drawing.Point(549, 12);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(232, 51);
            this.btnAdmins.TabIndex = 2;
            this.btnAdmins.Text = "Administrativos";
            this.btnAdmins.UseVisualStyleBackColor = true;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // grpPaciente
            // 
            this.grpPaciente.Controls.Add(this.btnListaPacientes);
            this.grpPaciente.Controls.Add(this.btnDeletePaciente);
            this.grpPaciente.Controls.Add(this.btnAddPaciente);
            this.grpPaciente.Controls.Add(this.btnEditarPaciente);
            this.grpPaciente.Location = new System.Drawing.Point(24, 167);
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Size = new System.Drawing.Size(757, 81);
            this.grpPaciente.TabIndex = 3;
            this.grpPaciente.TabStop = false;
            this.grpPaciente.Text = "grpPaciente";
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.btnListaAdmin);
            this.grpAdmin.Controls.Add(this.btnDeleteAdmin);
            this.grpAdmin.Controls.Add(this.btnAddAdministrativo);
            this.grpAdmin.Controls.Add(this.btnEliminarAdmin);
            this.grpAdmin.Location = new System.Drawing.Point(24, 254);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(757, 85);
            this.grpAdmin.TabIndex = 4;
            this.grpAdmin.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 677);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.grpPaciente);
            this.Controls.Add(this.btnAdmins);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.grpMedico);
            this.Name = "Form1";
            this.Text = "Gestion Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMedico.ResumeLayout(false);
            this.grpPaciente.ResumeLayout(false);
            this.grpAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMedico;
        private System.Windows.Forms.Button btnAddPaciente;
        private System.Windows.Forms.Button btnAddAdministrativo;
        private System.Windows.Forms.Button btnListaMedicos;
        private System.Windows.Forms.Button btnListaPacientes;
        private System.Windows.Forms.Button btnListaAdmin;
        private System.Windows.Forms.Button btnDeleteMedico;
        private System.Windows.Forms.Button btnDeletePaciente;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.GroupBox grpMedico;
        private System.Windows.Forms.Button btnEliminarAdmin;
        private System.Windows.Forms.Button btnEditarPaciente;
        private System.Windows.Forms.Button btnEditarMedico;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.GroupBox grpAdmin;
    }
}

