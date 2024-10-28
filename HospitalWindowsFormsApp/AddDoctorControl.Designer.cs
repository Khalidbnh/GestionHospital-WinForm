namespace HospitalWindowsFormsApp
{
    partial class AddDoctorControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.txtEdadDoctor = new System.Windows.Forms.TextBox();
            this.txtMovilDoctor = new System.Windows.Forms.TextBox();
            this.txtEspecialidadDoctor = new System.Windows.Forms.TextBox();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Movil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Especialidad";
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Location = new System.Drawing.Point(153, 36);
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(143, 22);
            this.txtNombreDoctor.TabIndex = 1;
            // 
            // txtEdadDoctor
            // 
            this.txtEdadDoctor.Location = new System.Drawing.Point(153, 105);
            this.txtEdadDoctor.Name = "txtEdadDoctor";
            this.txtEdadDoctor.Size = new System.Drawing.Size(143, 22);
            this.txtEdadDoctor.TabIndex = 1;
            // 
            // txtMovilDoctor
            // 
            this.txtMovilDoctor.Location = new System.Drawing.Point(153, 181);
            this.txtMovilDoctor.Name = "txtMovilDoctor";
            this.txtMovilDoctor.Size = new System.Drawing.Size(143, 22);
            this.txtMovilDoctor.TabIndex = 1;
            // 
            // txtEspecialidadDoctor
            // 
            this.txtEspecialidadDoctor.Location = new System.Drawing.Point(153, 257);
            this.txtEspecialidadDoctor.Name = "txtEspecialidadDoctor";
            this.txtEspecialidadDoctor.Size = new System.Drawing.Size(143, 22);
            this.txtEspecialidadDoctor.TabIndex = 1;
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(153, 333);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(143, 23);
            this.btnAddDoctor.TabIndex = 2;
            this.btnAddDoctor.Text = "Añadir";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(4, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AddDoctorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.txtEspecialidadDoctor);
            this.Controls.Add(this.txtMovilDoctor);
            this.Controls.Add(this.txtEdadDoctor);
            this.Controls.Add(this.txtNombreDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(22, 257);
            this.Name = "AddDoctorControl";
            this.Size = new System.Drawing.Size(757, 408);
            this.Load += new System.EventHandler(this.AddDoctorControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreDoctor;
        private System.Windows.Forms.TextBox txtEdadDoctor;
        private System.Windows.Forms.TextBox txtMovilDoctor;
        private System.Windows.Forms.TextBox txtEspecialidadDoctor;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnCancelar;
    }
}
