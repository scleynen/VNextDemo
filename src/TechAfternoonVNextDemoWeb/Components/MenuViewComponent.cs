using DemoDataVNext.Interface;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAfternoonVNextDemoWeb.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private ICalendarRepository _calendarRepository;
        public MenuViewComponent(ICalendarRepository calendarRepository)
        {
            _calendarRepository = calendarRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Menu = await _calendarRepository.GetMenuAsync();
            return View();
        }
    }
}
