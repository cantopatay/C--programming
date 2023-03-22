
        //Toplama işlemi Fonksiyon belirtme Metodları iki farklı metod örneği
using System;
class program
    {
        // Eğer sürekli fonksiyon kullanılacaksa bunu yapsak daha iyi olur
        //Hocanın Tavsiyesi bu 
        static int topla(int a, int b)
      {
        return a+b;
      }
        //Eğer bir kereliğine kullanıcaksak bunu kulanabiliriz
        static void void_topla(int a, int b)
        {
            Console.WriteLine(a+b);
        }
      static void Main() 
      { 
          //Birinci Fonksiyonun Çıktısı
        Console.WriteLine(topla(20,60));
        //İkinci Fonksiyonun çıktısı
        void_topla(10,45);
        Console.ReadKey();
      }
      
    }
