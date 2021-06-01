namespace CargoAirport
{
    partial class FormSendToLoading
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
            this.AvailableAircraftPick = new System.Windows.Forms.DataGridView();
            this.labelAssignAircraft = new System.Windows.Forms.Label();
            this.Aircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MassAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignAircraft = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableAircraftPick)).BeginInit();
            this.SuspendLayout();
            // 
            // AvailableAircraftPick
            // 
            this.AvailableAircraftPick.AllowUserToAddRows = false;
            this.AvailableAircraftPick.AllowUserToDeleteRows = false;
            this.AvailableAircraftPick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableAircraftPick.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aircraft,
            this.Model,
            this.MassAllowed,
            this.VolumeAllowed,
            this.AssignAircraft});
            this.AvailableAircraftPick.Location = new System.Drawing.Point(20, 58);
            this.AvailableAircraftPick.Name = "AvailableAircraftPick";
            this.AvailableAircraftPick.ReadOnly = true;
            this.AvailableAircraftPick.Size = new System.Drawing.Size(543, 171);
            this.AvailableAircraftPick.TabIndex = 0;
            this.AvailableAircraftPick.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AvailableAircraftPick_CellContentClick);
            // 
            // labelAssignAircraft
            // 
            this.labelAssignAircraft.AutoSize = true;
            this.labelAssignAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAssignAircraft.Location = new System.Drawing.Point(15, 26);
            this.labelAssignAircraft.Name = "labelAssignAircraft";
            this.labelAssignAircraft.Size = new System.Drawing.Size(325, 26);
            this.labelAssignAircraft.TabIndex = 1;
            this.labelAssignAircraft.Text = "Available aircraft for this delivery";
            // 
            // Aircraft
            // 
            this.Aircraft.DataPropertyName = "ID";
            this.Aircraft.HeaderText = "Aircraft";
            this.Aircraft.Name = "Aircraft";
            this.Aircraft.ReadOnly = true;
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
            // AssignAircraft
            // 
            this.AssignAircraft.HeaderText = "AssignAircraft";
            this.AssignAircraft.Name = "AssignAircraft";
            this.AssignAircraft.ReadOnly = true;
            this.AssignAircraft.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AssignAircraft.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AssignAircraft.Text = "Assign";
            this.AssignAircraft.UseColumnTextForButtonValue = true;
            // 
            // FormSendToLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 273);
            this.Controls.Add(this.labelAssignAircraft);
            this.Controls.Add(this.AvailableAircraftPick);
            this.Name = "FormSendToLoading";
            this.Text = "SendToLoading";
            ((System.ComponentModel.ISupportInitialize)(this.AvailableAircraftPick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AvailableAircraftPick;
        private System.Windows.Forms.Label labelAssignAircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn MassAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeAllowed;
        private System.Windows.Forms.DataGridViewButtonColumn AssignAircraft;
    }
}