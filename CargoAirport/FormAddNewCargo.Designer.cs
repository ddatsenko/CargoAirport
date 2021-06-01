namespace CargoAirport
{
    partial class FormAddNewCargo
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
            this.labelTitleAddNewCargo = new System.Windows.Forms.Label();
            this.labelIDAppointment = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbDestination = new System.Windows.Forms.MaskedTextBox();
            this.tbMass = new System.Windows.Forms.MaskedTextBox();
            this.tbVolume = new System.Windows.Forms.MaskedTextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.tbRecipient = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelMass = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSender = new System.Windows.Forms.Label();
            this.labelRecipient = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleAddNewCargo
            // 
            this.labelTitleAddNewCargo.AutoSize = true;
            this.labelTitleAddNewCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleAddNewCargo.Location = new System.Drawing.Point(107, 23);
            this.labelTitleAddNewCargo.Name = "labelTitleAddNewCargo";
            this.labelTitleAddNewCargo.Size = new System.Drawing.Size(199, 26);
            this.labelTitleAddNewCargo.TabIndex = 3;
            this.labelTitleAddNewCargo.Text = "Register new cargo";
            // 
            // labelIDAppointment
            // 
            this.labelIDAppointment.AutoSize = true;
            this.labelIDAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIDAppointment.Location = new System.Drawing.Point(109, 53);
            this.labelIDAppointment.Name = "labelIDAppointment";
            this.labelIDAppointment.Size = new System.Drawing.Size(142, 13);
            this.labelIDAppointment.TabIndex = 3;
            this.labelIDAppointment.Text = "ID is appointed automatically";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbID.Location = new System.Drawing.Point(112, 89);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(200, 21);
            this.tbID.TabIndex = 0;
            this.tbID.TabStop = false;
            this.tbID.Text = "Calculating...";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(112, 115);
            this.tbDestination.Mask = ">LLL";
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(200, 20);
            this.tbDestination.TabIndex = 0;
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(112, 141);
            this.tbMass.Mask = "99999";
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(200, 20);
            this.tbMass.TabIndex = 0;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(112, 167);
            this.tbVolume.Mask = "99999";
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(200, 20);
            this.tbVolume.TabIndex = 0;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(112, 193);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(350, 20);
            this.tbType.TabIndex = 0;
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(112, 219);
            this.tbSender.Multiline = true;
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(350, 80);
            this.tbSender.TabIndex = 0;
            // 
            // tbRecipient
            // 
            this.tbRecipient.Location = new System.Drawing.Point(112, 305);
            this.tbRecipient.Multiline = true;
            this.tbRecipient.Name = "tbRecipient";
            this.tbRecipient.Size = new System.Drawing.Size(350, 80);
            this.tbRecipient.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(78, 92);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(36, 118);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(60, 13);
            this.labelDestination.TabIndex = 1;
            this.labelDestination.Text = "Destination";
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Location = new System.Drawing.Point(64, 144);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(32, 13);
            this.labelMass.TabIndex = 1;
            this.labelMass.Text = "Mass";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(54, 170);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(42, 13);
            this.labelVolume.TabIndex = 1;
            this.labelVolume.Text = "Volume";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(64, 196);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type";
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.Location = new System.Drawing.Point(55, 222);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(41, 13);
            this.labelSender.TabIndex = 1;
            this.labelSender.Text = "Sender";
            // 
            // labelRecipient
            // 
            this.labelRecipient.AutoSize = true;
            this.labelRecipient.Location = new System.Drawing.Point(44, 308);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(52, 13);
            this.labelRecipient.TabIndex = 1;
            this.labelRecipient.Text = "Recipient";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(387, 408);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // FormAddNewCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 472);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.tbMass);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbSender);
            this.Controls.Add(this.tbRecipient);
            this.Controls.Add(this.labelIDAppointment);
            this.Controls.Add(this.labelTitleAddNewCargo);
            this.Controls.Add(this.labelRecipient);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSender);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelMass);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonRegister);
            this.Name = "FormAddNewCargo";
            this.Text = "New Cargo Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.MaskedTextBox tbDestination;
        private System.Windows.Forms.MaskedTextBox tbMass;
        private System.Windows.Forms.MaskedTextBox tbVolume;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.TextBox tbRecipient;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.Label labelTitleAddNewCargo;
        private System.Windows.Forms.Label labelIDAppointment;
        private System.Windows.Forms.Button buttonRegister;
    }
}