using System;
using SIS_UI;
using SIS_MODEL;
using SIS_DATA;
using AM_Rules;

namespace SIS_RULES
{
    public class StudentFormRules
	{
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
							case 2: break;
						}
						//PrintInfos.PrintStudentPersonalInfo(StudentForm.username);
						break;

					case 3: StudentForm.gradingSystem(); break;
					case 4: StudentForm.attendance(); break;
				}
			} while (status == null);
		}

       


    }
}

