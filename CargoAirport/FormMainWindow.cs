using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace CargoAirport
{
    public partial class FormMainWindow : Form
    {
        //Method for generating an ID for a new cargo to register
        public FormMainWindow()
        {
            InitializeComponent();
            LoadData();
            AircraftStatusCheck();
            LoadData();
        }

        //Updating status of the flights that have finished delivering previous cargo
        private void AircraftStatusCheck()
        {
            Aircraft aircraft = new Aircraft();
            DateTime dateTime = DateTime.Now;
            foreach (DataGridViewRow row in AircraftList.Rows)
            {
                if (row.Cells["Availability"].Value.ToString() == "False")
                {
                    if (DateTime.ParseExact(row.Cells["ReturnTime"].Value.ToString(), "MM/dd/yyyy HH:mm", null) <= DateTime.Now)
                    {
                        string arrivalTime = string.Format("'{0}'", row.Cells["ReturnTime"].Value.ToString());
                        foreach (DataGridViewRow rowEnRoute in EnRouteCargoList.Rows)
                        {
                            if (rowEnRoute.Cells["AssignedAircraftID"].Value.ToString() == row.Cells["AircraftID"].Value.ToString())
                            {
                                Cargo cargo = new Cargo();
                                cargo.ID = int.Parse(rowEnRoute.Cells["EnRouteID"].Value.ToString());
                                cargo.Destination = string.Format("'{0}'", rowEnRoute.Cells["EnRouteDestination"].Value.ToString());
                                cargo.Mass = int.Parse(rowEnRoute.Cells["EnRouteMass"].Value.ToString());
                                cargo.Volume = int.Parse(rowEnRoute.Cells["EnRouteVolume"].Value.ToString());
                                cargo.Type = string.Format("'{0}'", rowEnRoute.Cells["EnRouteType"].Value.ToString());
                                cargo.Sender = string.Format("'{0}'", rowEnRoute.Cells["EnRouteSender"].Value.ToString());
                                cargo.Recipient = string.Format("'{0}'", rowEnRoute.Cells["EnRouteRecipient"].Value.ToString());
                                cargo.AircraftID = int.Parse(rowEnRoute.Cells["AssignedAircraftID"].Value.ToString());
                                cargo.ShippingTime = arrivalTime;
                                CargoArchive cargoArchive = new CargoArchive();
                                cargoArchive.AddCargo(cargo);
                                CargoEnRoute cargoEnRoute = new CargoEnRoute();
                                cargoEnRoute.DeleteCargo(int.Parse(rowEnRoute.Cells["EnRouteID"].Value.ToString()));
                            }
                        }
                        aircraft.UpdateAvailabilityTrue(int.Parse(row.Cells["AircraftID"].Value.ToString()));
                    }
                }
            }
        }

        //Method for loading/updatein data into DataGridViews of the Main screen
        private void LoadData()
        {
            //Loading list of cargo stored in terminal
            CargoTerminal cargoTerminal = new CargoTerminal();
            TerminalCargoList.DataSource = cargoTerminal.LoadData();

            //Loading list of cargo that is being transported
            CargoEnRoute cargoEnRoute = new CargoEnRoute();
            EnRouteCargoList.DataSource = cargoEnRoute.LoadData();

            //Loading list of aircraft, updating their status
            //with regard to the time of their flight
            Aircraft aircraft = new Aircraft();
            AircraftList.AutoGenerateColumns = false;
            AircraftList.DataSource = aircraft.LoadData();
        }

        private void buttonRefresh_Click (object sender, EventArgs e)
        {
            LoadData();
            AircraftStatusCheck();
            LoadData();

        }

        private void buttonDeleteSelected_Clicked(object sender, EventArgs e)
        {
            CargoTerminal cargoTerminal = new CargoTerminal();
            foreach (DataGridViewRow row in TerminalCargoList.Rows) {
                if (row.Cells[0].Value != null)
                {
                    string id = row.Cells["ID"].Value.ToString();
                    cargoTerminal.DeleteCargo(int.Parse(id));
                }
            }
            AircraftStatusCheck();
            LoadData();
        }

        private void buttonAddNewCargo_Clicked(object sender, EventArgs e)
        {
            FormAddNewCargo form = new FormAddNewCargo();
            form.ShowDialog();
            AircraftStatusCheck();
            LoadData();
        }

        private void buttonSendToLoad_Clicked(object sender, EventArgs e)
        {
            CargoTerminal cargoTerminal = new CargoTerminal();
            int mass = 0;
            int volume = 0;
            foreach (DataGridViewRow row in TerminalCargoList.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    mass += int.Parse(row.Cells["Mass"].Value.ToString());
                    volume += int.Parse(row.Cells["Volume"].Value.ToString());
                }
            }

            Aircraft aircraft = new Aircraft();
            if (aircraft.AvailableCount(mass, volume) > 0)
            {
                DataTable aircraftAvailable = aircraft.LoadData_Available(mass, volume);
                FormSendToLoading formSendToLoading = new FormSendToLoading(aircraftAvailable, TerminalCargoList);
                formSendToLoading.ShowDialog();
                AircraftStatusCheck();
                LoadData();
            }
            else
            {
                MessageBox.Show("There is no available aircraft to carry out this delivery. Check the limits or availability status of aircraft", "No aircraft available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AircraftStatusCheck();
                LoadData();
            }
        }

        private void buttonManageAircraft_Clicked(object sender, EventArgs e)
        {
            FormManageAircraft formManageAircraft = new FormManageAircraft();
            formManageAircraft.ShowDialog();
            AircraftStatusCheck();
            LoadData();

        }

        private void buttonManageArchive_Clicked(object sender, EventArgs e)
        {
            FormManageArchive formManageArchive = new FormManageArchive();
            formManageArchive.ShowDialog();
            AircraftStatusCheck();
            LoadData();

        }
    }
}
