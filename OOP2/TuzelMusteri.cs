using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheritance = tüzel müşteri bir müşteridir demek istiyoruz. 
    class TuzelMusteri:Musteri
    {
  
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
