using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataVNext.Interface
{
    public interface ICalendarRepository
    {
        Calendar GetCalendar();

        Task<string> GetMenuAsync();
    }
}
