
            //Recursive Yöntemle Faktöriyel hesaplama
using System;
class HelloWorld {
    static int faktöriyel(int sayı)
    {
        if (sayı<=1) //Eğer Temel Durumsa 1 dönder
        return 1;
        else 
        return sayı*faktöriyel(sayı-1); //Temel durum değilse n*n-1 bul
    }
  static void Main() {
    Console.WriteLine("Lütfen Faktöriyeli hesaplanacak Sayıyı Giriniz");
    int n=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girdiğiniz Sayının Faktöriyeli="+faktöriyel(n));
  }
}
