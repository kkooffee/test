using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateGame.Interfaces;
using DateGame.Models;
using Microsoft.AspNetCore.Mvc;

namespace DateGame.Controllers
{
    public class UpdateController : Controller
    {
        private IGames Games;

        public UpdateController(IGames games)
        {
            Games = games;
        }
        [HttpPost]
        public IActionResult UpdateGame( Game game)
        {
            Games.UpdateGame(game);
            return RedirectToAction("Index","Home");
            //Redirect("Home");
            //RedirectToPage("");
           // return Redirect("Home"); //RedirectToRoute("");//View();
        }
        [HttpGet]
        public IActionResult UpdateGame(int gameId)
        {

            return View(Games.GetGame(gameId));
        }
        public IActionResult Complete()
        {
            return View();
        }
    }
}