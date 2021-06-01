using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoAirport
{
    class Aircraft
    {
        string sqlite_table = "'Aircraft'";
        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source = ..\\..\\..\\Cargo.db");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            { }
            return sqlite_conn;
        }

        public DataTable LoadData()
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteDataAdapter sqlite_ad = new SQLiteDataAdapter(string.Format("Select * FROM {0}", sqlite_table), sqlite_conn);
            DataTable AircraftDT = new DataTable();
            sqlite_ad.Fill(AircraftDT);
            DataColumn columnStatus = AircraftDT.Columns.Add("Status", System.Type.GetType("System.String"));
            columnStatus.SetOrdinal(3);
            foreach (DataRow row in AircraftDT.Rows)
            {
                if (row["Availability"].ToString() == "True")
                {
                    row["Status"] = "Available";
                }
                else
                {
                    row["Status"] = "En Route";
                }
            }
            return AircraftDT;
        }
        public int AircraftCount()
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = new SQLiteCommand(string.Format("SELECT COUNT(*) FROM {0}", sqlite_table), sqlite_conn);
            SQLiteDataReader dataReader = sqlite_cmd.ExecuteReader();
            int count = 0;
            while (dataReader.Read())
            {
                count = int.Parse(dataReader.GetValue(0).ToString());
            }
            return count;
        }

        public int FindMaxAircraftID()
        {
            int maxID = 0;
            if (AircraftCount() > 0)
            {
                SQLiteConnection sqlite_conn = CreateConnection();
                SQLiteCommand sqlite_cmd = new SQLiteCommand(string.Format("SELECT MAX(ID) FROM {0}", sqlite_table), sqlite_conn);
                SQLiteDataReader dataReader = sqlite_cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    maxID = int.Parse(dataReader.GetValue(0).ToString());
                }
            }
            return maxID;
        }

        public void AddAircraft(int aircraftID, string model, int mass, int volume)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format("INSERT INTO {0} (ID, Model, MassAllowed, VolumeAllowed, Availability) VALUES({1}, {2}, {3}, {4}, True);", sqlite_table, aircraftID, model, mass, volume);
            sqlite_cmd.ExecuteNonQuery();
        }

        public void DeleteAircraft(int ID)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format(string.Format("DELETE FROM {0} WHERE ID = {1}", sqlite_table, ID));
            sqlite_cmd.ExecuteNonQuery();
        }

        public int AvailableCount(int mass, int volume)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = new SQLiteCommand(string.Format("SELECT COUNT(*) FROM {0} WHERE Availability = True AND MassAllowed >= {1} AND VolumeAllowed >= {2}", sqlite_table, mass, volume), sqlite_conn);
            SQLiteDataReader dataReader = sqlite_cmd.ExecuteReader();
            int count = -1;
            while (dataReader.Read())
            {
                count = int.Parse(dataReader.GetValue(0).ToString());
            }
            return count;
        }

        public DataTable LoadData_Available()
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteDataAdapter sqlite_ad = new SQLiteDataAdapter(string.Format("Select * FROM Aircraft WHERE Availability = True", sqlite_table), sqlite_conn);
            DataTable AircraftDT = new DataTable();
            sqlite_ad.Fill(AircraftDT);
            return AircraftDT;
        }

        public DataTable LoadData_Available(int mass, int volume)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteDataAdapter sqlite_ad = new SQLiteDataAdapter(string.Format("Select * FROM Aircraft WHERE Availability = True AND MassAllowed >= {0} AND VolumeAllowed >= {1}", mass, volume), sqlite_conn);
            DataTable AircraftDT = new DataTable();
            sqlite_ad.Fill(AircraftDT);
            return AircraftDT;
        }

        public void UpdateAvailabilityFalse(int ID, string departureTime, string arrivalTime, string returnTime)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd;
            Console.WriteLine(ID);
            string Createsql = string.Format("UPDATE Aircraft SET Availability = False, DepartureTime = '{0}', ArrivalTime = '{1}', ReturnTime = '{2}' WHERE ID = '{3}'", departureTime, arrivalTime, returnTime, ID);
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }

        public void UpdateAvailabilityTrue(int ID)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd;
            string Createsql = string.Format("UPDATE Aircraft SET Availability = True, DepartureTime = '', ArrivalTime = '', ReturnTime = '' WHERE ID = '{0}'", ID);
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }
    }
}
