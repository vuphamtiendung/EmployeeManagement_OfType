using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OfTypeInLinQ_002
{
    internal class UserAction 
    {
        public List<Employee> listEmployee = new List<Employee>();

        public Employee employee = null;
        public FullTimeEmployee fulltimeemployee = null;
        public PartTimeEmployee parttimeemployee = null;

        public static UserAction useraction;
        public UserAction() { }
        public static UserAction GetUserAction()
        {
            if(useraction == null)
            {
                useraction = new UserAction();
            }
            return useraction;
        }

        public enum Options
        {
            CreateEmployee = 1,
            DisplayFullTimeEmployee = 2,
            DisplayPartTimeEmployee = 3,
            Exit = 4
        }

        public string InputInfo(string message)
        {
            WriteLine(message);
            return ReadLine();
        }

        public void Perform()
        {
            Options option;
            do
            {
                WriteLine(DisplayConstant.INPUT_EMPLOYEE_INFO);
                WriteLine(DisplayConstant.MENU_START);
                WriteLine(DisplayConstant.MENU_CREATE_EMPLOYEE);
                WriteLine(DisplayConstant.MENU_DISPLAY_FULLTIME);
                WriteLine(DisplayConstant.MENU_DISLAY_PARTTIME);
                WriteLine(DisplayConstant.MENU_EXIT);
                WriteLine(DisplayConstant.END_OF_PAGE_MESSAGE);

                Enum.TryParse(ReadLine(), out option);

                switch (option)
                {
                    case Options.CreateEmployee:
                        {
                            try
                            {
                                employee = employee ?? new Employee();
                                employee.CheckRole = Convert.ToBoolean(InputInfo(DisplayConstant.INPUT_ROLE));
                                if (employee.CheckRole == true)
                                {
                                    employee = new FullTimeEmployee();
                                }
                                else if (employee.CheckRole == false)
                                {
                                    employee = new PartTimeEmployee();
                                }
                                employee.InputEmployee();
                                listEmployee.Add(employee);
                            }
                            catch (Exception ex)
                            {
                                WriteLine(DisplayConstant.OUTPUT_ERROR_DEFINE);
                                WriteLine(ex.ToString());
                            }
                            break;
                        }
                    case Options.DisplayFullTimeEmployee:
                        {
                            var listFullTime = listEmployee.OfType<FullTimeEmployee>().ToList();
                            foreach(var list in listFullTime)
                            {
                                list.Display();
                                WriteLine();
                            }
                            break;
                        }
                    case Options.DisplayPartTimeEmployee:
                        {
                            var listPartTime = listEmployee.OfType<PartTimeEmployee>().ToList();
                            foreach(var list in listPartTime)
                            {
                                list.Display();
                                WriteLine();
                            }
                            break;
                        }
                    case Options.Exit:
                        {
                            WriteLine(DisplayConstant.OUTPUT_EXIT);
                            break;
                        }
                    default:
                        {
                            WriteLine(DisplayConstant.MENU_DONNOT_SUPPORT_FUNCTION);
                            break;
                        }
                }
            }
            while (option != Options.Exit);
        }
    }
}
