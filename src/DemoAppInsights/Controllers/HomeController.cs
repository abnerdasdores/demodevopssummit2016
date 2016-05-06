using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DemoAppInsights.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SlowPage()
        {
            ViewBag.Message = "This is a really slow page.";

            var sleepTime = new Random().Next(10, 20);
            System.Threading.Thread.Sleep(sleepTime * 1000);

            return View();
        }

        public ActionResult BuggedCode()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuggedCode(int number)
        {
            var telemetryClient = new TelemetryClient();
            var eventProperties = new Dictionary<string, string> { { "number", number.ToString() } };
            telemetryClient.TrackEvent("NumberTyped", eventProperties);

            if (IsPrime(number))
                throw new InvalidOperationException("This is a prime number.");
            
            ViewBag.Message = $"The number is {number}";
            return View();
        }

        private static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false; 

            for (var i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
