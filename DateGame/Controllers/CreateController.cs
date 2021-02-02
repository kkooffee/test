using DateGame.Interfaces;
using DateGame.Models;
using DateGame.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateGame.Controllers
{
    public class CreateController : Controller
    {
        private IGames games; 
        public CreateController(IGames games)
        {
            this.games = games;
        }
        public IActionResult CreateGame()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateGame(Game game)
        {
            games.CteateGame(game);
            return RedirectToAction("Complete");
        }
        public IActionResult Complete()
        {
            return View();
        }
    }
}
