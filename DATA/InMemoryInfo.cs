using System;
using MODEL;

namespace DATA
{
	public class InMemoryInfo
	{
		public Dictionary<string, Student> studentInfo = new Dictionary<string, Student>();

        public void infos()
		{
            studentInfo.Add("2021-00066-BN-0", new Student("Stephen Mathew C. Perez","BSIT",2,1,SISType.Student));
            studentInfo.Add("2021-00148-BN-0", new Student("Happy Enciso", "BSIT", 2, 1, SISType.Student));
            studentInfo.Add("2021-00000-BN-0", new Student("Happy Enciso", "BSIT", 2, 1, SISType.Faculty));
        }
    }
}

