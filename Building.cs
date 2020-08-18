using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_w02
{
    class Building
    {
        private string code;
        private string name;
        private string lat;
        private string longitude;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public Building() { }
        public Building(string c, string n,  string la, string lo)
        {
            this.code = c;
            this.name = n;
            this.lat = la;
            this.longitude = lo;
            
        }
        public override string ToString()
        {
            return this.Code + " " +
                 this.Name + " " +
                 this.Lat + " " +
                 this.Longitude;

        }
    }
}
