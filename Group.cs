using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_w02
{
    class Group
    {
        private string groupname;
        private string degree;
       
        public string Groupname
        {
            get { return groupname; }
            set { groupname = value; }
        }
        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        

        public Group() { }
        public Group(string g, string d)
        {
            this.groupname = g;
            this.degree = d;
            
        }
        public override string ToString()
        {
            return this.Groupname + " " +
                 this.Degree;
                

        }
    }
}
