using System;

namespace Sınıf_Nedir__Instance__Field__Property
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dzimi
            // class SinifAdi
            // {
            //      [Erişim Belirleyici] [Veri Tipi] MetotAdi[Parametre Listesi]
            //      {
            //      // Metot Komutları
            //      }
            // }

            // Erişim Belirleyiciler
            // * Public         -> Programın heryerinden erişilebilir
            // * Private        -> Tanımlandığı sınıf içerisinden erişilebilir
            // * Internal       -> Sadece oluşturulduğu proje içerisinden erişilebilir
            // * Protected      -> Sadece tanımlandığı sınıfta veya o sınıftan kalıtıım alan sınıflardan erişilebilir
            Calisan calisan1 = new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.SoyAd="Kara";
            calisan1.no=8459625;
            calisan1.departman="İnsan Kaynakları";
            calisan1.calisanBilgileri();
            Console.WriteLine("***************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Burak";
            calisan2.SoyAd="Yılmaz";
            calisan2.no=12345678;
            calisan2.departman="Satınalma";
            calisan2.calisanBilgileri();
            Console.WriteLine("***************");

        }
    }

    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int no;
        public string departman;
        public void calisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", SoyAd);
            Console.WriteLine("Çalışanın No: {0}", no);
            Console.WriteLine("Çalışanın Departmanı: {0}", departman);

        }
    }
}
