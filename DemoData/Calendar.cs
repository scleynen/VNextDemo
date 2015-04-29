using System.Collections;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoData
{
    public class Calendar
    {
        public string Title { get; set; }
        public IEnumerable<Session> Sessions { get; set; }
    }

    public class Session
    {
        public string Title { get; set; }
        public string Speaker { get; set; }
        public string Type { get; set; }

    }
}
