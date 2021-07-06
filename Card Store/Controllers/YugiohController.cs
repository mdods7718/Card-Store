using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Card_Store.Models;

namespace Card_Store.Controllers
{
    public class YugiohController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.obeliskTheTormentor = new Pokemon
            {
                Name = "Obelisk the Tormentor",
                Rarety = "Ultra Rare",
                MarketPrice = 1.21,
                ImagePath = "/Content/Images/obeliskTheTormentor.jpg"
            };

            ViewBag.sliferTheSkyDragon = new Pokemon
            {
                Name = "Slifer the Sky Dragon",
                Rarety = "Ultra Rare",
                MarketPrice = 1.14,
                ImagePath = "/Content/Images/sliferTheSkyDragon.jpg"
            };

            ViewBag.knightmarePhoenix = new Pokemon
            {
                Name = "Knightmare Phoenix",
                Rarety = "Rare",
                MarketPrice = 0.57,
                ImagePath = "/Content/Images/knightmarePhoenix.jpg"
            };

            ViewBag.soulCrossing = new Pokemon
            {
                Name = "Soul Crossing",
                Rarety = "Ultra Rare",
                MarketPrice = 1.19,
                ImagePath = "/Content/Images/soulCrossing.jpg"
            };

            ViewBag.skullMeister = new Pokemon
            {
                Name = "Skull Meister",
                Rarety = "Rare",
                MarketPrice = 0.81,
                ImagePath = "/Content/Images/skullMeister.jpg"
            };

            ViewBag.swapFrog = new Pokemon
            {
                Name = "Swap Frog",
                Rarety = "Ultra Rare",
                MarketPrice = 1.99,
                ImagePath = "/Content/Images/swapFrog.jpg"
            };

            return View();
        }
    }
}
