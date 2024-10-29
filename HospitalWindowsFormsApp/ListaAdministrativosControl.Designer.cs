namespace HospitalWindowsFormsApp
{
    partial class ListaAdministrativosControl
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
            this.lstViewAdmins = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstViewAdmins
            // 
            this.lstViewAdmins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstViewAdmins.HideSelection = false;
            this.lstViewAdmins.Location = new System.Drawing.Point(3, 21);
            this.lstViewAdmins.Name = "lstViewAdmins";
            this.lstViewAdmins.Size = new System.Drawing.Size(751, 363);
            this.lstViewAdmins.TabIndex = 0;
            this.lstViewAdmins.UseCompatibleStateImageBehavior = false;
            this.lstViewAdmins.View = System.Windows.Forms.View.Details;
            this.lstViewAdmins.SelectedIndexChanged += new System.EventHandler(this.lstViewAdmins_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Edad";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Movil";
            this.columnHeader3.Width = 197;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Puesto";
            this.columnHeader4.Width = 249;
            // 
            // ListaAdministrativosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstViewAdmins);
            this.Location = new System.Drawing.Point(22, 257);
            this.Name = "ListaAdministrativosControl";
            this.Size = new System.Drawing.Size(757, 408);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewAdmins;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
