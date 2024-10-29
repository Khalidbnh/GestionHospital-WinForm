namespace HospitalWindowsFormsApp
{
    partial class ListaPacientesControl
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
            this.lstviewPacientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstviewPacientes
            // 
            this.lstviewPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstviewPacientes.HideSelection = false;
            this.lstviewPacientes.Location = new System.Drawing.Point(3, 40);
            this.lstviewPacientes.Name = "lstviewPacientes";
            this.lstviewPacientes.Size = new System.Drawing.Size(751, 342);
            this.lstviewPacientes.TabIndex = 0;
            this.lstviewPacientes.UseCompatibleStateImageBehavior = false;
            this.lstviewPacientes.View = System.Windows.Forms.View.Details;
            this.lstviewPacientes.SelectedIndexChanged += new System.EventHandler(this.lstviewPacientes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre del Paciente";
            this.columnHeader1.Width = 182;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Edad";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Movil";
            this.columnHeader3.Width = 163;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Enfermedad";
            this.columnHeader4.Width = 178;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Peso";
            this.columnHeader5.Width = 82;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Altura";
            this.columnHeader6.Width = 69;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Medico Asigned";
            // 
            // ListaPacientesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstviewPacientes);
            this.Location = new System.Drawing.Point(22, 257);
            this.Name = "ListaPacientesControl";
            this.Size = new System.Drawing.Size(757, 408);
            this.Load += new System.EventHandler(this.ListaPacientesControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstviewPacientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
