using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoAirport
{
    class Cargo
    {
        private int id;
        private string destination;
        private int mass;
        private int volume;
        private string type;
        private string sender;
        private string recipient;
        private int aircraftID;
        private string shippingTime;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public int Mass
        {
            get { return mass; }
            set { mass = value; }
        }
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        public string Recipient
        {
            get { return recipient; }
            set { recipient = value; }
        }
        public int AircraftID
        {
            get { return aircraftID; }
            set { aircraftID = value; }
        }
        public string ShippingTime
        {
            get { return shippingTime; }
            set { shippingTime = value; }
        }

        public Cargo() { }
        public Cargo (int id, string dest, int m, int v, string t, string send, string rec)
        {
            ID = id;
            Destination = dest;
            Mass = m;
            Volume = v;
            Type = t;
            Sender = send;
            Recipient = rec;
            AircraftID = -1;
            ShippingTime = "";
        }
        public Cargo(int id, string dest, int m, int v, string t, string send, string rec, int aircID)
        {
            ID = id;
            Destination = dest;
            Mass = m;
            Volume = v;
            Type = t;
            Sender = send;
            Recipient = rec;
            AircraftID = aircID;
            ShippingTime = "";
        }
        public Cargo(int id, string dest, int m, int v, string t, string send, string rec, int aircID, string sTime)
        {
            ID = id;
            Destination = dest;
            Mass = m;
            Volume = v;
            Type = t;
            Sender = send;
            Recipient = rec;
            AircraftID = aircID;
            ShippingTime = sTime;
        }
    }
}
