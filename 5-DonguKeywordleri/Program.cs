namespace _5_DonguKeywordleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Continue,Break ve Return
            #region Continue
            //Döngüde bir sonraki iterasyona geçmek için kullanılır. Döngüdeki bir iterasyondan sonra geriye kalan kodu atlar ve bir sonraki döngüye geçer.

            Console.WriteLine("Sayı giriniz: ");
            int girilensayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 0; i < girilensayi; i++)
            {
                if (i % 2 == 0)
                    continue; //i sıfıra tam bölünüyorsa sonraki kodu atlar vev döngüye devam eder.
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);
            #endregion

            #region Break 
            // Döngüyü sonlandırmak için kullanılır. Döngü çalışırken koşul sağlanmasa da döngüden çıkılabilir. Sadece döngüyü sonlandırır ve fonksiyonu devam ettirir.

            int sayi = 0;

            if (sayi < 100)
            {
                for (sayi = 24; sayi < 10; sayi++)
                {
                    if (sayi > 25)
                    {
                        break; //sayi 25ten büyük oldugunda döngüden cik.
                    }
                }
            }
            sayi = sayi + 5; //Bu satir calisir.
            Console.WriteLine("Sayi: " + sayi);
            #endregion

            #region Return
            //Bir fonksiyonu sonlandırır ve (varsa) bir değer döndürür. Fonksiyon çalışmayı bitirir ve geri dönen değeri, fonksiyonu çağıran yere iletir.

            for (sayi = 49; sayi < 100; sayi++)
            {
                if (sayi > 50)
                {
                    return; //sayi 50den buyuk oldugunda donguyu sonlandir.
                }
            }
            #endregion
        }
    }
}
