using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Projeyi çalıştırmadan önce debug kısmından bu projeyi seçmemiz gerekiyor.

            #region Double Değişkenler
            //Double değişkenler ondalıklı sayılar için kullanılmaktadır.

            //Örnek-1
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Örnek-2
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine("---- Alınan Ürün : Elma      " + applePrice + " - Gramaj : " + appleGram + " - Toplam Tutar : " + appleTotalPrice);
            //Console.WriteLine("---- Alınan Ürün : Portakal  " + orangePrice + " - Gramaj : " + orangeGram + " - Toplam Tutar : " + appleTotalPrice);
            //Console.WriteLine("---- Alınan Ürün : Çilek     " + strawberryPrice + " - Gramaj : " + strawberryGram + " - Toplam Tutar : " + strawberryTotalPrice);
            //Console.WriteLine("---- Alınan Ürün : Patates   " + potatoPrice + " - Gramaj : " + potatoGram + " - Toplam Tutar : " + potatoTotalPrice);
            //Console.WriteLine("---- Alınan Ürün : Domates   " + tomatoPrice + " - Gramaj : " + tomatoGram + " - Toplam Tutar : " + tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutarı : " + shoppingTotalPrice + " TL");
            #endregion
            #region Char Değişkenler

            // metinsel değişken tanımlama türüdür.
            // string değişken atamalarında " " ile atama yaparken char türünde ' ' atama yapmaktayız.

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);


            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine(" **** Csharp Hava Yolları yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName =Console.ReadLine();
            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname =Console.ReadLine();
            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine(" ---------------------------- ");
            //Console.Write("Yolcu Adı Soyadı : " + passengerName + " " +  passengerSurname + " Adres Bilgisi : " +passengerDistrict +" / "+ passengerCity+ " Yaş :  " + passengerAge + " TC Kimlik No :  " + passengerIdentityNumber);



            #endregion
            #region Klavyeden Sam Sayı Girişleri ve Dönüşümler

            //klavyeden girdiğimiz değerler ilk olarak metinsel ifadeler olarak alınmaktadır.Bu yüzden dönüşüm yapmamız gerekiyor.

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen akdığınız ayakkabı sayısını giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısınız giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz : ");
            //chairCount= int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());    

            //int totalPrice = shoesCount*shoePrice + computerCount*computerPrice + chairCount*chairPrice +  tvCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar : " + totalPrice);

            #endregion
            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz : ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.Sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız : " + result);

            #endregion
            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz ( E / K ) :  ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);


            #endregion


            Console.Read();
        }
    }
}
