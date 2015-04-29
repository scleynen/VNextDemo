using DemoData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechAfternoonOldMVC.Controllers
{
    public class HomeController : Controller
    {
        private ICalendarRepository _calendarRepository;
        public HomeController(ICalendarRepository calendarRepository)
        {
            _calendarRepository = calendarRepository;
        }
        // GET: Home
        public ActionResult Index()
        {
            

            return View(_calendarRepository.GetCalendar());
        }
    }
}