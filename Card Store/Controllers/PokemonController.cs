using Card_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Card_Store.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            ViewBag.quickBall = new Pokemon
            {
                Name = "Quick Ball",
                Rarety = "Uncommon",
                MarketPrice = 0.69,
                ImagePath = "/Content/Images/quickBall.jpg"
            };

            ViewBag.pathToThePeak = new Pokemon
            {
                Name = "Path to the Peak",
                Rarety = "Uncommon",
                MarketPrice = 0.26,
                ImagePath = "/Content/Images/pathToThePeak.jpg"
            };

            ViewBag.fogCrystal = new Pokemon
            {
                Name = "Fog Crystal",
                Rarety = "Uncommon",
                MarketPrice = 0.25,
                ImagePath = "/Content/Images/fogCrystal.jpg"
            };

            ViewBag.bossOrders = new Pokemon
            {
                Name = "Boss's Orders",
                Rarety = "Rare",
                MarketPrice = 0.80,
                ImagePath = "/Content/Images/bossOrders.jpg"
            };

            ViewBag.levelBall = new Pokemon
            {
                Name = "Level Ball",
                Rarety = "Uncommon",
                MarketPrice = 0.32,
                ImagePath = "/Content/Images/levelBall.jpg"
            };

            ViewBag.melony = new Pokemon
            {
                Name = "Melony",
                Rarety = "Uncommon",
                MarketPrice = 0.20,
                ImagePath = "/Content/Images/melony.jpg"
            };

            return View();
        }
    }
}