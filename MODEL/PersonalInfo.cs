using System;
namespace MODEL
{
    public class PersonalInfo
    {
        public String fullname { get; set; }
        public String Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public String placeofBirth { get; set; }
        public long mobileNo { get; set; }
        public String emailAddress { get; set; }
        public String residentialAddress { get; set; }
        public String permanentAdress { get; set; }

        public PersonalInfo(string fullName,string Gender, DateTime dateofBirth, string placeofBirth, long mobileNo, string emailAddress, string residentialAddress, string permanentAdress)
        {
            this.fullname = fullName;
            this.Gender = Gender;
            this.DateofBirth = dateofBirth;
            this.placeofBirth = placeofBirth;
            this.mobileNo = mobileNo;
            this.emailAddress = emailAddress;
            this.residentialAddress = residentialAddress;
            this.permanentAdress = permanentAdress;
        }
    }
}

