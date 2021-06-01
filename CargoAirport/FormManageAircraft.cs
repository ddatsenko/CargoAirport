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
    public partial class FormManageAircraft : Form
    {
        public void LoadData()
        {
            Aircraft aircraft = new Aircraft();
            AvailableAircraftManage.DataSource = aircraft.LoadData_Available();
        }
        public FormManageAircraft()
        {
            InitializeComponent();
            AvailableAircraftManage.AutoGenerateColumns = false;
            LoadData();
        }

        private void buttonAddNewAircraft_Clicked(object sender, EventArgs e)
        {
            FormAddNewAircraft formAddNewAircraft = new FormAddNewAircraft();
            formAddNewAircraft.ShowDialog();
            LoadData();
        }

        private void buttonDeleteSelectedAircraft_Clicked(object sender, EventArgs e)
        {
            Aircraft aircraft = new Aircraft();
            foreach (DataGridViewRow row in AvailableAircraftManage.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string id = row.Cells["AircraftID"].Value.ToString();
                    aircraft.DeleteAircraft(int.Parse(id));
                }
            }
            AvailableAircraftManage.DataSource = aircraft.LoadData_Available();
        }
    }
}
