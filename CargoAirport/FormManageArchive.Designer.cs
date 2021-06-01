namespace CargoAirport
{
    partial class FormManageArchive
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
            this.buttonDeleteSelectedCargo = new System.Windows.Forms.Button();
            this.labelAssignAircraft = new System.Windows.Forms.Label();
            this.ArchiveCargoList = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AircraftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveCargoList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteSelectedCargo
            // 
            this.buttonDeleteSelectedCargo.Location = new System.Drawing.Point(19, 279);
            this.buttonDeleteSelectedCargo.Name = "buttonDeleteSelectedCargo";
            this.buttonDeleteSelectedCargo.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteSelectedCargo.TabIndex = 10;
            this.buttonDeleteSelectedCargo.Text = "Delete selected";
            this.buttonDeleteSelectedCargo.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedCargo.Click += new System.EventHandler(this.ButtonDeleteSelectedCargo_Click);
            // 
            // labelAssignAircraft
            // 
            this.labelAssignAircraft.AutoSize = true;
            this.labelAssignAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAssignAircraft.Location = new System.Drawing.Point(14, 29);
            this.labelAssignAircraft.Name = "labelAssignAircraft";
            this.labelAssignAircraft.Size = new System.Drawing.Size(263, 26);
            this.labelAssignAircraft.TabIndex = 8;
            this.labelAssignAircraft.Text = "Archive of delivered cargo";
            // 
            // ArchiveCargoList
            // 
            this.ArchiveCargoList.AllowUserToAddRows = false;
            this.ArchiveCargoList.AllowUserToDeleteRows = false;
            this.ArchiveCargoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchiveCargoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.ID,
            this.Destination,
            this.Mass,
            this.Volume,
            this.Type,
            this.Sender,
            this.Recipient,
            this.AircraftID,
            this.ShippingTime});
            this.ArchiveCargoList.Location = new System.Drawing.Point(19, 68);
            this.ArchiveCargoList.Name = "ArchiveCargoList";
            this.ArchiveCargoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArchiveCargoList.Size = new System.Drawing.Size(943, 200);
            this.ArchiveCargoList.TabIndex = 11;
            // 
            // Check
            // 
            this.Check.FalseValue = "False";
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.Width = 45;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // Destination
            // 
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Width = 80;
            // 
            // Mass
            // 
            this.Mass.DataPropertyName = "Mass";
            this.Mass.HeaderText = "Mass";
            this.Mass.Name = "Mass";
            this.Mass.ReadOnly = true;
            this.Mass.Width = 50;
            // 
            // Volume
            // 
            this.Volume.DataPropertyName = "Volume";
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.Width = 50;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // Sender
            // 
            this.Sender.DataPropertyName = "Sender";
            this.Sender.HeaderText = "Sender";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            this.Sender.Width = 130;
            // 
            // Recipient
            // 
            this.Recipient.DataPropertyName = "Recipient";
            this.Recipient.HeaderText = "Recipient";
            this.Recipient.Name = "Recipient";
            this.Recipient.ReadOnly = true;
            this.Recipient.Width = 130;
            // 
            // AircraftID
            // 
            this.AircraftID.DataPropertyName = "AircraftID";
            this.AircraftID.HeaderText = "Aircraft";
            this.AircraftID.Name = "AircraftID";
            // 
            // ShippingTime
            // 
            this.ShippingTime.DataPropertyName = "ShippingTime";
            this.ShippingTime.HeaderText = "Shipping Time";
            this.ShippingTime.Name = "ShippingTime";
            // 
            // FormManageArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 331);
            this.Controls.Add(this.ArchiveCargoList);
            this.Controls.Add(this.buttonDeleteSelectedCargo);
            this.Controls.Add(this.labelAssignAircraft);
            this.Name = "FormManageArchive";
            this.Text = "FormManageArchive";
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveCargoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteSelectedCargo;
        private System.Windows.Forms.Label labelAssignAircraft;
        private System.Windows.Forms.DataGridView ArchiveCargoList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingTime;
    }
}