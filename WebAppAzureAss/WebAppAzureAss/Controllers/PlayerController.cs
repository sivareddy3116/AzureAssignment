using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppAzureAss.Models;

namespace WebAppAzureAss.Controllers
{
    public class PlayerController : Controller
    {
        // In-memory data for players
        private static List<Player> players = new List<Player>
        {
            new Player { PId = 1, PName = "Virat Kohli", Country = "India", Type = "Batsman" },
            new Player { PId = 2, PName = "AB de Villiers", Country = "South Africa", Type = "All-rounder" },
            new Player { PId = 3, PName = "Steve Smith", Country = "Australia", Type = "Batsman" },
            new Player { PId = 4, PName = "Kane Williamson", Country = "New Zealand", Type = "Batsman" },
            new Player { PId = 5, PName = "Ben Stokes", Country = "England", Type = "All-rounder" },
            // Add more players as needed
        };

        // GET: /Player
        public IActionResult Index()
        {
            // Display list of players
            return View(players);
        }

        // GET: /Player/Create
        public IActionResult Create()
        {
            // Display form for creating a new player
            return View();
        }

        // POST: /Player/Create
        [HttpPost]
        public IActionResult Create(Player player)
        {
            // Add the new player to the list
            players.Add(player);
            return RedirectToAction("Index");
        }
    }
}
