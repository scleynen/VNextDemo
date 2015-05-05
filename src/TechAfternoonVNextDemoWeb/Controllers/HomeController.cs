using DemoDataVNext.Interface;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TechAfternoonVNextDemoWeb.Controllers
{

    public class HomeController : Controller
    {
        private ICalendarRepository _calendarRepository;
        public HomeController(ICalendarRepository calendarRepository)
        {
            _calendarRepository = calendarRepository;
        }

        // GET: /<controller>/
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(_calendarRepository.GetCalendar());
        }

    }
}
