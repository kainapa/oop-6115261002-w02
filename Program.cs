using System;

namespace oop_6115261002_w02
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r434 = new Room("434", "434", 4, 4, "Computer");
            Building b4 = new Building("333", "kainapa", "354", "564");
            Section s6 = new Section("648", "rgw", "rher", "ee", "5", "8.00am", "12.00");
            Subject tee = new Subject("545", "euf", "1", "5", "2");
            Group ser1 = new Group("hyf", "bachelor");
            Lecturer qwe = new Lecturer("dfwei", "eof", "sfieh");
            Console.WriteLine(qwe);
            Console.WriteLine(ser1);
            Console.WriteLine(tee);
            Console.WriteLine(s6);
            Console.WriteLine(r434);
            Console.WriteLine(b4);
        }
    }
}
