using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_Ornek_Sonnuncu
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim = "";
          
            do
            {
                MenuYaz();

               secim = Console.ReadLine();
               secim= IslemBaslat(secim);
            } while (secim=="0"|| secim=="1"||secim=="2"||secim=="3"||secim=="4"||secim=="5");

        }
        static void MenuYaz()
        {
            Console.WriteLine("[1] Toplama");
            Console.WriteLine("[2] Çıkarma");
            Console.WriteLine("[3] Çarpma");
            Console.WriteLine("[4] Bölme");
            Console.WriteLine("[5] Cıkıs Yap");
            Console.WriteLine("");
            Console.Write("Bir işlem seçiniz : ");
        }
        static string IslemBaslat(string secim)
        {
            switch (secim)
            {
                case "1": ToplamaYap(); break;
                case "2": CıkarmaYap(); break;
                case "3": CarpmaYap(); break;
                case "4": BolmeYap(); break;
                case "5": secim= CıkısYap(); break;
               
                default:
                    MenuYaz();
                    secim = "0";
                    break;
            }
            return secim;
        }
        static string CıkısYap()
        {
            return "6";
    }
        static void ToplamaYap()
        {
            Console.Clear();
            Console.WriteLine("TOPLAMA İŞLEMİ");
            Console.WriteLine();
            Console.Write("1.sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç= " + sonuc.ToString());
            Console.WriteLine();
            Console.WriteLine("Devam etmek için bir tuşa basınız: ");
            Console.ReadLine();
           }
        static void CıkarmaYap()
        {
            Console.Clear();
            Console.WriteLine("Çıkarma işlemi");
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuc:" + sonuc.ToString());
            Console.WriteLine("Devam etmek için bir tuşa basınız: ");
            Console.ReadLine();
        }
        static void CarpmaYap()
        {
            Console.Clear();
            Console.WriteLine("Çarpma işlemi");
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuc:" + sonuc.ToString());
            Console.WriteLine("Devam etmek için bir tuşa basınız: ");
            Console.ReadLine();

        }
        static void BolmeYap()
        {
            Console.Clear();
            Console.WriteLine("Bölme işlemi");
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            int sonuc = sayi1 /  sayi2;
            Console.WriteLine("Sonuc:" + sonuc.ToString());
            Console.WriteLine("Devam etmek için bir tuşa basınız: ");
            Console.ReadLine();

        }

    }
}
