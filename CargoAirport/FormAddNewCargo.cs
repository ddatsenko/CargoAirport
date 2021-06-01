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
    public partial class FormAddNewCargo : Form
    {
        private int maxID()
        {
            CargoTerminal cargoTerminal = new CargoTerminal();
            CargoEnRoute cargoEnRoute = new CargoEnRoute();
            CargoArchive cargoArchive = new CargoArchive();
            if (cargoTerminal.FindMaxCargoID() > cargoEnRoute.FindMaxCargoID() & cargoTerminal.FindMaxCargoID() > cargoArchive.FindMaxCargoID())
            {
                return cargoTerminal.FindMaxCargoID()+1;
            }
            else if (cargoEnRoute.FindMaxCargoID() > cargoTerminal.FindMaxCargoID() & cargoEnRoute.FindMaxCargoID() > cargoArchive.FindMaxCargoID())
            {
                return cargoEnRoute.FindMaxCargoID()+1;
            }
            else
            {
                return cargoArchive.FindMaxCargoID()+1;
            }
        }
        public FormAddNewCargo()
        {
            InitializeComponent();
            tbID.Text = maxID().ToString();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (tbDestination.Text == "" | tbMass.Text == "" | tbVolume.Text == "" | tbType.Text == "" | tbSender.Text == "" | tbRecipient.Text == "")
            {
                MessageBox.Show("One or few feilds are not filled. Please, go back and provide all informations about the cargo.", "Information needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Cargo cargo = new Cargo(int.Parse(tbID.Text), String.Format("'{0}'", tbDestination.Text), int.Parse(tbMass.Text), int.Parse(tbVolume.Text), String.Format("'{0}'", tbType.Text), String.Format("'{0}'", tbSender.Text), String.Format("'{0}'", tbRecipient.Text));
                CargoTerminal cargoTerminal = new CargoTerminal();
                cargoTerminal.AddCargo(cargo);
                ActiveForm.Close();
            }
        }
    }
}
