using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            //SelamVer("Engin");
            //SelamVer("Ahmet");
            //SelamVer("Ayşe");
            //SelamVer();

            int sonuç = Topla(50, 7);

            //Diziler/Arrays

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Ahmet";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Berkay";
            ogrenciler = new string[4];
            ogrenciler[3] = "Emine";
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = { "Adıyaman", "Malatya", "Ankara" };
            string[] sehirler2 = { "Bursa", "Kayseri", "Şanlıurfa" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);

            Person person1 = new Person();
            person1.FirstName = "Ahmet";
            person1.LastName = "Yoldaş";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;



            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 2", "İzmir 3" };
            yeniSehirler1.Add("Malatya 4");

            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }

        class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000.5;//dbden gelir.
            int sayi = 100;
            bool girisYapmismi = false;

            string ad = "Ahmet";
            string soyad = "Yoldaş";
            int dogumYili = 1999;
            long tcNo = 12345678910;

            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(mesaj);
            Console.ReadLine();
        }
    }


}
