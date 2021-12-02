using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimNedir
{
    public class Ogrenci:TemelTip
    {
        public string bolum { get; set; }
        public string seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Ogrenci nesnesi çalıştı.");
            //TemelTipMetot2(); protected olarak işaretlendiği için bu nesne kendisini temel tip nesnesinden
            //kalıttığı için protected seviyesinde olan field veya metotlara erişebilir.
        }
    }
}
