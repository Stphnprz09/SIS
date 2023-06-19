using System;
using System.Collections.Generic;
using SIS_MODEL;

namespace SIS_DATA
{
	public class InMemoryStudentInfo
	{
		public static List<StudentInfo> StudentInfos = new List<StudentInfo>();

		public InMemoryStudentInfo()
		{ getListStudentInfo(); }

		public List<StudentInfo> getList()
		{ return StudentInfos; }

        public StudentInfo GetStudentInfoBySISAccountNumber(string sisAccountNumber)
        {
            return StudentInfos.FirstOrDefault(student => student.SISAccountNumber.Equals(sisAccountNumber));
        }


        private void getListStudentInfo()
        {
			StudentInfo student1 = new StudentInfo
			{
				SISAccountNumber = "2021-00066-BN-0",
				fullName = "Stephen Mathew C. Perez",
				course = "BSIT",
				year = 2,
				section = 1
			};

            StudentInfo student2 = new StudentInfo
            {
                SISAccountNumber = "2021-00428-BN-0",
                fullName = "Happy P. Enciso",
                course = "BSIT",
                year = 2,
                section = 1
            };

            StudentInfos.Add(student1);
            StudentInfos.Add(student2);
        }
    }
}

