using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zuperdukkan.Models
{
    public class StokVeri
    {
        public int Id { get; set; }

        public string Marka { get; set; }
        
        public string Model { get; set; }

        public string Stok { get; set; }

        public string Fiyat { get; set; }
        
   

    public static List<StokVeri> VeriListe = new List<StokVeri>

    {
        new StokVeri
        {

            Id = 1,
            Marka = "AMD",
            Model = "RX500",
            Stok = "15",
            Fiyat = "3200",


        },

        new StokVeri
        {

            Id = 2,
            Marka = "NVDIA",
            Model = "RTX106050",
            Stok = "2",
            Fiyat = "6600",


        },




    };
} }