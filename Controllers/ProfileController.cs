using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using memespot_client.Models;

namespace memespot_client.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ProfileImg img = new ProfileImg("user1.jpg");
            ViewBag.UserProfile = new Profile("Matt13",img,new Sex("male"));
            List<Profile>profiles = new List<Profile>(){
                new Profile("BrianDoggy",null,new Sex("male")),
                new Profile("Meggy",null,new Sex("female")),
                new Profile("Warmachine",null,new Sex("ah-64"))
            };
            ViewData["profiles"] = profiles;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
