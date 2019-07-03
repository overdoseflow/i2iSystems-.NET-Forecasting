using MVCWeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace MVCWeather.Controllers
{
    public class HomeController : Controller
    {

       
        public ActionResult HavaDurumu()
        {
            string api = "&APPID=2f085e1beb1fe707b87819d0963dedc7";
            string baglanti = "https://api.openweathermap.org/data/2.5/weather?q=Kayseri&mode=xml" + api;
            XDocument Hava = XDocument.Load(baglanti);
            var sicaklik = Hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var icon = Hava.Descendants("weather").ElementAt(0).Attribute("icon").Value;
            var durum = Hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            ViewBag.icon = "http://openweathermap.org/img/w/" + icon + ".png";
            ViewBag.sicaklik = sicaklik + "KELVIN";
            ViewBag.durum = durum;
          
         
            return View();
        }
        public ActionResult Index()
        {

            return View();
        }
/*[HttpPost]
        public ActionResult HavaDurumu(string cityName)
        {
         

            return Content(($"Hello, the wheater at{ ViewBag.city()} is"));
        }

       [HttpPost, ValidateAntiForgeryToken]
        public ActionResult HavaDurumu(FormModel model)
        {
            return Content($"Hello {model.cityName}");
        }*/
        public ActionResult Forecast()
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