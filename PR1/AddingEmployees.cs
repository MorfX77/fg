using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    internal class AddingEmployees
    {
        int Employees;
        int AddEmployees;

        public AddingEmployees()
        {
            this.Employees = 100;
        }
        public void PenisEmployees(int addEmployees) 
        {
            this.AddEmployees = addEmployees;
        }
        public int CalculateAdding() 
        {
            int countEmployees = Employees + AddEmployees;
            return countEmployees;
        }
    }
}
