using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhmLesson06.Models;
using System.ComponentModel.DataAnnotations;

namespace NhmLesson06.Controllers
{
    public class NhmSongController : Controller
    {
        private static List<NhmSong> nhmSongs = new List<NhmSong>()
        {
            new NhmSong{Id=22109044,NhmTitle="NgoHoangMinh", NhmArtist="CNTT",NhmAuthor="NTU", NhmYearRelease=2023},
            new NhmSong{Id=1,NhmTitle="NgoHoangMinh", NhmArtist="K22CNTT",NhmAuthor="NTU", NhmYearRelease=2020}
        };
    
        
        // GET: NhmSong
        public ActionResult NhmIndex()
        {
            return View(nhmSongs);
        }
        public ActionResult NhmCreate()
        {
            var nhmSong = new NhmSong();
            return View(nhmSong);
        }
    }
}