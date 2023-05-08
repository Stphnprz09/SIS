using System;
namespace SIS
{
	public class PersonalInformation
	{
		private string firstName, middleName, lastName, course, address, schoolEmail,personalEmail,studentNumber;
		private int yearLevel, section, contactNumber;

		//fields
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}

