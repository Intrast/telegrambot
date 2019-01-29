using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelegramBot.Models;


namespace TelegramBot.Controllers
{
    public class ProfilesController : Controller
    {
        Profile db = new Profile();
        // GET: Profiles
        public ActionResult Index()
        {
            return View();
        }
    }
}