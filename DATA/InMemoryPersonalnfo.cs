using System;
using MODEL;
using System.Collections.Generic;

namespace DATA
{
	public class InMemoryPersonalnfo
	{
        public Dictionary<string, PersonalInfo> personalInfo = new Dictionary<string, PersonalInfo>();

        public void studentPersonalInfo()
        {
            personalInfo.Add("2021-00066-BN-0", new PersonalInfo("Stephen Mathew C. Perez", "Male", new DateTime(2002, 5, 9), "Pangasinan", 0908484441, "abcd@gmail.com", "Laguna", "Laguna"));
        }
    }
}

