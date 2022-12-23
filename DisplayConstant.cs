using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OfTypeInLinQ_002
{
    internal class DisplayConstant
    {
        public const string INPUT_EMPLOYEE_INFO = "======================== Employee Info =======================";

        public const string INPUT_ROLE = "Please entry role of the employee - 'true' => full time employee - 'false' => part time employee: ";
        public const string INPUT_CODESTAFF = "Please entry code staff: ";
        public const string INPUT_NAMESTAFF = "Please entry name staff: ";
        public const string INPUT_POSSITION = "Please entry possition of the staff: ";
        public const string INPUT_ONBOARDDAY = "Please entry onboard day of the staff: ";

        public const string OUTPUT_CODESTAFF = "Code staff: {0}";
        public const string OUTPUT_NAMESTAFF = "Name staff: {0}";
        public const string OUTPUT_POSSITION = "Possition of the staff: {0}";
        public const string OUTPUT_ONBOARDDAY = "Onboard day of the staff: {0}";
        public const string OUTPUT_CHECK_FULLTIME = "Role of the staff: {0}";
        public const string OUTPUT_SALARY_EMPLOYEE = "Salary of the employee: {0}";
        public const string OUTPUT_ERROR_ROLE = "You have to input true role of the employee. only 'true' or 'false'";
        public const string OUTPUT_ERROR_DEFINE = "You have to input true define on any field";
        public const string OUTPUT_EXIT = "Goodbye, see you later!";

        public const string MENU_START = "Please choice function";
        public const string MENU_CREATE_EMPLOYEE = "1. Create employee fulltime";
        public const string MENU_DISPLAY_FULLTIME = "2. Display employee fulltime";
        public const string MENU_DISLAY_PARTTIME = "3. Display employee parttime";
        public const string MENU_EXIT = "4. Exit system!";
        public const string MENU_DONNOT_SUPPORT_FUNCTION = "System don't support this function!";

        public const string END_OF_PAGE_MESSAGE = "====================== End Of page message ===================";
    }
}
