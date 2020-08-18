using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_w02
{
    class Lecturer
    {
        private string name;
        private string lastname;
        private string position;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public Lecturer() { }
        public Lecturer(string n, string l, string p)
        {
            this.Name = n;
            this.lastname = l;
            this.position = p;

        }
        public override string ToString()
        {
            return this.Name + " " +
                this.Lastname + " " +
                 this.Position;
        }
    }
}
