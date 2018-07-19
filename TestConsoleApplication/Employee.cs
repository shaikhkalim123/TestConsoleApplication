using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Employee
    {
        private int empCode;

        public int EmpCode
        {
            get { return empCode; }
            set { empCode = value; }
        }


        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

    }
}
