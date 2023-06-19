using System;
using System.Collections.Generic;
using SIS_MODEL;

namespace SIS_DATA
{
	public class InMemoryStudentPersonalInfo
	{
		public static List<StudentPersonalInfo> StudentPersonalInfos = new List<StudentPersonalInfo>();

		public InMemoryStudentPersonalInfo()
		{
			getListStudentPersonalInfo();
		}

		public List<StudentPersonalInfo> getList()
		{
			return StudentPersonalInfos;
		}

		public StudentPersonalInfo GetStudentPersonalInfoBySISAccountNumber(string sisAccountNumber)
		{
			return StudentPersonalInfos.FirstOrDefault(personal => personal.SISAccountNumber.Equals(sisAccountNumber));
		}

        public void AddStudentPersonalInfo(StudentPersonalInfo studentPersonalInfo)
        {
            StudentPersonalInfos.Add(studentPersonalInfo);
        }

        private void getListStudentPersonalInfo()
		{
			StudentPersonalInfo personal1 = new StudentPersonalInfo
			{
				SISAccountNumber = "2021-00066-BN-0",
				fullname = "Stephen Mathew C. Perez",
				Gender = "Male",
				DateofBirth = new DateTime(2002,5,9),
				placeofBirth = "Pangasinan",
				mobileNo = 09080000000,
				emailAddress = "xxxxx@gmail.com",
				residentialAddress = "Binan Laguna",
				permanentAdress = "San Pedro Laguna"
			};

            StudentPersonalInfo personal2 = new StudentPersonalInfo
            {
                SISAccountNumber = "2021-00428-BN-0",
                fullname = "Happy P. Enciso",
                Gender = "Female",
                DateofBirth = new DateTime(2003, 1, 8),
                placeofBirth = "Pangasinan",
                mobileNo = 0969000000,
                emailAddress = "xxxxx@gmail.com",
                residentialAddress = "Binan Laguna",
                permanentAdress = "San Pedro Laguna"
            };

            StudentPersonalInfos.Add(personal1);
            StudentPersonalInfos.Add(personal2);
        }
	}
}

