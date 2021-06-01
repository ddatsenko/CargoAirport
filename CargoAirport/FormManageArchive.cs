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
    public partial class FormManageArchive : Form
    {
        public FormManageArchive()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData ()
        {
            CargoArchive cargoArchive = new CargoArchive();
            ArchiveCargoList.DataSource = cargoArchive.LoadData();
        }

        private void ButtonDeleteSelectedCargo_Click(object sender, EventArgs e)
        {
            CargoArchive cargoArchive = new CargoArchive();
            foreach (DataGridViewRow row in ArchiveCargoList.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string id = row.Cells["ID"].Value.ToString();
                    cargoArchive.DeleteCargo(int.Parse(id));
                }
            }
            LoadData();
        }
    }
}
