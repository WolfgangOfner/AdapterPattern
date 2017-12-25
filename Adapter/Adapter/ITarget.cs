using System.Collections.Generic;

namespace Adapter
{
    public interface ITarget
    {
        IEnumerable<string> GetEmployeeList();
    }
}