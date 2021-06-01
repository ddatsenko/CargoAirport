namespace CargoAirport
{
    partial class FormManageAircraft
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
            this.labelAssignAircraft = new System.Windows.Forms.Label();
            this.AvailableAircraftManage = new System.Windows.Forms.DataGridView();
            this.CheckAircraft = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AircraftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MassAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewAircraft = new System.Windows.Forms.Button();
            this.buttonDeleteSelectedAircraft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableAircraftManage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAssignAircraft
            // 
            this.labelAssignAircraft.AutoSize = true;
            this.labelAssignAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAssignAircraft.Location = new System.Drawing.Point(15, 14);
            this.labelAssignAircraft.Name = "labelAssignAircraft";
            this.labelAssignAircraft.Size = new System.Drawing.Size(299, 26);
            this.labelAssignAircraft.TabIndex = 3;
            this.labelAssignAircraft.Text = "Available aircraft in the airport";
            // 
            // AvailableAircraftManage
            // 
            this.AvailableAircraftManage.AllowUserToAddRows = false;
            this.AvailableAircraftManage.AllowUserToDeleteRows = false;
            this.AvailableAircraftManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableAircraftManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckAircraft,
            this.AircraftID,
            this.Model,
            this.MassAllowed,
            this.VolumeAllowed});
            this.AvailableAircraftManage.Location = new System.Drawing.Point(20, 46);
            this.AvailableAircraftManage.Name = "AvailableAircraftManage";
            this.AvailableAircraftManage.Size = new System.Drawing.Size(560, 171);
            this.AvailableAircraftManage.TabIndex = 2;
            // 
            // CheckAircraft
            // 
            this.CheckAircraft.HeaderText = " ";
            this.CheckAircraft.Name = "CheckAircraft";
            this.CheckAircraft.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckAircraft.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AircraftID
            // 
            this.AircraftID.DataPropertyName = "ID";
            this.AircraftID.HeaderText = "Aircraft";
            this.AircraftID.Name = "AircraftID";
            this.AircraftID.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // MassAllowed
            // 
            this.MassAllowed.DataPropertyName = "MassAllowed";
            this.MassAllowed.HeaderText = "Mass Allowed";
            this.MassAllowed.Name = "MassAllowed";
            this.MassAllowed.ReadOnly = true;
            // 
            // VolumeAllowed
            // 
            this.VolumeAllowed.DataPropertyName = "VolumeAllowed";
            this.VolumeAllowed.HeaderText = "Volume Allowed";
            this.VolumeAllowed.Name = "VolumeAllowed";
            this.VolumeAllowed.ReadOnly = true;
            // 
            // buttonAddNewAircraft
            // 
            this.buttonAddNewAircraft.Location = new System.Drawing.Point(20, 225);
            this.buttonAddNewAircraft.Name = "buttonAddNewAircraft";
            this.buttonAddNewAircraft.Size = new System.Drawing.Size(95, 23);
            this.buttonAddNewAircraft.TabIndex = 5;
            this.buttonAddNewAircraft.Text = "Add new aircraft";
            this.buttonAddNewAircraft.UseVisualStyleBackColor = true;
            this.buttonAddNewAircraft.Click += new System.EventHandler(this.buttonAddNewAircraft_Clicked);
            // 
            // buttonDeleteSelectedAircraft
            // 
            this.buttonDeleteSelectedAircraft.Location = new System.Drawing.Point(121, 225);
            this.buttonDeleteSelectedAircraft.Name = "buttonDeleteSelectedAircraft";
            this.buttonDeleteSelectedAircraft.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteSelectedAircraft.TabIndex = 6;
            this.buttonDeleteSelectedAircraft.Text = "Delete selected";
            this.buttonDeleteSelectedAircraft.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedAircraft.Click += new System.EventHandler(this.buttonDeleteSelectedAircraft_Clicked);
            // 
            // FormManageAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 274);
            this.Controls.Add(this.buttonAddNewAircraft);
            this.Controls.Add(this.buttonDeleteSelectedAircraft);
            this.Controls.Add(this.labelAssignAircraft);
            this.Controls.Add(this.AvailableAircraftManage);
            this.Name = "FormManageAircraft";
            this.Text = "FormManageAircraft";
            ((System.ComponentModel.ISupportInitialize)(this.AvailableAircraftManage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAssignAircraft;
        private System.Windows.Forms.DataGridView AvailableAircraftManage;
        private System.Windows.Forms.Button buttonAddNewAircraft;
        private System.Windows.Forms.Button buttonDeleteSelectedAircraft;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckAircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn MassAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeAllowed;
    }
}