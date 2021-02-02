using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DateGame.Models;
using DateGame.Interfaces;
using DateGame.ViewModels;

namespace DateGame.Controllers
{
    public class HomeController : Controller
    {
        private IGames Games;

        public HomeController(IGames games)
        {
            Games = games;
        }
        public IActionResult Index()
        {
            var list = Games.AllGame;         
            return View(new ViewModelGames(list));
        }
       [HttpGet]
        public IActionResult Index(string gnr)
        {
        IEnumerable <Game> list = string.IsNullOrEmpty(gnr) ? Games.AllGame : Games.SellectGame(gnr);
            var model = new ViewModelGames(list);
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteGame(int gameId)
        {
            Games.DeleteGame(gameId);
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
