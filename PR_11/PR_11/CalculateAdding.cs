using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    internal class CalculateAdding
    {
        int Employees;
        int AddEmployees;

        public CalculateAdding()
        {
            this.Employees = 100;
        }
        public void CalculateEmployees(int addEmployees)
        {
            this.AddEmployees = addEmployees;
        }
        public int CalculateCount()
        {
            int countEmployees = Employees + AddEmployees;
            return countEmployees;
        }
    }
}
