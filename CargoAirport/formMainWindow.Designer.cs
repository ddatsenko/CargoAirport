namespace CargoAirport
{
    partial class FormMainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonAddNewCargo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EnRouteCargoList = new System.Windows.Forms.DataGridView();
            this.AssignedAircraftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnRouteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnRouteDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnRouteMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnRouteVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnRouteType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnRouteSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnRouteRecipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSendToLoad = new System.Windows.Forms.Button();
            this.buttonRefresh2 = new System.Windows.Forms.Button();
            this.TerminalCargoList = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AircraftList = new System.Windows.Forms.DataGridView();
            this.AircraftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonManageAircraft = new System.Windows.Forms.Button();
            this.cargoTerminalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOpenArchive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EnRouteCargoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminalCargoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AircraftList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTerminalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(623, 18);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(135, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh all tables";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(123, 206);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteSelected.TabIndex = 4;
            this.buttonDeleteSelected.Text = "Delete selected";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Clicked);
            // 
            // buttonAddNewCargo
            // 
            this.buttonAddNewCargo.Location = new System.Drawing.Point(22, 206);
            this.buttonAddNewCargo.Name = "buttonAddNewCargo";
            this.buttonAddNewCargo.Size = new System.Drawing.Size(95, 23);
            this.buttonAddNewCargo.TabIndex = 4;
            this.buttonAddNewCargo.Text = "Add new cargo";
            this.buttonAddNewCargo.UseVisualStyleBackColor = true;
            this.buttonAddNewCargo.Click += new System.EventHandler(this.buttonAddNewCargo_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registered cargo in terminal";
            // 
            // EnRouteCargoList
            // 
            this.EnRouteCargoList.AllowUserToAddRows = false;
            this.EnRouteCargoList.AllowUserToDeleteRows = false;
            this.EnRouteCargoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnRouteCargoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignedAircraftID,
            this.EnRouteID,
            this.EnRouteDestination,
            this.EnRouteMass,
            this.EnRouteVolume,
            this.EnRouteType,
            this.EnRouteSender,
            this.EnRouteRecipient});
            this.EnRouteCargoList.Location = new System.Drawing.Point(22, 434);
            this.EnRouteCargoList.Name = "EnRouteCargoList";
            this.EnRouteCargoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnRouteCargoList.Size = new System.Drawing.Size(740, 150);
            this.EnRouteCargoList.TabIndex = 3;
            // 
            // AssignedAircraftID
            // 
            this.AssignedAircraftID.DataPropertyName = "AircraftID";
            this.AssignedAircraftID.HeaderText = "Aircraft";
            this.AssignedAircraftID.Name = "AssignedAircraftID";
            this.AssignedAircraftID.ReadOnly = true;
            this.AssignedAircraftID.Width = 45;
            // 
            // EnRouteID
            // 
            this.EnRouteID.DataPropertyName = "ID";
            this.EnRouteID.HeaderText = "ID";
            this.EnRouteID.Name = "EnRouteID";
            this.EnRouteID.ReadOnly = true;
            this.EnRouteID.Width = 45;
            // 
            // EnRouteDestination
            // 
            this.EnRouteDestination.DataPropertyName = "Destination";
            this.EnRouteDestination.HeaderText = "Destination";
            this.EnRouteDestination.Name = "EnRouteDestination";
            this.EnRouteDestination.ReadOnly = true;
            this.EnRouteDestination.Width = 80;
            // 
            // EnRouteMass
            // 
            this.EnRouteMass.DataPropertyName = "Mass";
            this.EnRouteMass.HeaderText = "Mass";
            this.EnRouteMass.Name = "EnRouteMass";
            this.EnRouteMass.ReadOnly = true;
            this.EnRouteMass.Width = 50;
            // 
            // EnRouteVolume
            // 
            this.EnRouteVolume.DataPropertyName = "Volume";
            this.EnRouteVolume.HeaderText = "Volume";
            this.EnRouteVolume.Name = "EnRouteVolume";
            this.EnRouteVolume.ReadOnly = true;
            this.EnRouteVolume.Width = 50;
            // 
            // EnRouteType
            // 
            this.EnRouteType.DataPropertyName = "Type";
            this.EnRouteType.HeaderText = "Type";
            this.EnRouteType.Name = "EnRouteType";
            this.EnRouteType.ReadOnly = true;
            this.EnRouteType.Width = 150;
            // 
            // EnRouteSender
            // 
            this.EnRouteSender.DataPropertyName = "Sender";
            this.EnRouteSender.HeaderText = "Sender";
            this.EnRouteSender.Name = "EnRouteSender";
            this.EnRouteSender.ReadOnly = true;
            this.EnRouteSender.Width = 130;
            // 
            // EnRouteRecipient
            // 
            this.EnRouteRecipient.DataPropertyName = "Recipient";
            this.EnRouteRecipient.HeaderText = "Recipient";
            this.EnRouteRecipient.Name = "EnRouteRecipient";
            this.EnRouteRecipient.ReadOnly = true;
            this.EnRouteRecipient.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cargo and aircraft en route";
            // 
            // buttonSendToLoad
            // 
            this.buttonSendToLoad.Location = new System.Drawing.Point(224, 206);
            this.buttonSendToLoad.Name = "buttonSendToLoad";
            this.buttonSendToLoad.Size = new System.Drawing.Size(95, 23);
            this.buttonSendToLoad.TabIndex = 4;
            this.buttonSendToLoad.Text = "Send to loading";
            this.buttonSendToLoad.UseVisualStyleBackColor = true;
            this.buttonSendToLoad.Click += new System.EventHandler(this.buttonSendToLoad_Clicked);
            // 
            // buttonRefresh2
            // 
            this.buttonRefresh2.Location = new System.Drawing.Point(625, 247);
            this.buttonRefresh2.Name = "buttonRefresh2";
            this.buttonRefresh2.Size = new System.Drawing.Size(135, 23);
            this.buttonRefresh2.TabIndex = 4;
            this.buttonRefresh2.Text = "Refresh all tables";
            this.buttonRefresh2.UseVisualStyleBackColor = true;
            this.buttonRefresh2.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // TerminalCargoList
            // 
            this.TerminalCargoList.AllowUserToAddRows = false;
            this.TerminalCargoList.AllowUserToDeleteRows = false;
            this.TerminalCargoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TerminalCargoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.ID,
            this.Destination,
            this.Mass,
            this.Volume,
            this.Type,
            this.Sender,
            this.Recipient});
            this.TerminalCargoList.Location = new System.Drawing.Point(22, 49);
            this.TerminalCargoList.Name = "TerminalCargoList";
            this.TerminalCargoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TerminalCargoList.Size = new System.Drawing.Size(740, 150);
            this.TerminalCargoList.TabIndex = 3;
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
            // AircraftList
            // 
            this.AircraftList.AllowUserToAddRows = false;
            this.AircraftList.AllowUserToDeleteRows = false;
            this.AircraftList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AircraftList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AircraftID,
            this.Model,
            this.Availability,
            this.Status,
            this.DepartureTime,
            this.ArrivalTime,
            this.ReturnTime});
            this.AircraftList.Location = new System.Drawing.Point(22, 278);
            this.AircraftList.Name = "AircraftList";
            this.AircraftList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AircraftList.Size = new System.Drawing.Size(740, 150);
            this.AircraftList.TabIndex = 3;
            // 
            // AircraftID
            // 
            this.AircraftID.DataPropertyName = "ID";
            this.AircraftID.HeaderText = "Aircraft";
            this.AircraftID.Name = "AircraftID";
            this.AircraftID.ReadOnly = true;
            this.AircraftID.Width = 45;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.Width = 170;
            // 
            // Availability
            // 
            this.Availability.DataPropertyName = "Availability";
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            this.Availability.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 130;
            // 
            // DepartureTime
            // 
            this.DepartureTime.DataPropertyName = "DepartureTime";
            this.DepartureTime.HeaderText = "Departure";
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.Width = 110;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.DataPropertyName = "ArrivalTime";
            this.ArrivalTime.HeaderText = "Arrival";
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Width = 110;
            // 
            // ReturnTime
            // 
            this.ReturnTime.DataPropertyName = "ReturnTime";
            this.ReturnTime.HeaderText = "Return";
            this.ReturnTime.Name = "ReturnTime";
            this.ReturnTime.Width = 110;
            // 
            // buttonManageAircraft
            // 
            this.buttonManageAircraft.Location = new System.Drawing.Point(524, 247);
            this.buttonManageAircraft.Name = "buttonManageAircraft";
            this.buttonManageAircraft.Size = new System.Drawing.Size(95, 23);
            this.buttonManageAircraft.TabIndex = 4;
            this.buttonManageAircraft.Text = "Manage aircraft";
            this.buttonManageAircraft.UseVisualStyleBackColor = true;
            this.buttonManageAircraft.Click += new System.EventHandler(this.buttonManageAircraft_Clicked);
            // 
            // cargoTerminalBindingSource
            // 
            this.cargoTerminalBindingSource.DataSource = typeof(CargoAirport.CargoTerminal);
            // 
            // buttonOpenArchive
            // 
            this.buttonOpenArchive.Location = new System.Drawing.Point(423, 247);
            this.buttonOpenArchive.Name = "buttonOpenArchive";
            this.buttonOpenArchive.Size = new System.Drawing.Size(95, 23);
            this.buttonOpenArchive.TabIndex = 4;
            this.buttonOpenArchive.Text = "Manage archive";
            this.buttonOpenArchive.UseVisualStyleBackColor = true;
            this.buttonOpenArchive.Click += new System.EventHandler(this.buttonManageArchive_Clicked);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenArchive);
            this.Controls.Add(this.buttonManageAircraft);
            this.Controls.Add(this.buttonAddNewCargo);
            this.Controls.Add(this.buttonSendToLoad);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.AircraftList);
            this.Controls.Add(this.EnRouteCargoList);
            this.Controls.Add(this.buttonRefresh2);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.TerminalCargoList);
            this.Name = "FormMainWindow";
            this.Text = "Cargo Terminal";
            ((System.ComponentModel.ISupportInitialize)(this.EnRouteCargoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminalCargoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AircraftList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTerminalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cargoTerminalBindingSource;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonAddNewCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EnRouteCargoList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSendToLoad;
        private System.Windows.Forms.Button buttonRefresh2;
        private System.Windows.Forms.DataGridView TerminalCargoList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipient;
        private System.Windows.Forms.DataGridView AircraftList;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnTime;
        private System.Windows.Forms.Button buttonManageAircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedAircraftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnRouteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnRouteDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnRouteMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnRouteVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnRouteType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnRouteSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnRouteRecipient;
        private System.Windows.Forms.Button buttonOpenArchive;
    }
}

