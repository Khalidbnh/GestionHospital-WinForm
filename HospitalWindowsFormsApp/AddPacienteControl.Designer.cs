namespace HospitalWindowsFormsApp
{
    partial class AddPacienteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAddPaciente = new System.Windows.Forms.Button();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.txtMovilP = new System.Windows.Forms.TextBox();
            this.txtEdadP = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMedicoAsignado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.Location = new System.Drawing.Point(381, 352);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(143, 23);
            this.btnAddPaciente.TabIndex = 12;
            this.btnAddPaciente.Text = "Añadir";
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            this.btnAddPaciente.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(382, 164);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(143, 22);
            this.txtEnfermedad.TabIndex = 7;
            // 
            // txtMovilP
            // 
            this.txtMovilP.Location = new System.Drawing.Point(382, 126);
            this.txtMovilP.Name = "txtMovilP";
            this.txtMovilP.Size = new System.Drawing.Size(143, 22);
            this.txtMovilP.TabIndex = 8;
            // 
            // txtEdadP
            // 
            this.txtEdadP.Location = new System.Drawing.Point(381, 84);
            this.txtEdadP.Name = "txtEdadP";
            this.txtEdadP.Size = new System.Drawing.Size(143, 22);
            this.txtEdadP.TabIndex = 9;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(381, 45);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(143, 22);
            this.txtNombreP.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enfermedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(381, 202);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(143, 22);
            this.txtPeso.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(381, 243);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(143, 22);
            this.txtAltura.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre del Médico Asignado";
            // 
            // cmbMedicoAsignado
            // 
            this.cmbMedicoAsignado.FormattingEnabled = true;
            this.cmbMedicoAsignado.Location = new System.Drawing.Point(381, 284);
            this.cmbMedicoAsignado.Name = "cmbMedicoAsignado";
            this.cmbMedicoAsignado.Size = new System.Drawing.Size(143, 24);
            this.cmbMedicoAsignado.TabIndex = 13;
            // 
            // AddPacienteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbMedicoAsignado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAddPaciente);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.txtMovilP);
            this.Controls.Add(this.txtEdadP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(22, 257);
            this.Name = "AddPacienteControl";
            this.Size = new System.Drawing.Size(757, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddPaciente;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.TextBox txtMovilP;
        private System.Windows.Forms.TextBox txtEdadP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMedicoAsignado;
    }
}
