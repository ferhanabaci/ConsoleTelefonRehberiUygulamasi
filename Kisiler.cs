using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberUygulaması
{
    public class Kisiler{

        public string Ad;
        public string Soyad;
        public string TelNo;

        public Kisiler(string ad,string soyad,string telNo)
        {
            
            this.Ad = ad;
            this.Soyad = soyad;
            this.TelNo = telNo;
        }
    }
}
