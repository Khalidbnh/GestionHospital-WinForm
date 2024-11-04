namespace HospitalWindowsFormsApp
{
    partial class CitaForm
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
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnPedirCita = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.datetimeCita = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(12, 84);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.RowHeadersWidth = 51;
            this.dgvMedicos.RowTemplate.Height = 24;
            this.dgvMedicos.Size = new System.Drawing.Size(401, 150);
            this.dgvMedicos.TabIndex = 0;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(465, 84);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.RowTemplate.Height = 24;
            this.dgvPacientes.Size = new System.Drawing.Size(401, 150);
            this.dgvPacientes.TabIndex = 1;
            // 
            // btnPedirCita
            // 
            this.btnPedirCita.Location = new System.Drawing.Point(363, 240);
            this.btnPedirCita.Name = "btnPedirCita";
            this.btnPedirCita.Size = new System.Drawing.Size(158, 49);
            this.btnPedirCita.TabIndex = 2;
            this.btnPedirCita.Text = "Pedir Cita";
            this.btnPedirCita.UseVisualStyleBackColor = true;
            this.btnPedirCita.Click += new System.EventHandler(this.btnPedirCita_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(363, 295);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(158, 49);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Citas";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(255, 350);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.RowTemplate.Height = 24;
            this.dgvCitas.Size = new System.Drawing.Size(389, 212);
            this.dgvCitas.TabIndex = 3;
            // 
            // datetimeCita
            // 
            this.datetimeCita.Location = new System.Drawing.Point(319, 56);
            this.datetimeCita.Name = "datetimeCita";
            this.datetimeCita.Size = new System.Drawing.Size(255, 22);
            this.datetimeCita.TabIndex = 4;
            // 
            // CitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 574);
            this.Controls.Add(this.datetimeCita);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnPedirCita);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.dgvMedicos);
            this.Name = "CitaForm";
            this.Text = "CitaForm";
            this.Load += new System.EventHandler(this.CitaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnPedirCita;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DateTimePicker datetimeCita;
    }
}