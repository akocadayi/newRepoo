using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkocadayiCV.Models
{
    public class yonetici
    {
        public string adi { get; set; }
        CvDbDataContext vt = new CvDbDataContext();
        public void getAdi (int id)
        {
            var result = from y in vt.yoneticilers where y.ID == id select new {y.adi };
            foreach (var item in result)
            {
                adi = item.adi;
            }
        }
    }
}