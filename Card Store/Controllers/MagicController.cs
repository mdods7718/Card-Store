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
    public class MagicController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.dragonsRageChanneler = new Pokemon
            {
                Name = "Dragon's Rage Channeler",
                Rarety = "Uncommon",
                MarketPrice = 0.69,
                ImagePath = "/Content/Images/dragonsRageChanneler.jpg"
            };

            ViewBag.unholyHeat = new Pokemon
            {
                Name = "Unholy Heat",
                Rarety = "Common",
                MarketPrice = 0.26,
                ImagePath = "/Content/Images/unholy-heat.jpg"
            };

            ViewBag.tirelessProvisioner = new Pokemon
            {
                Name = "Tireless Provisioner",
                Rarety = "Uncommon",
                MarketPrice = 0.25,
                ImagePath = "/Content/Images/tireless-provisioner.jpg"
            };

            ViewBag.silverbluffBridge = new Pokemon
            {
                Name = "Silverbluff Bridge",
                Rarety = "Common",
                MarketPrice = 0.46,
                ImagePath = "/Content/Images/SilverbluffBridge.jpg"
            };

            ViewBag.mistvaultBridge = new Pokemon
            {
                Name = "Mistvault Bridge",
                Rarety = "Uncommon",
                MarketPrice = 0.42,
                ImagePath = "/Content/Images/mistvault-bridge.jpg"
            };

            ViewBag.feastingTrollKing = new Pokemon
            {
                Name = "Feasting Troll King",
                Rarety = "Rare",
                MarketPrice = 0.20,
                ImagePath = "/Content/Images/FeastingTrollKing.jpg"
            };

            return View();
        }
    }
}
