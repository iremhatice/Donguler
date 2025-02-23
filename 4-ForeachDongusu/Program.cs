namespace _4_ForeachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Dongusu
            // foreach döngüsü, genellikle koleksiyonlar(diziler, listeler, vb.) üzerinde döngü yapmak için kullanılır.Koleksiyonun her elemanına sırayla erişir.

            /* foreach (veri_türü eleman in koleksiyon)
            {
                // Her eleman için yapılacak işlem
            }
            */

            int[] sayilar = { 1, 2, 3, 4, 5 };
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);  // 1, 2, 3, 4, 5 yazdırılır.
            }
            //foreach döngüsü, koleksiyonun her elemanına sırayla erişir ve kod bloğu her eleman için çalışır.
            #endregion

            #region Ornek1-foreach ile char Dizisi Kullanımı
            string kelime = "CSharp";

            foreach (char harf in kelime)
            {
                Console.Write(harf + " ");
            }

            #endregion

            #region Ornek2-foreach ile Dictionary (Anahtar-Değer Çiftleri) Kullanımı
            Dictionary<string, int> yaslar = new Dictionary<string, int>
            {
               { "Ahmet", 25 },
               { "Zeynep", 30 },
               { "Mehmet", 35 }
            };

            foreach (KeyValuePair<string, int> kisi in yaslar)
            {
                Console.WriteLine($"{kisi.Key} {kisi.Value} yaşında.");
            }

            /*Çıktı:       
            Ahmet 25 yaşında.  
            Zeynep 30 yaşında.  
            Mehmet 35 yaşında.  
            */
            #endregion

            #region Ornek3-Liste (List<T>) Üzerinde foreach Kullanımı
            List<int> sayilar4 = new List<int> { 10, 20, 30, 40, 50 };

            foreach (int sayi in sayilar4)
            {
                Console.WriteLine(sayi);
            }
            //Çıktı: 10, 20, 30, 40, 50
            #endregion

            #region Ornek4-foreach Döngüsü İçinde if Kullanımı
            int[] sayilar8 = { 10, 23, 45, 60, 78 };

            foreach (int sayi in sayilar8)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine($"{sayi} çift sayıdır.");
                }
            }

            #endregion

            #region Ornek5-foreach Döngüsünde break ve continue Kullanımı
            int[] sayilar2 = { 5, 10, 15, 20, 25 };

            foreach (int sayi in sayilar2)
            {
                if (sayi == 15)
                {
                    continue; // 15 atlanır
                }

                if (sayi == 25)
                {
                    break; // Döngü sonlanır
                }

                Console.WriteLine(sayi);
            }

            #endregion
        }
    }
}
