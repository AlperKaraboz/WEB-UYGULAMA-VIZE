using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zuperdukkan.Models
{
    public class anakart
    {
        // GET: anakart
        public int Id { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public string Stok { get; set; }

        public string Fiyat { get; set; }

        public static List<anakart> VeriListe2 = new List<anakart>

    {
        new anakart
        {

            Id = 1,
            Marka = "AMD",
            Model = "3800",
            Stok = "215",
            Fiyat = "1200",


        },

        new anakart
        {

            Id = 2,
            Marka = "Intel",
            Model = "9400K",
            Stok = "21",
            Fiyat = "4600",


        },







    };
    }
}