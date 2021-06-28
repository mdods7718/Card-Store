using Card_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Card_Store.Controllers
{
    public class MagicController : Controller
    {
        // GET: Magic
        [Route("Magic/{magicName}")]
        public ActionResult Index(string magicName)
        {
            ViewBag.Magic = new Magic
            {
                Name = "Dragons Rage Channeler",
                Rarety = "Uncommon",
                MarketPrice = 20.89,
                ImagePath = "/Content/Images/DragonsRageChanneler.jpg"
            };

            ViewBag.Magic2 = new Magic
            {
                Name = "Feasting Troll King",
                Rarety = "Rare",
                MarketPrice = 5.05,
                ImagePath = "/Content/Images/FeastingTrollKing.jpg"
            };

            ViewBag.Magic3 = new Magic
            {
                Name = "Silverbluff Bridge",
                Rarety = "Common",
                MarketPrice = 7.15,
                ImagePath = "/Content/Images/SilverbluffBridge.jpg"
            };

            return View();
        }
    }
}