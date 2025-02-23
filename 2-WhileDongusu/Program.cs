namespace _2_WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While Dongusu

            //While,Belirli bir koşul geçerli kaldığı sürece döngü içindeki talimatlar tekrar tekrar yürütülür. Belirlenen komut boğunun verilen şart sağladığı sürece dönmesini sağlayan döngü türüdür.

            /*
             While(koşul true ise)
            {
                Çalıştır...
            }
             */

            int a = 1;
            while (a <= 10) // Döngünün ne kadar devam edip/etmeyeceğini bildirdiğimiz yer.
            {
                Console.WriteLine("A: {0}", a);
                a++;
            }
            #endregion

            #region Ornek1
            //no yazana kadar döngünün içinden çıkamayacaksın.

            string durum = "yes";

            while (durum.ToLower() != "no")
            {
                Console.WriteLine("Döngünün içindesin");
                Console.WriteLine("Döngünün dışına çıkmak istiyor musun [yes] [no]:");
                durum = Console.ReadLine();
            }
            #endregion

            #region Ornek2
            //Klavyeden 0 girilinceye kadar girilen sayıların kendisini ve karesini ekrana yazdıran programı while ile yazınız.

            while (true)
            {
                Console.WriteLine("sayı giriniz: ");

                int girilensayi = Convert.ToInt32(Console.ReadLine());
                if (girilensayi == 0)
                    break;
                Console.WriteLine($"girilensayi= {girilensayi} Sayının karesi {Math.Pow(girilensayi, 2)}");

            }
            Console.ReadLine();
            #endregion

            #region Cift ve Tek Sayilarin Toplamı
            //0-100 arasında ki çift ve tek sayıların toplamlarını bulan programı while ile yazınız.

            int sayac = 1, toplam1 = 0, toplam2 = 0;

            while (sayac <= 100)
            {
                if (sayac % 2 == 0)
                {
                    toplam1 += sayac;
                    sayac++;
                }
                else
                {
                    toplam2 += sayac;
                    sayac++;
                }
            }
            Console.WriteLine("Çift sayıların toplamı: " + toplam1);
            Console.WriteLine("Teksayıların toplamı: " + toplam2);
            Console.ReadLine();
            #endregion

            #region 7'ler Çarpım Tablosu
            //Ekrana 7 ler çarpım tablosunu yazan programı while ile yapınız.

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"7 X {i} = {7 * i}");
                i++;
            }
            #endregion

            #region Faktöriyel Hesaplama
            //Klavyeden kullanıcı tarafından girilen sayının faktöriyelini bulup sonucu ekrana yazdırın.

            int sayi, sonuc = 1;

            Console.WriteLine("Bir sayı giriniz:");
            sayi = int.Parse(Console.ReadLine());
            if (sayi < 0)
            {
                Console.WriteLine("Hesaplanamaz");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else
            {
                while (sayi > 0)

                {
                    sonuc *= sayi;
                    sayi--;

                }
                Console.WriteLine("Sonuç: " + sonuc);
            }
            #endregion
        }
    }
}
