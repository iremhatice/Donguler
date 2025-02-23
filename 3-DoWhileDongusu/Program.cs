namespace _3_DoWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoWhile Dongusu
            //Dowhile,tamamen while gibi çalışır.Aralarında ki tek fark while döngüsünde döngü deyimi içerisindeki kontrol,döngüye girilmeden önce yapılırken;dowhile döngüsünde bu kontrol ilk döngü bloğundan çıkıldıktan sonra yapılmaya başlar.

            /* do
            {
                // Tekrarlanacak kod bloğu
            } while (koşul);
            */

            string durum = "yes";

            do
            {
                Console.WriteLine("Döngünün içindesin");
                Console.WriteLine("Döngünün dışına çıkmak istiyor musun [yes] [no]:");
                durum = Console.ReadLine();
            } while (durum.ToLower() != "no");

            Console.WriteLine("Döngünün dışındasın");
            #endregion

            #region Ornek1
            //Kullanıcı şifreyi 123 olarak girene kadar şifreyi soran programı yapınız.

            string kullanıcışifre;
            do
            {
                Console.WriteLine("Şifreyi yazınız: ");
                kullanıcışifre = Console.ReadLine();

            } while (kullanıcışifre != "123");
            Console.WriteLine("Tebrikler şifreyi bildiniz.");
            #endregion

            #region Ornek2
            //Kullanıcı tarafından girilen 10 sayıdan kaç tanesinin 3 basamaklı olduğunu bulan programı yazınız.

            int i = 1, sayac = 1;
            do
            {
                Console.WriteLine($"{i}. sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi <= 999 && sayi >= 100 || sayi <= -100 && sayi >= -999)
                {
                    sayac++;
                }
                i++;
            } while (i < 11);
            Console.WriteLine($"{sayac} adet 3 basamaklı olan sayı vardır.");
            #endregion
        }
    }
}
