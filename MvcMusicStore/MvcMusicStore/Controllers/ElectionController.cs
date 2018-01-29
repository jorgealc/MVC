using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;
using System.Text;
namespace MvcMusicStore.Controllers
{
    public class ElectionController : Controller
    {
        private MusicStoreDB db = new MusicStoreDB();
        //
        // GET: /Election/
        public ActionResult Index()
        {
            var album = db.Albums;

            return View(album);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Index(IEnumerable<Album> albums)
        {
            if (albums.Count(x => x.Selecciona) == 0)
            {
                return "No has seleccionado ningun album";
            }

            else
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("Tu has seleccionado -");
                foreach (Album album in albums)
                {
                    if (album.Selecciona)
                    {
                        sb.Append(album.Title + ", ");
                    }
                }
                sb.Remove(sb.ToString().LastIndexOf(","), 1);
                return sb.ToString();
            }


        }      
            }     




          
                }

      


    
	
