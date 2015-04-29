using DemoData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoData
{
    public class CalendarRepository : ICalendarRepository
    {
        public Calendar GetCalendar()
        {
            var vm = new Calendar() { Title = "Technical Afternoon MVC Demo" };

            var sessions = new List<Session>();

            sessions.Add(new Session() { Title = "Future of Asp.net", Speaker = "Steve Cleynen", Type = "web" });
            sessions.Add(new Session() { Title = "Clean Architecture", Speaker = "Christophe De Baene", Type = "architecture" });
            sessions.Add(new Session() { Title = "Xamarin", Speaker = "Nico Vermeir", Type = "mobile" });

            vm.Sessions = sessions;

            return vm;
        }
    }
}
