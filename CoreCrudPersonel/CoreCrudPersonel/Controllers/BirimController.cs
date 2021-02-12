using CoreCrudPersonel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrudPersonel.Controllers
{
    public class BirimController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Birims.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBirim(Birim d)
        {
            c.Birims.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult BirimSil(int id)
        {
            var deger = c.Birims.Find(id);
            c.Birims.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimGetir(int id)
        {
            var depart = c.Birims.Find(id);
            return View("BirimGetir", depart);
        }
        public IActionResult BirimGuncelle(Birim d)
        {
            var deger = c.Birims.Find(d.BirimID);
            deger.BirimAd = d.BirimAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimDetay(int id)
        {
            var degerler = c.Personels.Where(x => x.BirimID == id).ToList();
            var brm = c.Birims.Where(x => x.BirimID == id).Select(y => y.BirimAd).FirstOrDefault();
            ViewBag.brmad = brm;
            return View(degerler);
        }
    }
}
