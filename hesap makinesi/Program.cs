using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi Programı");
            Console.WriteLine("---------------------------------");

            while (true)
            {
                Console.WriteLine("İşlem Seçin:");
                Console.WriteLine("1 - Toplama");
                Console.WriteLine("2 - Çıkarma");
                Console.WriteLine("3 - Çarpma");
                Console.WriteLine("4 - Bölme");
                Console.WriteLine("5 - Karekök");
                Console.WriteLine("6 - Üs Alma");
                Console.WriteLine("7 - Faktöriyel");
                Console.WriteLine("0 - Çıkış");

                Console.Write("Seçiminizi yapın: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 0)
                {
                    break;
                }

                double sayi1, sayi2, sonuc;

                switch (secim)
                {
                    case 1:
                        Console.Write("Birinci sayıyı girin: ");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("İkinci sayıyı girin: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;

                    case 2:
                        Console.Write("Birinci sayıyı girin: ");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("İkinci sayıyı girin: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;

                    case 3:
                        Console.Write("Birinci sayıyı girin: ");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("İkinci sayıyı girin: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;

                    case 4:
                        Console.Write("Birinci sayıyı girin: ");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("İkinci sayıyı girin: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine("Sonuç: " + sonuc);
                        }
                        else
                        {
                            Console.WriteLine("Bir sayıyı 0'a bölemezsiniz!");
                        }
                        break;

                    case 5:
                        Console.Write("Karekökünü almak istediğiniz sayıyı girin: ");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        sonuc = Math.Sqrt(sayi1);
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;

                    case 6:
                        Console.Write("Üssünü almak istediğiniz sayıyı girin: ");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Üs değerini girin: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = Math.Pow(sayi1, sayi2);
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;

                    case 7:
                        Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı girin: ");
                        sayi1 = Convert.ToDouble(Console.ReadLine());
                        sonuc = FaktoriyelHesapla(sayi1);
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

                Console.WriteLine("---------------------------------");
            }
        }

        static double FaktoriyelHesapla(double sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }
            else
            {
                return sayi * FaktoriyelHesapla(sayi - 1);
            }
        }
    }
}