using System;
using SIS_UI;
using SIS_MODEL;
using SIS_DATA;
using AM_Rules;

namespace SIS_RULES
{
	public class FacultyFormRules
	{
		public static void actionFacultyWelcomePage()
		{
			int status;
			do
			{
				status = FacultyForm.facultyWelcomePage();
				switch (status)
				{
					case 0: break;
					case 1: break;
					case 2: break;
					case 3: break;
					case 4: break;
				}
			} while (status == null);
		}
	}
}

