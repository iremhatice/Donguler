namespace _1_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler bir koşul dahilinde bir işlemi tekrarlı bir şekilde çalıştırmak amacıyla kullanılır.

            #region For Dongusu
            //For döngüsü,başlangıç ve bitiş aralığı dahilinde tekrarlı işlemler yapar.

            /*
            for (başlangıç_degeri; kosul; degerde_degisiklik)
            {
                 //yapılacak işlemler
            }
            */

            /*
            for(int i=0;  i<5; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            1) Baştaki i değişkeni sadece döngünün başında bir defa oluşturulur.
            2) Eğer ortadaki mantıksal ifade doğru ise döngü bloğu çalıştırılır.
            3) Sondaki kontrol değişkeni güncellenir ve mantıksal ifade yeniden hesaplanır.
            4) Eğer koşul hala doğru ise döngü bloğu yeniden çalıştırılır.
            5) Tüm bu işlem ortadaki koşul bloğu false dönene kadar devam eder. 
            */
            #endregion

            #region For Dongusu Ornekleri
            //1-100 arasındaki sayıların toplamını ekrana yazdıran program.

            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                toplam += i;
            }
            Console.WriteLine("Toplam:" + toplam);

            //Kullanıcıdan alınan 10 adet sayının toplamını ekrana yazdıran program.

            Console.WriteLine("Hesaplamak istediğiniz personel miktarını giriniz. ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam2 = 0;
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(i + 1 + ".Personel: ");
                try
                {
                    toplam2 += Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Sadece rakam giriniz.");
                    i--;
                }
                if (i == sayi - 1)
                {
                    Console.WriteLine("Devam etmek istiyor musunuz?(e/h)");
                    string devammi = Console.ReadLine();
                    if (devammi == "E")
                    {
                        Console.WriteLine("Kaç tane eklemek istiyorsun:");
                        int sayiekle = Convert.ToInt32(Console.ReadLine());
                        sayi = sayi + sayiekle;
                    }
                }
            }
            Console.WriteLine("Yaş ortalaması: " + toplam2 / sayi);
            #endregion

            #region Carpim Tablosu Ornegi

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($" {i} X {j} = " + i * j);
                    Thread.Sleep(1000);
                    Console.Beep();
                }
                Console.WriteLine();
            }

            #endregion

            #region z den a ya Dogru Harfler Ornegi

            for (char harf = 'z'; harf >= 'a'; harf--)
            {
                Console.WriteLine(harf);
            }

            #endregion

            #region Random Sayi Uretme Ornegi
            //1-100 arasında 10 tane sayı üreten ve ürettiği sayıları ekrana yazan en sonunda da sayıların toplamını gösteren programı yazınız.

            int toplam5 = 0;
            for (int a = 1; a <= 10; a++)
            {
                Random random = new Random();
                int b = random.Next(1, 101);
                Console.WriteLine(b);
                toplam5 += b;
            }
            Console.WriteLine($"Sayıların toplamı: {toplam5}");
            #endregion

            #region Dortgen Olusturma
            //Yıldızlarla oluşan dörtgenin satır ve sütun sayısı sabit olmayacak (kullanıcıdan alınacak) şekilde dörtgen oluşturan programı yazınız.

            int satir, sütun;
            Console.WriteLine("Satır sayısını giriniz:");
            satir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sütun sayısı giriniz:");
            sütun = Convert.ToInt32(Console.ReadLine());

            for (int a = 1; a <= satir; a++)
            {
                for (int b = 1; b <= sütun; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
            #endregion

            #region 1945ten gunumuze yillar

            //1945 - günümüze kadar ki yılları ekrana yazdırın ama 1990 ve 1992 yıllarını kırmızı ile yazın.

            for (int i = 1945; i <= DateTime.Now.Year; i++)
            {
                if (i == 1990 || i == 1992)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(i);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
