namespace Adapter
{
    public class SAPSystem
    {
        public string[][] GetEmployees()
        {
            var employees = new string[4][];

            employees[0] = new[] { "ID", "Name", "Position" };
            employees[1] = new[] { "101", "Rohit", "Developer" };
            employees[2] = new[] { "102", "Gautam", "Developer" };
            employees[3] = new[] { "103", "Dev", "Tester" };

            return employees;
        }
    }
}