using System;
namespace MODEL
{
    public class PersonalInfo : User
    {
        
        public String Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public String placeofBirth { get; set; }
        public long mobileNo { get; set; }
        public String emailAddress { get; set; }
        public String residentialAddress { get; set; }
        public String permanentAdress { get; set; }

        public PersonalInfo(string fullName,string gender, DateTime dateofBirth, string placeofBirth, long mobileNo, string emailAddress, string residentialAddress, string permanentAdress) : base(fullName)
        {
            this.fullName = fullName;
            Gender = gender;
            DateofBirth = dateofBirth;
            this.placeofBirth = placeofBirth;
            this.mobileNo = mobileNo;
            this.emailAddress = emailAddress;
            this.residentialAddress = residentialAddress;
            this.permanentAdress = permanentAdress;
        }
    }
}

