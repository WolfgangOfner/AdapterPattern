using System;

namespace Adapter
{
    public class FancyReportingTool
    {
        private readonly ITarget _employeeSource;

        public FancyReportingTool(ITarget employeeSource)
        {
            _employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            var employee = _employeeSource.GetEmployeeList();

            Console.WriteLine("%%%%% Super fancy headline %%%%%");
            Console.WriteLine("--------------------------------");

            foreach (var item in employee) Console.Write(item);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("%%%%% Super fancy footer %%%%%");
        }
    }
}