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
    public class MemeController : Controller
    {
        private readonly ILogger<MemeController> _logger;

        public MemeController(ILogger<MemeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Meme> memes = new List<Meme>()
            {
                new Meme(new MemeCategory("got"),new MemeImg("got.jpg"),"Defnely Not me"),
                new Meme(new MemeCategory("politic"),new MemeImg("politics.jpg"),"Maybe..")
            };
            ViewData["content"] = memes;
            ViewBag.msg = new Meme(new MemeCategory("politic"),new MemeImg("politics.jpg"),"Maybe..");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
