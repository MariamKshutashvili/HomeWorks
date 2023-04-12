using Homework__13.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Homework__13.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //aqedan
        public string jsonFile = Path.Combine(Directory.GetCurrentDirectory(), "information.json");
       [Route("/register", Name = "Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("/register", Name = "Register")]
        public ActionResult Index(info person)
        {
            if (!ModelState.IsValid)
            {
                return View("Register");
            }


            string first = person.firstName;
            string last = person.lastName;
            string doct = person.doctor;
            DateTime time = person.time;

            var jsonfile = new
            {
                firstName = first,
                lastName = last,
                doctor = doct,
                time = time.ToShortTimeString(),
            };

            //Json-shi gadakvana da chawera-- დიდი ფაილი წაიკითხა და საშალა პატარა ობიექტებად {} jlistში
            var streamReader = new StreamReader(jsonFile);
            var jread= streamReader.ReadToEnd();
            var jlist=JsonConvert.DeserializeObject<List<object>>(jread);
            streamReader.Close();


            //updating the list with new info
            if (jlist!=null)
            {
                jlist.Add(jsonfile);//ახალს ვამატებთ საწყისს ობიექტების სიას
                string jsonData = JsonConvert.SerializeObject(jlist, Formatting.Indented);//დანამატიანი ჯეისონი გახდა
                using StreamWriter stream = new(jsonFile);
                stream.WriteLine(jsonData);// ის JSONად გარდაქმნილი დაამატა ჩვენს json დიდი ფაილში
                // ამის გამოა რომ გვაქვს და ემატება information jsonს ახალი დეითა და ინახავს ჯეისონის სტილში
            }
            else
            {
                //First time -- სიას ვქმნით, ელემენტად ვამატებთ ახალს და
                //გარდავქმენით JSONად და დავუმატეთ დიდ ფაილს.
                var jsonList= new List<object>() {jsonfile};  
                var newJson = JsonConvert.SerializeObject(jsonList, Formatting.Indented);
                using StreamWriter stream = new(jsonFile);
                stream.WriteLine(newJson);

            }

            return View("end");
        }

        //წამოვიღო ინფორმაცია --> პირველი middleware
        [HttpPost]
        [Route("/appointments", Name = "appointments")]




        [HttpPost]
        [Route("/Booking", Name = "NoBooking")]




        private IActionResult Json(string jsonFile, object allowGet)
        {
            throw new NotImplementedException();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
