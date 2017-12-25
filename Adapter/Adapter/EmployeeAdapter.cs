using System.Collections.Generic;

namespace Adapter
{
    public class EmployeeAdapter : SAPSystem, ITarget
    {
        public IEnumerable<string> GetEmployeeList()
        {
            var employeeList = new List<string>();

            // get data from the SAP
            var employees = GetEmployees();

            // convert string into list
            foreach (var employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(AddSpaces(employee[0].Length, 5));
                employeeList.Add("| ");
                employeeList.Add(employee[1]);
                employeeList.Add(AddSpaces(employee[1].Length, 10));
                employeeList.Add("| ");
                employeeList.Add(employee[2]);
                employeeList.Add(AddSpaces(employee[2].Length, 20));
                employeeList.Add("\n");
            }

            // return list for third party tool
            return employeeList;
        }

        private string AddSpaces(int charsInColumn, int maxLength)
        {
            var result = "";

            for (var i = charsInColumn; i < maxLength; i++) result += " ";

            return result;
        }
    }
}