using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_w02
{
    class Section
    {
        private string room;
        private string building;
        private string subject;
        private string instructor;
        private string day;
        private string begin;
        private string end;
        public string Room
        {
            get { return room; }
            set { room = value; }
        }
        public string Building
        {
            get { return building; }
            set { building = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Begin
        {
            get { return begin; }
            set { begin = value; }
         
        }
        public string End
        {
            get { return end; }
            set { end = value; }
         
        }
       
        public Section() { }
        public Section(string r, string b, string s, string i, string d, string be, string e)
        {
            this.room = r;
            this.building = b;
            this.subject = s;
            this.instructor = i;
            this.day = d;
            this.begin = be;
            this.end = e;
        }
        public override string ToString()
        {
            return this.Room + " " +
                 this.Building + " " +
                 this.Subject + " " +
                 this.Instructor + " " +
                 this.Day + " " +
                 this.Begin + " " +
                 this.End;

        }
    }
}

