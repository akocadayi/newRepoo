using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkocadayiCV.Models
{
    public class kategori
    {
        public int id { get; set; }
        public string katadi { get; set; }
        public string urlKatAdi { get; set; }
        public IEnumerable<kategori> getKategoriler()
        {
            CvDbDataContext vt = new CvDbDataContext();
            var result = vt.kategorilers.ToList();
            List<kategori> kategori = new List<kategori>();

            foreach (var item in result)
            {
                kategori.Add(new kategori { id = item.ID, katadi = item.kategoriAdi, urlKatAdi = item.urlsefKatAdi });

            }
            return kategori;
        }
    }
}