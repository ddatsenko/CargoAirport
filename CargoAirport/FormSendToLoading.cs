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
    public partial class FormSendToLoading : Form
    {
        DataGridView TerminalCargoList;
        public FormSendToLoading(DataTable aircraftAvailable, DataGridView terminalCargoList)
        {
            InitializeComponent();
            AvailableAircraftPick.AutoGenerateColumns = false;
            AvailableAircraftPick.DataSource = aircraftAvailable;
            TerminalCargoList = terminalCargoList;

        }

        private void AvailableAircraftPick_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AvailableAircraftPick.Columns[e.ColumnIndex].Name == "AssignAircraft")
            {
                CargoTerminal cargoTerminal = new CargoTerminal();
                CargoEnRoute cargoEnRoute = new CargoEnRoute();
                foreach (DataGridViewRow row in TerminalCargoList.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        Cargo cargo = new Cargo();
                        cargo.ID = int.Parse(row.Cells["ID"].Value.ToString());
                        cargo.Destination = string.Format("'{0}'", row.Cells["Destination"].Value.ToString());
                        cargo.Mass = int.Parse(row.Cells["Mass"].Value.ToString());
                        cargo.Volume = int.Parse(row.Cells["Volume"].Value.ToString());
                        cargo.Type = string.Format("'{0}'", row.Cells["Type"].Value.ToString());
                        cargo.Sender = string.Format("'{0}'", row.Cells["Sender"].Value.ToString());
                        cargo.Recipient = string.Format("'{0}'", row.Cells["Recipient"].Value.ToString());
                        cargo.AircraftID = int.Parse(AvailableAircraftPick.Rows[e.RowIndex].Cells["Aircraft"].Value.ToString());
                        cargoEnRoute.AddCargo(cargo);
                        cargoTerminal.DeleteCargo(cargo.ID);
                    }
                }
                Aircraft aircraft = new Aircraft();
                string departureTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                string arrivalTime = DateTime.Now.AddMinutes(1).ToString("MM/dd/yyyy HH:mm");
                string returnTime = DateTime.Now.AddMinutes(2).ToString("MM/dd/yyyy HH:mm");
                aircraft.UpdateAvailabilityFalse(int.Parse(AvailableAircraftPick.Rows[e.RowIndex].Cells["Aircraft"].Value.ToString()), departureTime, arrivalTime, returnTime);
            }
            ActiveForm.Close();
        }
    }
}
