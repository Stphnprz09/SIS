using System;
using System.Collections.Generic;


namespace MODEL
{
    public class Student
    {
        //public List<string> studentInfo = new List<string>();

        public String fullname { get; set; }
        public String program { get; set; }
        public int year { get; set; }
        public int section { get; set; }
        public SISType type { get; set; }

        public Student(string fullName, string program, int year, int section,SISType type)
        {
            this.fullname = fullName;
            this.program = program;
            this.year = year;
            this.section = section;
            this.type = type;
        }
    }
}

