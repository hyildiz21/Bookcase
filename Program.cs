using System;
using System.IO;

namespace Kitaplik_proje_lastLess
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat=0;
            string secmek;
            Console.WriteLine("<<----------------------------------------------------------------------->>");
            Console.WriteLine();
            Console.WriteLine("<<    Türkçe Kitaplar Listesi        --    İngilizce Kitaplar Listesi    >>");
            Console.WriteLine();
            Console.WriteLine("<<    1-Serenad: Zülfü Livaneli      --    7-Kızıl Yükseliş: Pierce Brown>>");
            Console.WriteLine();
            Console.WriteLine("<<    2-Tutunamayanlar: Oğuz Atay    --    8-Hobbit: J.R.R.Tolkien       >>");
            Console.WriteLine();
            Console.WriteLine("<<    3-Çalıkuşu: Reşat Nuri         --    9-Dune: Frank Herbert         >>");
            Console.WriteLine();
            Console.WriteLine("<<    4-Eylül: Mehmet Rauf           --    10-Olasılıksız: Adam Fawer    >>");
            Console.WriteLine();
            Console.WriteLine("<<    5-Aylak Adam: Yusuf Atılgan    --    11-Marslı: Andy Weir          >>");
            Console.WriteLine();
            Console.WriteLine("<<    6-Mai ve Siyah: Halit Ziya     --    12-1984: George Orwell        >>");
            Console.WriteLine();
            Console.WriteLine("<<----------------------------------------------------------------------->>");
            Console.WriteLine();

            char secim;
            Console.WriteLine("** İŞLEMLER MENÜSÜ **");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama ");
            Console.WriteLine("2-Yeni Okur Kaydı ");
            Console.WriteLine("3-Günün Kitabı ");
            Console.WriteLine("4-Kitap Arşivi ");
            Console.WriteLine("5-Yeni Kitap Satın Al ");
            Console.WriteLine("6-Oyun ");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlem numarasını giriniz: ");
            secim = Convert.ToChar(Console.ReadLine());
            if (secim == '1')
            {
                Console.WriteLine();
                string numara;
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitap numarasını giriniz: ");
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.WriteLine("Serenad: 10 TL"); break;
                    case "2": Console.WriteLine("Tutunamayanlar: 11 TL"); break;
                    case "3": Console.WriteLine("Çalıkuşu: 12 TL"); break;
                    case "4": Console.WriteLine("Eylül: 13 TL"); break;
                    case "5": Console.WriteLine("Aylak Adam: 14 TL"); break;
                    case "6": Console.WriteLine("Mai ve Siyah: 15 TL"); break;
                    case "7": Console.WriteLine("Kızıl Yükseliş: 16 TL"); break;
                    case "8": Console.WriteLine("Hobbit: 17 TL"); break;
                    case "9": Console.WriteLine("Dune: 18 TL"); break;
                    case "10": Console.WriteLine("Olasılıksız: 19 TL"); break;
                    case "11": Console.WriteLine("Marslı: 20 TL"); break;
                    case "12": Console.WriteLine("1984: 21 TL"); break;
                    default: Console.WriteLine("Hatalı numara girişi, böyle bir kitap bulunmamaktadır."); break;
                }
            }
            if (secim == '2')
            {
                Console.WriteLine();
                Console.WriteLine("--Yeni Okur Kaydı--");
                string ad, soyad, uni;
                Console.Write("İsminiz: ");
                ad = Console.ReadLine();
                Console.Write("Soyisminiz: ");
                soyad = Console.ReadLine();
                Console.Write("Okuduğunuz Üniversite: ");
                uni = Console.ReadLine();

                string dosya = @"C:\Users\hamza\OneDrive\Masaüstü\Yeni klasör\kitaplık.txt"; //Yeni klasör ün içinde bulabilirsin :D
                StreamWriter swt = new StreamWriter(dosya);
                swt.WriteLine("İsminiz: " + ad.ToUpper());
                swt.WriteLine("Soyisminiz: " + soyad.ToUpper());
                swt.WriteLine("Üniversiteniz: " + uni.ToUpper());
                swt.Close();

            }
            if (secim == '3')
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("---- Günün Kitabı: Dune -----");
                Console.WriteLine();
                Console.WriteLine("-----------------------------");

            }
            if (secim == '4')
            {
                // ?????????????
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                FileStream fs = new FileStream(@"C:\Users\hamza\OneDrive\Masaüstü\kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin= sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    sr.ReadLine();
                    
                }
                sr.Close();
                fs.Close();                
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
            }
            if (secim == '5')
            {
                for (int i = 0; i <= 20; i++)
                {
                    Console.WriteLine();
                    Console.Write("Almak istediğiniz kitabın numarası: ");
                    secmek = Console.ReadLine();
                    if (secmek == "1")
                    {
                        toplamfiyat = toplamfiyat + 10;
                    }
                    if (secmek == "2")
                    {
                        toplamfiyat = toplamfiyat + 11;
                    }
                    if (secmek == "3")
                    {
                        toplamfiyat = toplamfiyat + 12;
                    }
                    if (secmek == "4")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    if (secmek == "5")
                    {
                        toplamfiyat = toplamfiyat + 14;
                    }
                    if (secmek == "6")
                    {
                        toplamfiyat = toplamfiyat + 15;
                    }
                    if (secmek == "7")
                    {
                        toplamfiyat = toplamfiyat + 16;
                    }
                    if (secmek == "8")
                    {
                        toplamfiyat = toplamfiyat + 17;
                    }
                    if (secmek == "9")
                    {
                        toplamfiyat = toplamfiyat + 18;
                    }
                    if (secmek == "10")
                    {
                        toplamfiyat = toplamfiyat + 19;
                    }
                    if (secmek == "11")
                    {
                        toplamfiyat = toplamfiyat + 20;
                    }
                    if (secmek == "12")
                    {
                        toplamfiyat = toplamfiyat + 21;
                    }
                    else
                        Console.Write("Başka bir kitap almak ister misiniz? [Evet-e veya Hayır-h] : ");
                    string cevap = Console.ReadLine();
                    if (cevap == "h" | cevap == "H" | cevap == "hayır" | cevap == "HAYIR")
                    break;
                }
                Console.WriteLine("Toplam Tutar: " + toplamfiyat);  
            }  
            if (secim == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rn = new Random();
                int sayi = rn.Next(1, 100);
                while (sayi != tahmin)
                {
                    Console.Write("Sayı Giriniz: ");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if (tahmin>sayi)
                    {
                        Console.WriteLine("Daha Küçük Sayı Giriniz");
                    }
                    if (tahmin<sayi)
                    {
                        Console.WriteLine("Daha Büyük Sayı Giriniz");
                    }
                    if (tahmin==sayi)
                    {
                        Console.WriteLine("Bildiniz"); break;
                    }
                }

            }










            Console.Read();
        }
    }
}
