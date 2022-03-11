using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TelefonRehberUygulaması
{
    class Program
    {
        static İslemler İslem = new İslemler();

        static void Main(string[] args)
        {   
            
            SahteVeriEkle();
            Console.WriteLine("Telefon Rehberinize Hoşgeldiniz...");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("**********************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek "); //
            Console.WriteLine("(2) Varolan Numarayı Silmek "); //
            Console.WriteLine("(3) Varolan Numarayı Güncelleme ");
            Console.WriteLine("(4) Rehberi Listelemek ");
            Console.WriteLine("(5) Rehberde Arama Yapmak ");
            Console.WriteLine("(X) Çıkış ");
            Console.WriteLine("**********************************************");
            
            while (true)
            {
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        İslem.NumaraKaydet(); //
                        break;
                    case "2":
                        İslem.NumaraSilme(); // 
                        break;
                    case "3":
                        İslem.NumaraGuncelleme(); //
                        break;
                    case "4":
                        İslem.RehberListeleme();
                        break;
                    case "5":
                        İslem.AramaYapma();
                        break;
                    case "X":
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            
        }
        static void SahteVeriEkle()
        {
            Kisiler kisi1 = new Kisiler("Ferhan", "Abacı","05383972822");
            Kisiler kisi2 = new Kisiler("Sıla", "BUdak","53148121212");
            Kisiler kisi3 = new Kisiler("Cahide", "Abacı","0539165151566");
            Kisiler kisi4 = new Kisiler("Didem ", "Abacı","05321456879");
            Kisiler kisi5 = new Kisiler("Aras", "Abacı","053215324698");
            İslem.Rehber.Add(kisi1);
            İslem.Rehber.Add(kisi2);
            İslem.Rehber.Add(kisi3);
            İslem.Rehber.Add(kisi4);
            İslem.Rehber.Add(kisi5);
            
            Console.Write("");
            
        }
    }
}
