using DemoDataVNext;
using DemoDataVNext.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoDataVNext
{
    public class CalendarRepository : ICalendarRepository
    {
        public Calendar GetCalendar()
        {
            var vm = new Calendar() { Title = "Technical Afternoon asp.net 5 MVC Demo" };

            var sessions = new List<Session>();

            sessions.Add(new Session() { Title = "Future of Asp.net", Speaker = "Steve Cleynen", Type = "web" });
            sessions.Add(new Session() { Title = "Clean Architecture", Speaker = "Christophe De Baene", Type = "architecture" });
            sessions.Add(new Session() { Title = "Xamarin", Speaker = "Nico Vermeir", Type = "mobile" });

            vm.Sessions = sessions;


            return vm;
        }

        public Task<String> GetMenuAsync()
        {
            return Task.FromResult("HOME | ALL");
        }
    }
}
