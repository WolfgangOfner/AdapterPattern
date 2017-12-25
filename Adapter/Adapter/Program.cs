using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITarget target = new EmployeeAdapter();

            var client = new FancyReportingTool(target);

            client.ShowEmployeeList();

            Console.ReadKey();
        }
    }
}