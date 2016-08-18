using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace myApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewData["Message"] = await new HttpClient().GetStringAsync(
                Startup.Configuration.GetValue<string>("ApiBaseUrl") + "/api/values");

            return View();
        }
    }
}
