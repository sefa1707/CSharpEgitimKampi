using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            // Yazdırma Komutları.

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion
            #region Değişkenler
            //Değişkenler

            // Değişkenler - variable - geçici olarak RAM de tutulan programlama değerleridir.Bir çok değişken türü vardır.

            // değişken kullanımı örneği => Değişken_türü değişken_adı ;
            #endregion
            #region String Değişkenler
            //String Değişkenler
            // Metinsel değişkenlerimizi string türünde oluştururuz.

            //Örnek 1
            //string name; 
            //name = "Murat"; 
            //Console.Write(name);

            //name adında metinsel bir değişken oluşturduk. Bu değişkeni program içerisinde kullanmadığımız süreçte altında yeşil çizgi olacak.oluşturduğumuz değişkene bir değer ataması yaptık. Değişken türümüz metinsel olduğu için metinsel ifadelerin atamalarında çift tırnak işareti kullandık. ve name değişkeninin programımız içerisinde Murat değerini taşımasını sağladık.

            //Örnek 2
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("***** Rezarvasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------------");
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------------");

            //Değişkenlerin isimlendirmesinde standartlar vardır. Bunlardan birisi camel Case standartıdır. Bu standartta ilk kelimenin ilk harfi küçük olup diğer kelimelerin ilk harfleri büyük olmaktadır.
            //Değişken isimlendirmesinde boşluk bırakılmaz.
            //Kodlar içerisinde altı kırmızı çizili kısımlar hata, yeşil çizili kısımlar ise uyarıdır.
            //Değişken isimlendirmede olabildikçe açık ifadeler kullanmalıyız.
            //Bir satırda aynı türden birden fazla değişken tanımlaması yapılabilir.
            //Programlama içerisinde kodlarımız sırasıyla çalışacağı için ilk yaptığımız atamalar ile Ali Çınar sonraki atama işlemimiz sonucunda da Ali Çınar kaydı yerine Ayşegül Kaya geçmektedir.




            #endregion
            #region int Değişkenler
            // Tam sayı için kullanacağımız değişkenlerimizi int türünde oluşturuyoruz.
            // Sayılsa değişkenlerimizin atama işlemlerinde sayıyı olduğu gibi yazıyoruz.

            //int-Örnek-1
            //int number = 24;
            //Console.WriteLine(number);  

            //int-Örnek-2
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger : " + hamburgerPrice + " TL ");
            Console.WriteLine("----- Pizza : " + pizzaPrice + " TL ");
            Console.WriteLine("----- Kola : " + cokePrice + " TL ");
            Console.WriteLine("----- Limonata : " + lemonadePrice + " TL ");
            Console.WriteLine("----- Kızartma : " + friesPrice + " TL ");
            Console.WriteLine("----- Su : " + waterPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();


            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadeCount = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadeCount = lemonadeCount * lemonadePrice;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("----- Hamburger Tutarı : " + totalHamburgerPrice + " TL ");
            Console.WriteLine("----- Kola Tutarı : " + totalCokePrice + " TL ");
            Console.WriteLine("----- Su Tutarı : " + totalWaterPrice + " TL ");
            Console.WriteLine("----- Kızartma Tutarı : " + totalFriesPrice + " TL ");
            Console.WriteLine("----- Pizza Tutarı : " + totalPizzaPrice + " TL ");
            Console.WriteLine("----- Limonata Tutarı : " + totalLemonadeCount + " TL ");
            Console.WriteLine();
            int totalPrice=totalHamburgerPrice+totalCokePrice+totalWaterPrice+totalFriesPrice+totalPizzaPrice+totalLemonadeCount;
            Console.WriteLine("----- Toplam Tutarı : " + totalPrice);

            #endregion
            Console.Read();
        }
    }
}


// Yazdırma Komutları.

// Yorum Satırı yapmak için // kullanılır.
