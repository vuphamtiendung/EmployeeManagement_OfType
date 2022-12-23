using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OfTypeInLinQ_002
{
    internal class Employee
    {
        private double _codeStaff;
        private string _nameStaff;
        private string _possition;
        private bool _checkRole;
        private DateTime _onboardDay;

        public double CodeStaff { get { return _codeStaff; } set { _codeStaff = value; } }
        public string NameStaff { get { return _nameStaff;} set { _nameStaff = value; } }   
        public string Possition { get { return _possition; } set { _possition = value; } }
        public bool CheckRole { get { return _checkRole;} set { if (_checkRole == true || _checkRole == false) { _checkRole = value; } } } 
        public DateTime OnboardDay { get { return _onboardDay; } set { _onboardDay = value; } } 

        public Employee()
        {
            _codeStaff = 0;
            _nameStaff = "";
            _possition = "";
            _onboardDay = DateTime.Now;
        }

        public Employee(double codeStaff, string nameStaff, string possition, DateTime onboardDay)
        {
            _codeStaff = codeStaff;
            _nameStaff = nameStaff;
            _possition = possition;
            _onboardDay = onboardDay;
        }

        public virtual double Salary() => 9000000;
        public string InputInfo(string message)
        {
            WriteLine(message);
            return ReadLine();
        }
        public virtual void InputEmployee()
        {
            _codeStaff = Convert.ToDouble(InputInfo(DisplayConstant.INPUT_CODESTAFF));
            _nameStaff = InputInfo(DisplayConstant.INPUT_NAMESTAFF);
            _possition = InputInfo(DisplayConstant.INPUT_POSSITION);
            _onboardDay = Convert.ToDateTime(InputInfo(DisplayConstant.INPUT_ONBOARDDAY));
        }
        public virtual void Display()
        {
            WriteLine(DisplayConstant.OUTPUT_CODESTAFF, _codeStaff);
            WriteLine(DisplayConstant.OUTPUT_NAMESTAFF, _nameStaff);
            WriteLine(DisplayConstant.OUTPUT_POSSITION, _possition);
            WriteLine(DisplayConstant.OUTPUT_ONBOARDDAY, _onboardDay);
            WriteLine(DisplayConstant.OUTPUT_SALARY_EMPLOYEE, Salary());
        }
    }
}
