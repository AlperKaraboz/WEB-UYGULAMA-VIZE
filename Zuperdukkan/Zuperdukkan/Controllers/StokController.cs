using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zuperdukkan.Controllers
{
    public class StokController : Controller
    {
        // GET: Stok


        public ActionResult Listele2()
        {
                
            return View(Models.StokVeri.VeriListe);

        }

        public ActionResult Create()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Create (Models.StokVeri veri)
        {
            Models.StokVeri.VeriListe.Add(veri);
            return RedirectToAction("Listele2");

        }

        public ActionResult Edit(int Id)
        {
            var stokVeri = Models.StokVeri.VeriListe.Where(x => x.Id == Id).FirstOrDefault();

            return View(stokVeri);
                
        }
         [HttpPost]
        public ActionResult Edit(Models.StokVeri veri)

        {
            var stokVeri = Models.StokVeri.VeriListe.Where(x => x.Id == veri.Id).FirstOrDefault();
            stokVeri.Marka = veri.Marka;
            stokVeri.Model = veri.Model;
            stokVeri.Stok = veri.Stok;
            stokVeri.Fiyat = veri.Fiyat;

            return RedirectToAction("Listele2");
        }

        public ActionResult Delete(int Id)

        {

            var stokVeri = Models.StokVeri.VeriListe.Where(x => x.Id == Id).FirstOrDefault();

            return View(stokVeri);

        }

        [HttpPost]
        public ActionResult Delete(Models.StokVeri veri)

        {

            var stokVeri = Models.StokVeri.VeriListe.Where(x => x.Id == veri.Id).FirstOrDefault();
            Models.StokVeri.VeriListe.Remove(stokVeri);
            return RedirectToAction("Listele2");

        }


    }
}