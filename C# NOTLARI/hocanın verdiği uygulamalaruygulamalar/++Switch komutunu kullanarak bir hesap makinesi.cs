//Switch komutunu kullanarak bir hesap makinesi

using System;
class HelloWorld {
  static void Main() {
    int sayi1, sayi2;
   double sonuc = 0;
   string islem;
   
   Console.WriteLine("1. sayıyı giriniz.");
   sayi1 = Convert.ToInt32(Console.ReadLine());
   
   Console.WriteLine("/,*,+,- işlemlerinden birini giriniz.");
   islem = Console.ReadLine();
   
   Console.WriteLine("2. sayıyı giriniz.");
   sayi2 = Convert.ToInt32(Console.ReadLine());
   
   switch (islem)
            {
                case "/": sonuc = sayi1 / sayi2; break;
                case "*": sonuc = sayi1 * sayi2; break;
                case "+": sonuc = sayi1 + sayi2; break;
                case "-": sonuc = sayi1 - sayi2; break;
				default: Console.WriteLine("Yanlış işlem girdiniz!"); break;

            }
			
	Console.WriteLine("Sonuc: " + sonuc);
	
//islem değişkenine gelecek olan değer, case : kısmında yer alanlardan hangisiyse o komutu çalıştırır. 
// / gelirse sayıları böler. sonuc değişkenine atar.
// * gelirse sayıları çarpar. sonuc değişkenine atar.
// + gelirse sayıları toplar. sonuc değişkenine atar.
// - gelirse sayıları çıkartır. sonuc değişkenine atar.
  }
}
