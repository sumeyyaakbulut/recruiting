/****************************************************************************
**             SAKARYA ÜNİVERSİTESİ
**             BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**             BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**             NESNEYE DAYALI PROGRAMLAMA DERSİ
**             2019-2020 BAHAR DÖNEMİ
**
**             ÖDEV NUMARASI..........:
**             ÖĞRENCİ ADI............:Sümeyya AKBULUT
**             ÖĞRENCİ NUMARASI.......:b191200043
**             DERSİN ALINDIĞI GRUP...:
*****************************************************************************/
using System;
using System.IO;

namespace job_application_evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dosyayı okumak için bir StreamReader Nesnesi oluştur
            StreamReader sr = new StreamReader(@"C:\Users\CİHAT\Source\Repos\job application evaluation\job application evaluation\applications.txt");

            //Tüm Satırları okuyup bir string içerisine ata
            string tumsatirlar = sr.ReadToEnd();

            //Virgul ile ayırarak her bir kelimeyi diziye ata
            string[] kelimeler = tumsatirlar.Split(",");

            //Tüm kelimeler arasında isim ara, bulduğunda ekrana tüm özelliklerini yazdır
            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta; // Konsol ekranı yazı rengi pembe yazmak için 
                if (kelimeler[i] == "seçil")
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5}", kelimeler[i], kelimeler[i + 1], kelimeler[i + 2], kelimeler[i + 3], kelimeler[i + 4], kelimeler[i + 5]);
                    break;
                }
            }
            //İşlem bittiğinde bir tuşa basılmasını bekler
            Console.ReadKey();
        }
    }
}

