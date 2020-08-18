using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_w02
{
    class Subject
    {
        private string code;
        private string name;
        private string credit;
        private string describe;
        private string practice;
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
        public string Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        
        public string Describe
        {
            get { return describe; }
            set { describe = value; }
        }
        
        public string Practice
        {
            get { return practice; }
            set { practice = value; }
        }
        public Subject() { }
        public Subject(string c, string n, string cr, string d, string p)
        {
            this.code = c;
            this.name = n;
            this.credit = cr;
            this.describe = d;
            this.practice = p;
        }
        public override string ToString()
        {
            return this.Code + " " +
                 this.Name + " " +
                 this.Credit + " " +
                 this.Describe + " " +
                 this.Practice;

        }

    }
    }

