using System;
namespace SIS_MODEL
{
	public class StudentInfo 
	{
        public String fullName { get; set; }
        public String program { get; set; }
        public int year { get; set; }
        public int section { get; set; }
        public String studentNumber { get; set; }

        public StudentInfo(string fullName, string program, int year, int section, string studentNumber)
        {
            this.fullName = fullName;
            this.program = program;
            this.year = year;
            this.section = section;
            this.studentNumber = studentNumber;
        }

    }

}

