using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTester.Objects
{
    enum TestItemStatus
    {
        Reset,
        Queued,
        InProgress,
        Pass,
        Fail
    }

    public class TestItem
    {
        public string Name { get; set; }
        public string Output { get; set; }
        public string Status { get; set; }

        public TestItem()
        {
            Name = string.Empty;
            Output = string.Empty;
            Status = string.Empty;
        }

        public TestItem(string name, string output, string status)
        {
            Name = name;
            Output = output;
            Status = status;
        }
    }
}
