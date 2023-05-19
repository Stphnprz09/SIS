using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace SIS_MODEL
{
	public class StudentInformation
	{
		//studentNumber, Name, Gender, dateofBirth, placeofBirth, mobileNo, emailAdrress, residentialAddress, permanentAddress

		public string studentNumber { get; set; }
		public String Name { get; set; }
		public String Gender { get; set; }
		public DateTime DateofBirth { get; set; }
		public String placeofBirth { get; set; }	
		public int mobileNo { get; set; }
		public String emailAddress { get; set; }
		public String residentialAddress { get; set; }
		public String permanentAdress { get; set; }

		public StudentInformation(string studentNumber, string Name, string Gender, DateTime dateOfBirth, string placeOfBirth, int mobileNo, string emailAddress, string residentialAddress, string permanentaddress)
		{
			this.studentNumber = studentNumber;
			this.Name = Name;
			this.Gender = Gender;
			this.DateofBirth = dateOfBirth;
			this.placeofBirth = placeOfBirth;
			this.mobileNo = mobileNo;
			this.emailAddress = emailAddress;
			this.residentialAddress = residentialAddress;
			this.permanentAdress = permanentaddress;
			

		}
	}
}


