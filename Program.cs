using System;

namespace BankaMatik_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int mevcutBakiye = 0, islem;

            islem:
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Viable Bank'a hoşgeldiniz. Lütfen yapacağınız işlemi seçiniz.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Para yatırmak için 1'e basınız.");
            Console.WriteLine("Para çekmek için 2'e basınız.");
            Console.WriteLine("Mevcut bakiyenizi görmek için 3'e basınız.");
            islem = Convert.ToInt32(Console.ReadLine());
            


            switch(islem)
            {
                case 1:
                    Console.WriteLine("Lütfen yatıracağınız para miktarını seçiniz.");
                    int yatırılacakMiktar = Convert.ToInt32(Console.ReadLine());
                    mevcutBakiye = yatırılacakMiktar + mevcutBakiye;
                    Console.WriteLine("İşlem başarılı. Yeni bakiyeniz: " + (mevcutBakiye));
                    Console.WriteLine("---------------------------------------------------------------------");
                    System.Threading.Thread.Sleep(2000);

                    break;

                case 2:
                    Console.WriteLine("Lütfen yatıracağınız para miktarını seçiniz.");
                    int cekilecekMiktar = Convert.ToInt32(Console.ReadLine());
                    mevcutBakiye = cekilecekMiktar - mevcutBakiye;
                    Console.WriteLine("İşlem başarılı. Yeni bakiyeniz: " + (mevcutBakiye));
                    Console.WriteLine("---------------------------------------------------------------------");
                    System.Threading.Thread.Sleep(2000);
                    break;

                case 3:
                    Console.WriteLine("Mevcut bakiyeniz: " + (mevcutBakiye));
                    Console.WriteLine("---------------------------------------------------------------------");
                    System.Threading.Thread.Sleep(2000);
                    break;
            }

            goto islem;
        }

    }
}
