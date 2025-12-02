using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    internal class Alistirmalar
    {
        //-----------------------Koşullar------------------------//
        public static void Yas()
        {
            /*

            Console.Write("Lütfen yaşınızı giriniz: ");
            string girilenDeger = Console.ReadLine();

            if (int.TryParse(girilenDeger, out int yas))
            {
                if (yas == 18)
                    Console.WriteLine("Kullanıcı 18 yaşındadır");
                else if (yas > 18)
                    Console.WriteLine("Kullanıcı 18 yaşından büyüktür");
                else
                    Console.WriteLine("Kullanıcı 18 yaşından küçüktür");
            }
            else
            {
                Console.WriteLine("Lütfen yaşınızı rakamlar ile yazın!");
            }

            */


            try
            {
                Console.Write("Lütfen yaşınızı giriniz: ");
                int yas = int.Parse(Console.ReadLine());

                if (yas == 18)
                    Console.WriteLine("Kullanıcı 18 yaşındadır");
                else if (yas > 18)
                    Console.WriteLine("Kullanıcı 18 yaşından büyüktür");
                else
                    Console.WriteLine("Kullanıcı 18 yaşından küçüktür");
            }
            catch
            {
                Console.WriteLine("Geçerli bir sayı giriniz!");
            }
        }
        public static void Giyinme()
        {
            Console.WriteLine("(Programı kapatmak için sıcaklık degerini 999 olacak sekilde girin.)");
            while (true)
            {
                Console.Write("Hava sıcaklıgını giriniz:");
                int sc = int.Parse(Console.ReadLine());

                if (sc != 999)
                {
                    if (sc <= 4)
                    {
                        Console.WriteLine("Kalın mont giy!");
                        sc = 999;
                    }
                    else if (sc >= 5 && sc <= 14)
                    {
                        Console.WriteLine("Sweatshirt yeterli.");
                        sc = 999;
                    }
                    else if (sc >= 15 && sc <= 24)
                    {
                        Console.WriteLine("Tişört giyilebilir.");
                        sc = 999;
                    }
                    else
                    {
                        Console.WriteLine("Şortla çıkabilirsin.");
                        sc = 999;
                    } 
                }
                else
                {
                    break;
                }
            } 
        }
        public static void NotDurumu()
        {
            Console.WriteLine("(Programı kapatmak için not degerini 999 olacak sekilde girin.)");
            while (true)
            {
                Console.Write("Notunuzu giriniz:");
                int nt = int.Parse(Console.ReadLine());

                if (nt != 999)
                {
                    if (nt >= 90)
                    {
                        Console.WriteLine("Mükemmel!");
                        nt = 999;
                    }
                    else if (nt >= 75 && nt <= 89)
                    {
                        Console.WriteLine(" Gayet iyi.");
                        nt = 999;
                    }
                    else if (nt >= 60 && nt <= 74)
                    {
                        Console.WriteLine(" Geçtin ama biraz daha çalış.");
                        nt = 999;
                    }
                    else
                    {
                        Console.WriteLine(" Kaldın.");
                        nt = 999;
                    }
                }
                else
                {
                    break;
                }
            }

        }
        public static void HesapMakinesi()
        {
            Console.WriteLine("(Programı kapatmak için yapıalcak işlemi 0 olacak sekilde girin.)");
            while (true)
            {
                Console.Write("Birinci sayıyı giriniz:");
                double sayi1 = double.Parse(Console.ReadLine());

                Console.Write("İkinci sayıyı giriniz:");
                double sayi2 = double.Parse(Console.ReadLine());

                Console.Write("Yapılacak işlemi ( + - * / ) giriniz:");
                string islem = Console.ReadLine();

                if (islem == "0")
                {
                    break;
                }
                else
                {
                    switch (islem)
                    {
                        case "+":
                            Console.WriteLine("Cevap: " + (sayi1 + sayi2));
                            break;
                        case "-":
                            Console.WriteLine("Cevap: " + (sayi1 - sayi2));
                            break;
                        case "*":
                            Console.WriteLine("Cevap: " + (sayi1 * sayi2));
                            break;
                        case "/":
                            Console.WriteLine("Cevap: " + (sayi1 / sayi2));
                            break;
                        default:
                            Console.WriteLine("Hatalı giris yaptınız.");
                            break;
                    }
                }
            }

        }
        public static void GirisKontrol()
        {
            while (true)
            {
                Console.Write("Kullanıcı adı giriniz: ");
                string kAdi = Console.ReadLine();
                Console.Write("Şifre giriniz: ");
                string sifre = Console.ReadLine();
                if (kAdi != "admin" || sifre != "1234")
                {
                    Console.WriteLine("Kullanıcı adı veya şifre yanlış!");
                }
                else
                {
                    Console.WriteLine("Giriş başarılı!");
                    break;
                } 
            }
        }
        public static void GunlereMesaj()
        {
            Console.Write("Haftanın gününü 1-7 arası olacak şekilde yazınız: ");
            string gun = Console.ReadLine();
            switch (gun)
            {
                case "1":
                    Console.WriteLine("Pazartesi");
                    break;
                case "2":
                    Console.WriteLine("Salı");
                    break;
                case "3":
                    Console.WriteLine("Çarşamba");
                    break;
                case "4":
                    Console.WriteLine("Perşembe");
                    break;
                case "5":
                    Console.WriteLine("Cuma");
                    break;
                case "6":
                case "7":
                    Console.WriteLine("Haftasonu");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız.");
                    break ;
            }
                

            

        }
        public static void YasKategorisi()
        {
            Console.Write("Yaşınızı yazınız:");
            int yas = int.Parse(Console.ReadLine());
            if (yas >= 0 && yas <= 12)
            {
                Console.WriteLine("Çocuk");
            }
            else if (yas >= 13 && yas <= 17)
            {
                Console.WriteLine("Genç");
            }
            else if (yas >= 18 && yas <= 59)
            {
                Console.WriteLine("Yetişkin");
            }
            else if (yas >= 60)
            {
                Console.WriteLine("Yaşlı");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız");
            }
        }
        public static void SayiKarsilastir()
        {
            Console.Write("Birinci sayiyi giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayiyi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            if (sayi1 == sayi2)
            {
                Console.WriteLine("ikisi eşittir.");
            }
            else if (sayi1 > sayi2)
            {
                Console.WriteLine("Birinci sayı büyüktür.");
            }
            else
            {
                Console.WriteLine("İkinci sayı büyüktür.");
            }
        }
        public static void HizKontrol()
        {
            Console.Write("Hızınızı giriniz: ");
            int hiz = int.Parse(Console.ReadLine());

            if (hiz <= 90)
            {
                Console.WriteLine("Güvenli sürüş!");
            }
            else if (hiz >=91 && hiz <= 110)
            {
                Console.WriteLine("Uyarı: Hız limitine yaklaştınız.");
            }
            else
            {
                Console.WriteLine("Ceza kesildi! Aşırı hız yaptınız");
            }
        }
        public static void KullaniciYetki()
        {
            Console.Write("Bir rol (admin, editor, user) giriniz: ");
            string rol = Console.ReadLine();

            if (rol == "admin")
            {
                Console.WriteLine("Tüm yetkilere sahipsiniz.");
            }
            else if (rol == "editör")
            {
                Console.WriteLine("İçerik düzenleyebilirsiniz.");
            }
            else if(rol == "user")
            {
                Console.WriteLine("İçerik görüntüleyebilirsiniz.");
            }
            else
            {
                Console.WriteLine("Tanımsız rol!");
            }
        }
        public static void SifreGuc()
        {
            Console.Write("En az 8 karakter 1 büyük harf ve 1 rakam içeren bir şifre belirleyiniz: ");
            string sifre = Console.ReadLine();

            bool buyukHarfVar = false;
            bool rakamVar = false;

            if (sifre.Length < 8)
            {
                Console.WriteLine("Zayıf şifre");
            }
            else
            {
                for (int i = 0; i < sifre.Length; i++)
                {
                    char karakter = sifre[i];

                    if (karakter >= 'A' && karakter <= 'Z')
                        buyukHarfVar = true;

                    if (karakter >= '0' && karakter <= '9')
                        rakamVar = true;

                    if (buyukHarfVar && rakamVar)
                        break;
                }

                if (buyukHarfVar && rakamVar)
                    Console.WriteLine("Güçlü şifre");
                else
                    Console.WriteLine("Zayıf şifre");
            }


        }
        public static void VucutKıtle()
        {
            Console.Write("Kilonuzu giriniz: ");
            int kilo = int.Parse( Console.ReadLine());

            Console.Write("Boyunuzu giriniz: ");
            int boy = int.Parse(Console.ReadLine());

            double vki = kilo / boy * boy;

            if (vki < 18.5)
            {
                Console.WriteLine("Zayıf");
            }
            else if (vki >= 18.5 && vki < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (vki >= 25 && vki < 30)
            {
                Console.WriteLine("Fazla Kilolu");
            }
            else if(vki >= 30 && vki < 40)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Aşırı Obez");
            }
        }

        //-----------------------Dögüler------------------------//
        public static void TekCift()
        {
            Console.Write("Başlangıç sayısı: ");
            int baslangic = int.Parse(Console.ReadLine());

            Console.Write("Bitiş sayısı: ");
            int bitis = int.Parse(Console.ReadLine());
            
            Console.Write("Tek mi çift mi ? (tek/çift): ");
            string tekVeCift = Console.ReadLine();

            for (int i = baslangic; i <= bitis; i++)
            {
                if (tekVeCift == "çift" && i % 2 == 0)
                {
                    Console.WriteLine(i); ;
                }
                else if (tekVeCift == "tek" && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void CarpimTablosu()
        {
            Console.WriteLine("Çarpım Tablosu Uygulaması");
            Console.Write("Başlangıç Sayısı: ");
            int baslangic = int.Parse(Console.ReadLine());
            Console.Write("Bitiş Sayısı: ");
            int bitis = int.Parse(Console.ReadLine());
            for (int i = baslangic; i <= bitis; i++)
            {
                for (int j = baslangic; j <= bitis; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + j * i); 
                }
                Console.WriteLine();
            }
        }
        public static void YildizPiramitCiz()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void TekCiftWhile()
        {
            int i = 0;
            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} sayısı çifttir.");

                }
                else
                {
                    Console.WriteLine($"{i} sayısı tektir.");
                }
                i++;
            }
        }
        public static void Alarm()
        {
            int saniye = 5;
            while (saniye >= 0)
            {
                if (saniye == 0)
                {
                    Console.WriteLine("Süre doldu! Alarm çalıyor!");
                    Console.Beep(500,2000);
                }
                else
                {
                    Console.WriteLine($"Kalan süre: {saniye} saniye");
                }
                saniye--;
            }
        }
        public static void DoWhile()
        {
            bool anahtar = true;
            do
            {
                Console.Write("Sayı gir (Çıkış için 0): ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi == 0)
                {
                    Console.WriteLine("0 basıldı çıkış yapılıyor...");
                    anahtar = false;
                }
                else
                {
                    Console.WriteLine($"Girilen sayı: {sayi}");
                }

            }
            while (anahtar);
        }
        public static void BasamaklariToplami()
        {

            Console.Write("Bir sayi giriniz:");
            int sayi = Math.Abs(int.Parse(Console.ReadLine()));
            int ilkSayi = sayi;
            int toplam = 0;
            while (sayi > 0)
            {
                toplam += sayi % 10;
                sayi /= 10;
            }
            Console.WriteLine($"{ilkSayi} sayisinin basmaklari toplami {toplam}");
        }

        //-----------------------Diziler------------------------//

        public static void GirilenSayilarinOrt()
        {
            int[] sayilar = new int[5];
            double toplam = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sayı gir: ");
                sayilar[i] = int.Parse(Console.ReadLine());
                toplam += sayilar[i];
            }
            Console.WriteLine($"Ortalama = {toplam / 5}");
        }
        public static void DiziElemanlari()
        {
            int[] sayilar = new int[10];
            int i = 0;
            while (true)
            {
                if (i == 10)
                    break;

                Console.Write("Sayı gir: ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi > 0)
                {
                    sayilar[i] = sayi;
                    i++;
                }


            }
            Console.WriteLine();
            Console.WriteLine("Dizi elemanları:");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(sayilar[j]);
            }
        }
        public static void UrunAnahtari()
        {
            Random random = new Random();

            Console.Write("Oluşturulacak key sayısı: ");
            int keySayisi = int.Parse(Console.ReadLine());

            for (int k = 0; k < keySayisi; k++)
            {
                string key = "";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        int harfSayi = random.Next(0, 2);

                        if (harfSayi == 0)
                        {
                            key += Convert.ToChar(random.Next(65, 91));
                        }
                        else
                        {
                            key += Convert.ToChar(random.Next(48, 58));
                        }
                        if (i != 4 && j == 4)
                        {
                            key += "-";
                        }
                    }
                }
                Console.WriteLine(key);
            }
        }
        public static void İsimListesi()
        {
            string[] isimler = new string[1];
            string[] konteyner = new string[1];

            while (true)
            {
                Console.Clear();
                Console.Write("İsim Gir(Listelemek İçin (0)): ");
                string giris = Console.ReadLine();

                if (giris == "0")
                {
                    for (int i = 0; i < isimler.Length; i++)
                    {
                        Console.WriteLine(isimler[i]);
                    }

                    break;
                }
                else
                {
                    isimler[isimler.Length - 1] = giris;

                    for (int i = 0; i < isimler.Length; i++)
                    {
                        konteyner[i] = isimler[i];
                    }

                    isimler = new string[isimler.Length + 1];

                    for (int i = 0; i < konteyner.Length; i++)
                    {
                        isimler[i] = konteyner[i];
                    }

                    konteyner = new string[konteyner.Length + 1];
                }
            }
        }
        public static void ListedeSayilar()
        {
            Random random = new Random();

            Console.Write("Listenin eleman sayısı: ");
            int kapasite = int.Parse(Console.ReadLine());

            Console.Write("Listedeki sayıların alabileceği minimum değer: ");
            int minimum = int.Parse(Console.ReadLine());

            Console.Write("Listedeki sayıların alabileceği maksimum değer: ");
            int maksimum = int.Parse(Console.ReadLine());

            int[] sayilar = new int[kapasite];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(minimum, maksimum);
            }
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);

            //}
            Console.Write("Dizi Oluşturuldu.\nAramak İstediğiniz Değer: ");
            int aranacakSayi = int.Parse(Console.ReadLine());

            bool varMi = false;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == aranacakSayi)
                    varMi = true;
            }

            Console.WriteLine("Aranılan Değer Dizi İçerisinde Varmı?: " + (varMi ? "Var" : "Yok"));
        }

        //public static void DiziEnBK()
        //{
        //    int[] dizi = new int[5];
        //    Console.WriteLine("Dizinin elemanlarını sırayla giriniz.");
        //    for (int i = 0; i < dizi.Length; i++)
        //    {
        //        Console.ReadLine(dizi[i]);
        //    }
        //}
    }
}