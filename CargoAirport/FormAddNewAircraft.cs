using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoAirport
{
    public partial class FormAddNewAircraft : Form
    {
        public FormAddNewAircraft()
        {
            InitializeComponent();
            Aircraft aircraft = new Aircraft();
            tbID.Text = (aircraft.FindMaxAircraftID() + 1).ToString();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (tbModel.Text == "" | tbMass.Text == "" | tbVolume.Text == "")
            {
                MessageBox.Show("One or few feilds are not filled. Please, go back and provide all informations about the cargo.", "Information needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Aircraft aircraft = new Aircraft();
                aircraft.AddAircraft(int.Parse(tbID.Text), String.Format("'{0}'", tbModel.Text), int.Parse(tbMass.Text), int.Parse(tbVolume.Text));
                ActiveForm.Close();
            }
        }
    }
}
