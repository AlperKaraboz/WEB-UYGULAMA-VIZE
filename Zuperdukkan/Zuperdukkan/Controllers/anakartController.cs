using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zuperdukkan.Controllers
{
    public class anakartController : Controller
    {
        // GET: anakart



        public ActionResult Create()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.anakart veri)
        {
            Models.anakart.VeriListe2.Add(veri);
            return RedirectToAction("Listele3");

        }





        public ActionResult Listele3()
        {
            return View(Models.anakart.VeriListe2);
        }

        public ActionResult Edit(int Id)
        {
            var stokVeri = Models.anakart.VeriListe2.Where(x => x.Id == Id).FirstOrDefault();

            return View(stokVeri);

        }
        [HttpPost]
        public ActionResult Edit(Models.anakart veri)

        {
            var stokVeri = Models.anakart.VeriListe2.Where(x => x.Id == veri.Id).FirstOrDefault();
            stokVeri.Marka = veri.Marka;
            stokVeri.Model = veri.Model;
            stokVeri.Stok = veri.Stok;
            stokVeri.Fiyat = veri.Fiyat;

            return RedirectToAction("Listele3");
        }

        public ActionResult Delete(int Id)

        {

            var stokVeri = Models.anakart.VeriListe2.Where(x => x.Id == Id).FirstOrDefault();

            return View(stokVeri);

        }

        [HttpPost]
        public ActionResult Delete(Models.anakart veri)

        {

            var stokVeri = Models.anakart.VeriListe2.Where(x => x.Id == veri.Id).FirstOrDefault();
            Models.anakart.VeriListe2.Remove(stokVeri);
            return RedirectToAction("Listele3");

        }




    }
}