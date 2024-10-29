namespace HospitalWindowsFormsApp
{
    partial class AddAdminControl
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
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.txtPuestoA = new System.Windows.Forms.TextBox();
            this.txtMovilA = new System.Windows.Forms.TextBox();
            this.txtEdadA = new System.Windows.Forms.TextBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(381, 341);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(143, 23);
            this.btnAddAdmin.TabIndex = 12;
            this.btnAddAdmin.Text = "Añadir";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // txtPuestoA
            // 
            this.txtPuestoA.Location = new System.Drawing.Point(381, 265);
            this.txtPuestoA.Name = "txtPuestoA";
            this.txtPuestoA.Size = new System.Drawing.Size(143, 22);
            this.txtPuestoA.TabIndex = 7;
            // 
            // txtMovilA
            // 
            this.txtMovilA.Location = new System.Drawing.Point(381, 189);
            this.txtMovilA.Name = "txtMovilA";
            this.txtMovilA.Size = new System.Drawing.Size(143, 22);
            this.txtMovilA.TabIndex = 8;
            // 
            // txtEdadA
            // 
            this.txtEdadA.Location = new System.Drawing.Point(381, 113);
            this.txtEdadA.Name = "txtEdadA";
            this.txtEdadA.Size = new System.Drawing.Size(143, 22);
            this.txtEdadA.TabIndex = 9;
            // 
            // txtNombreA
            // 
            this.txtNombreA.Location = new System.Drawing.Point(381, 44);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(143, 22);
            this.txtNombreA.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 119);
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
            // AddAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.txtPuestoA);
            this.Controls.Add(this.txtMovilA);
            this.Controls.Add(this.txtEdadA);
            this.Controls.Add(this.txtNombreA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(22, 257);
            this.Name = "AddAdminControl";
            this.Size = new System.Drawing.Size(757, 408);
            this.Load += new System.EventHandler(this.AddAdminControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.TextBox txtPuestoA;
        private System.Windows.Forms.TextBox txtMovilA;
        private System.Windows.Forms.TextBox txtEdadA;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
