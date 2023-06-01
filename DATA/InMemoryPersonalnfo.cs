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
            personalInfo.Add("2021-00182-BN-0", new PersonalInfo("Alliah Angel Llena Nacor", "Female", new DateTime(2003, 6, 29), "Taplacon Camalig, Albay", 09384580009, "angelnacor629@gmail.com", "BLK 7 Lot 3 St. Rose 2 Casile Biñan Laguna", "BLK 7 Lot 3 St. Rose 2 Casile Biñan Laguna"));
            personalInfo.Add("2021-00128-BN-0", new PersonalInfo("Happy Piamonte Enciso", "Female", new DateTime(2003, 1, 8), "Binan Laguna", 09691721355, "encisohappy@gmail.com", "Binan Laguna", "Faraon Subd. PH Escueta St. Brgy San Antonio Binan City Laguna"));
            personalInfo.Add("2021-00088-BN-0", new PersonalInfo("Catherine Lorraine Bundalian Odon", "Female", new DateTime(2002, 5, 23), "Lucena City", 09812038290, "cathlorrodon@gmail.com", "Blk 6 Lot 32 Brgy. Malamig, Biñan, Laguna", "Blk 6 Lot 32 Brgy. Malamig, Biñan, Laguna"));


        }
    }
}

