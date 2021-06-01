using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace CargoAirport
{
    abstract class CargoStorage
    {

        public abstract void AddCargo(Cargo cargo);
        public abstract void DeleteCargo(int ID);
        public abstract DataTable LoadData();
        public abstract int FindMaxCargoID();

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
        public static int CargoCount(string sqlite_table)
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
    }

    class CargoTerminal : CargoStorage
    {
        string sqlite_table = "'Terminal'";

        public override void AddCargo(Cargo cargo)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format("INSERT INTO {0} (ID, Destination, Mass, Volume, Type, Sender, Recipient) VALUES({1}, {2}, {3}, {4}, {5}, {6}, {7});",sqlite_table, cargo.ID, cargo.Destination, cargo.Mass, cargo.Volume, cargo.Type, cargo.Sender, cargo.Recipient);
            sqlite_cmd.ExecuteNonQuery();
        }

        public override void DeleteCargo(int ID)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format(string.Format("DELETE FROM {0} WHERE ID = {1}", sqlite_table, ID));
            sqlite_cmd.ExecuteNonQuery();
        }

        public override DataTable LoadData()
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteDataAdapter sqlite_ad = new SQLiteDataAdapter(string.Format("Select * FROM {0}", sqlite_table), sqlite_conn);
            DataTable CargoDT = new DataTable();
            sqlite_ad.Fill(CargoDT);
            return CargoDT;
        }

        public override int FindMaxCargoID()
        {
            int maxID = 0;
            if (CargoCount(sqlite_table) > 0)
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
    }

    class CargoEnRoute : CargoStorage
    {
        string sqlite_table = "'EnRoute'";

        public override void AddCargo(Cargo cargo)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format("INSERT INTO EnRoute (ID, Destination, Mass, Volume, Type, Sender, Recipient, AircraftID) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7});", cargo.ID, cargo.Destination, cargo.Mass, cargo.Volume, cargo.Type, cargo.Sender, cargo.Recipient, cargo.AircraftID);
            sqlite_cmd.ExecuteNonQuery();
        }

        public override void DeleteCargo(int ID)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format(string.Format("DELETE FROM {0} WHERE ID = {1}", sqlite_table, ID));
            sqlite_cmd.ExecuteNonQuery();
        }

        public override DataTable LoadData()
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteDataAdapter sqlite_ad = new SQLiteDataAdapter(string.Format("Select * FROM {0}", sqlite_table), sqlite_conn);
            DataTable CargoDT = new DataTable();
            sqlite_ad.Fill(CargoDT);
            CargoDT.Columns["AircraftID"].SetOrdinal(0);
            return CargoDT;
        }

        public override int FindMaxCargoID()
        {
            int maxID = 0;
            if (CargoCount(sqlite_table) > 0)
            {
                SQLiteConnection sqlite_conn = CreateConnection();
                SQLiteCommand sqlite_cmd = new SQLiteCommand(string.Format("SELECT MAX(ID) FROM {0}", sqlite_table), sqlite_conn);
                {
                    SQLiteDataReader dataReader = sqlite_cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        maxID = int.Parse(dataReader.GetValue(0).ToString());
                    }
                }
            }
            return maxID;
        }
    }

    class CargoArchive : CargoStorage
    {
        string sqlite_table = "'Archive'";
        public override void AddCargo(Cargo cargo)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format("INSERT INTO Archive (ID, Destination, Mass, Volume, Type, Sender, Recipient, AircraftID, ShippingTime) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8});", cargo.ID, cargo.Destination, cargo.Mass, cargo.Volume, cargo.Type, cargo.Sender, cargo.Recipient, cargo.AircraftID, cargo.ShippingTime);
            sqlite_cmd.ExecuteNonQuery();
        }

        public override void DeleteCargo(int ID)
        {
            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format(string.Format("DELETE FROM {0} WHERE ID = {1}", sqlite_table, ID));
            sqlite_cmd.ExecuteNonQuery();
        }

        public override DataTable LoadData()
        {

            SQLiteConnection sqlite_conn = CreateConnection();
            SQLiteDataAdapter sqlite_ad = new SQLiteDataAdapter(string.Format("Select * FROM {0}", sqlite_table), sqlite_conn);
            DataTable CargoDT = new DataTable();
            sqlite_ad.Fill(CargoDT);
            return CargoDT;
        }

        public override int FindMaxCargoID()
        {
            int maxID = 0;
            if (CargoCount(sqlite_table) > 0)
            {
                SQLiteConnection sqlite_conn = CreateConnection();
                SQLiteCommand sqlite_cmd = new SQLiteCommand(string.Format("SELECT MAX(ID) FROM {0}", sqlite_table), sqlite_conn);
                {
                    SQLiteDataReader dataReader = sqlite_cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        maxID = int.Parse(dataReader.GetValue(0).ToString());
                    }
                }
            }
            return maxID;
        }
    }
}
