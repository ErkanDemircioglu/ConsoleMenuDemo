using System;
using System.Threading;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool deger = true;
            while (deger)
            {
                deger = AnaMenu();
            }
        }

   

        private static bool AnaMenu()
        {
            Console.Clear();
            Console.WriteLine("   ---------- Personel ----------");
            Console.WriteLine();


            Console.WriteLine("  Menu");
            Console.WriteLine("  ----------------------");
            Console.WriteLine("  1- Sicile Göre Ara");
            Console.WriteLine("  2- İsme Göre Ara");
            Console.WriteLine("  3- Personel Ekle");
            Console.WriteLine("  4- Odaya Göre Ara");
            Console.WriteLine("  5- Birime Göre Ara");
            Console.WriteLine("  6- Çıkış");
            Console.WriteLine("  ----------------------");

            Console.Write(" Seçiminiz : ");
            string istek = Console.ReadLine();

            switch (istek)
            {
                case "1":
                    SicileGoreAra();
                    break;
                case "2":

                    ismeGoreAra();
                    break;
                case "3":
                    personelEkle2();
                    break;
                case "4":
                    odayaGoreAra();
                    break;
                case "5":
                    birimeGoreAra();
                    break;
                case "6":
                    return false;

                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Lütfen 1,2,3,4,5 veya 6 Değerini Seçiniz.. (Devam etmek için Enter Tuşuna basınız)");
                    Console.ReadLine();
                    break;
            }


            return true;
        }



        private static void Baslik()
        {
            Console.WriteLine("  ID  |   Sicil   |    Ad Soyad    |     Unvan     | Tc No |      Birim    |  Oda ");
            Console.WriteLine("----------------------------------------------------------------------------------");

        }

        private static void AnaMenuyeDon()
        {
            Console.WriteLine();
            Console.WriteLine("Ana Menü için Enter tuşuna basınız...");
            Console.ReadLine();
        }
        private static void birimeGoreAra()
        {
            throw new NotImplementedException();

            AnaMenuyeDon();
        }

        private static void odayaGoreAra()
        {
            throw new NotImplementedException();
            AnaMenuyeDon();
        }

        private static void TransferBasla()
        {
            Thread th1 = new Thread(TransferEt);
            th1.Start();
        }


        private static void TransferEt()
        {
            throw new NotImplementedException();


        }

        private static void uploadPersonel(int id)
        {
            throw new NotImplementedException();
        }

        public static void ismeGoreAra()
        {
            throw new NotImplementedException();
            AnaMenuyeDon();

        }
        public static void SicileGoreAra()
        {
            throw new NotImplementedException();

            AnaMenuyeDon();
        }

        public static void personelEkle2()
        {
            throw new NotImplementedException();
            AnaMenuyeDon();
        }
        public static void PersonelEkle()
        {
            throw new NotImplementedException();
        }
    }
}
