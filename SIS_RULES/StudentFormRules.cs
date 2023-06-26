using System;
using SIS_UI;
using SIS_MODEL;
using SIS_DATA;
using AM_Rules;

namespace SIS_RULES
{
    public class StudentFormRules
	{
		public static string sisAccoutNumber;
        public static InMemoryStudentPersonalInfo personalinfo = new InMemoryStudentPersonalInfo();

        public static void actionStudentWelcomePage()
		{

			int status;
			int action;
            do
			{
				status = StudentForm.studentWelcomePage();
				switch (status)
				{
					case 0: break;
					case 1: //student information
                        PrintInfos.PrintStudentInfo(StudentForm.username);
                        break;

					case 2: //personal information
						status = StudentForm.actionStudentPersonalInfo();
						switch (status)
						{
							case 0: break;
							case 1:
								PrintInfos.PrintStudentPersonalInfo(StudentForm.username);
								break;
							case 2:
								//doUpdate();
								action = StudentForm.actionUpdateStudentPersonalInfo();
								switch (action)
								{
									//cancel
									case 0: break;
									//SIS Account
                                    case 1: StudentForm.nonEditable();break;
									//Name
                                    case 2: StudentForm.nonEditable(); break;
									//Gender
                                    case 3: StudentForm.nonEditable(); break;
									//Date Of Birth
                                    case 4: StudentForm.nonEditable(); break;
									//Place Of Birth
                                    case 5: doUpdatePOB(); break;
									//Mobile Number
                                    case 6: doUpdateMobile(); break;
									//Email Address
                                    case 7: doUpdateEmailAddress(); break;
									//Residential Add
                                    case 8: doUpdateResidentialAddress(); break;
									//Permanent Add
                                    case 9: doUpdatePermanentAddress(); break;

                                }
								
								break;
						}
						break;

					case 3: StudentForm.gradingSystem(); break;
					case 4: StudentForm.attendance(); break;
				}
			} while (status == null);
		}


        //Update Place of Birth
		public static void updatePlaceOfBirth(string sisAccountNumber)
		{
            InMemoryStudentPersonalInfo personalinfo = new InMemoryStudentPersonalInfo();
            StudentPersonalInfo studentinfo = personalinfo.GetStudentPersonalInfoBySISAccountNumber(sisAccountNumber);

            string placeOfBirth = StudentForm.updatePlaceOfBirth();

            studentinfo.placeofBirth = placeOfBirth;

            StudentForm.successUpdate();
        }

        public static void doUpdatePOB()
        {
            string sisAccount = StudentForm.getSISAcc();
            updatePlaceOfBirth(sisAccount);
        }


        //Update MObile Number
        public static void updateMobileNumber(string sisAccountNumber)
        {
            InMemoryStudentPersonalInfo personalinfo = new InMemoryStudentPersonalInfo();
            StudentPersonalInfo studentinfo = personalinfo.GetStudentPersonalInfoBySISAccountNumber(sisAccountNumber);

            long mobileNumber = StudentForm.updateContactNumber();

            studentinfo.mobileNo = mobileNumber;

            StudentForm.successUpdate();
        }

        public static void doUpdateMobile()
        {
            string sisAccount = StudentForm.getSISAcc();
            updateMobileNumber(sisAccount);
        }

        //Update Email Address
        public static void updateEmailAdd(string sisAccountNumber)
        {
            InMemoryStudentPersonalInfo personalinfo = new InMemoryStudentPersonalInfo();
            StudentPersonalInfo studentinfo = personalinfo.GetStudentPersonalInfoBySISAccountNumber(sisAccountNumber);

            string emailAddress = StudentForm.updateEmailAddress();

            studentinfo.emailAddress = emailAddress;

            StudentForm.successUpdate();
        }

        public static void doUpdateEmailAddress()
        {
            string sisAccount = StudentForm.getSISAcc();
            updateEmailAdd(sisAccount);
        }


        //Update Residential Address
        public static void updateResidentialAdd(string sisAccountNumber)
        {
            InMemoryStudentPersonalInfo personalinfo = new InMemoryStudentPersonalInfo();
            StudentPersonalInfo studentinfo = personalinfo.GetStudentPersonalInfoBySISAccountNumber(sisAccountNumber);

            string residentialAddress = StudentForm.updateResidentialAdd();

            studentinfo.residentialAddress = residentialAddress;

            StudentForm.successUpdate();
        }

        public static void doUpdateResidentialAddress()
        {
            string sisAccount = StudentForm.getSISAcc();
            updateResidentialAdd(sisAccount);
        }

        //Update Permanent Address
        public static void updatePermanentAdd(string sisAccountNumber)
        {
            InMemoryStudentPersonalInfo personalinfo = new InMemoryStudentPersonalInfo();
            StudentPersonalInfo studentinfo = personalinfo.GetStudentPersonalInfoBySISAccountNumber(sisAccountNumber);

            string permanentAddress = StudentForm.updatePermanentAdd();

            studentinfo.residentialAddress = permanentAddress;

            StudentForm.successUpdate();
        }

        public static void doUpdatePermanentAddress()
        {
            string sisAccount = StudentForm.getSISAcc();
            updatePermanentAdd(sisAccount);
        }

        




    }
}

