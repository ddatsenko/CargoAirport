namespace CargoAirport
{
    partial class FormAddNewAircraft
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
            this.labelIDAppointment = new System.Windows.Forms.Label();
            this.labelTitleAddNewAircraft = new System.Windows.Forms.Label();
            this.labelVolumeAllowed = new System.Windows.Forms.Label();
            this.labelMassAlloved = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.tbMass = new System.Windows.Forms.MaskedTextBox();
            this.tbVolume = new System.Windows.Forms.MaskedTextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelIDAppointment
            // 
            this.labelIDAppointment.AutoSize = true;
            this.labelIDAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIDAppointment.Location = new System.Drawing.Point(111, 59);
            this.labelIDAppointment.Name = "labelIDAppointment";
            this.labelIDAppointment.Size = new System.Drawing.Size(142, 13);
            this.labelIDAppointment.TabIndex = 17;
            this.labelIDAppointment.Text = "ID is appointed automatically";
            // 
            // labelTitleAddNewAircraft
            // 
            this.labelTitleAddNewAircraft.AutoSize = true;
            this.labelTitleAddNewAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleAddNewAircraft.Location = new System.Drawing.Point(109, 29);
            this.labelTitleAddNewAircraft.Name = "labelTitleAddNewAircraft";
            this.labelTitleAddNewAircraft.Size = new System.Drawing.Size(199, 26);
            this.labelTitleAddNewAircraft.TabIndex = 18;
            this.labelTitleAddNewAircraft.Text = "Register new cargo";
            // 
            // labelVolumeAllowed
            // 
            this.labelVolumeAllowed.AutoSize = true;
            this.labelVolumeAllowed.Location = new System.Drawing.Point(21, 176);
            this.labelVolumeAllowed.Name = "labelVolumeAllowed";
            this.labelVolumeAllowed.Size = new System.Drawing.Size(82, 13);
            this.labelVolumeAllowed.TabIndex = 9;
            this.labelVolumeAllowed.Text = "Volume Allowed";
            // 
            // labelMassAlloved
            // 
            this.labelMassAlloved.AutoSize = true;
            this.labelMassAlloved.Location = new System.Drawing.Point(31, 150);
            this.labelMassAlloved.Name = "labelMassAlloved";
            this.labelMassAlloved.Size = new System.Drawing.Size(72, 13);
            this.labelMassAlloved.TabIndex = 14;
            this.labelMassAlloved.Text = "Mass Allowed";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(67, 124);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 15;
            this.labelModel.Text = "Model";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(85, 98);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbID.Location = new System.Drawing.Point(114, 95);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(200, 21);
            this.tbID.TabIndex = 7;
            this.tbID.TabStop = false;
            this.tbID.Text = "Calculating...";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(389, 206);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 16;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(114, 147);
            this.tbMass.Mask = "99999";
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(350, 20);
            this.tbMass.TabIndex = 20;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(114, 173);
            this.tbVolume.Mask = "99999";
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(350, 20);
            this.tbVolume.TabIndex = 21;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(114, 121);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(350, 20);
            this.tbModel.TabIndex = 6;
            // 
            // FormAddNewAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 282);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbMass);
            this.Controls.Add(this.labelIDAppointment);
            this.Controls.Add(this.labelTitleAddNewAircraft);
            this.Controls.Add(this.labelVolumeAllowed);
            this.Controls.Add(this.labelMassAlloved);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.buttonRegister);
            this.Name = "FormAddNewAircraft";
            this.Text = "FormAddNewAircraft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelIDAppointment;
        private System.Windows.Forms.Label labelTitleAddNewAircraft;
        private System.Windows.Forms.Label labelVolumeAllowed;
        private System.Windows.Forms.Label labelMassAlloved;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.MaskedTextBox tbMass;
        private System.Windows.Forms.MaskedTextBox tbVolume;
        private System.Windows.Forms.TextBox tbModel;
    }
}