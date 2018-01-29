using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;
using System.Web.UI.WebControls;
namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private MusicStoreDB storeDB = new MusicStoreDB();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search(string q)
        {
            var albums = storeDB.Albums
            .Include("Artist")
            .Where(a => a.Title.Contains(q))
            .Take(10);
            return View(albums);
             
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}