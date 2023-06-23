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
								doUpdate();
								//status = StudentForm.actionUpdateStudentPersonalInfo();
								//switch (status)
								//{
								//	case 1:StudentForm.nonEditable(); break;
        //                            case 2: 
        //                            case 5: break;
        //                            case 6: break;
        //                            case 7: break;
        //                            case 8: break;
        //                            case 9: break;
        //                        }
								break;
						}
						//PrintInfos.PrintStudentPersonalInfo(StudentForm.username);
						break;

					case 3: StudentForm.gradingSystem(); break;
					case 4: StudentForm.attendance(); break;
				}
			} while (status == null);
		}

       public static void updatePersonalInfo(string sisAccountNumber)
		{
            //StudentPersonalInfo studentinfo = InMemoryStudentPersonalInfo.StudentPersonalInfos.FirstOrDefault(personal => personal.SISAccountNumber.Equals(sisAccountNumber));
            InMemoryStudentPersonalInfo personalinfo = new InMemoryStudentPersonalInfo();
            StudentPersonalInfo studentinfo = personalinfo.GetStudentPersonalInfoBySISAccountNumber(sisAccountNumber);

            if (studentinfo != null)
			{
                //StudentForm.updatePlaceOfBirth();
                string placeOfBirth = StudentForm.updatePlaceOfBirth();
                //StudentForm.updateContactNumber();
                long contactNumber = StudentForm.updateContactNumber();
                //StudentForm.updateEmailAddress();
                string emailAddress = StudentForm.updateEmailAddress();
                //StudentForm.updateResidentialAdd();
                string residentialAdd = StudentForm.updateResidentialAdd();
                //StudentForm.updatePermanentAdd();
                string permanentAdd = StudentForm.updatePermanentAdd();

                //updating

                studentinfo.placeofBirth = placeOfBirth;
				studentinfo.mobileNo = contactNumber;
				studentinfo.emailAddress = emailAddress;
				studentinfo.residentialAddress = residentialAdd;
				studentinfo.permanentAdress = permanentAdd;
            }

			

			StudentForm.successUpdate();
			Console.WriteLine("\nViewing Updated Student Personal Information:");

			PrintInfos.PrintStudentPersonalInfo(StudentForm.username);
			//PrintInfos.ViewStudentPersonalInfo();
		}

		public static void doUpdate()
		{
			string sisAccount = StudentForm.getSISAcc();
			updatePersonalInfo(sisAccount);
        }

		
        


    }
}

