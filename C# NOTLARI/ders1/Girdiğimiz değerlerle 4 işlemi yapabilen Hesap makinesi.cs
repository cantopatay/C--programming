        //Girdiğimiz değerlerle 4 işlemi yapabilen Hesap makinesi
using System;
class HelloWorld {
    #region hesaplar
    static int topla(int a, int b)
    {
        return a+b;
    }
    static int çıkar(int a, int b)
    {
        return a-b;
    }
    static int çarp(int a, int b)
    {
        return a*b;
    }
    static int böl(int a, int b)
    {
        return a/b;
    }
    #endregion
  static void Main() {
    Console.WriteLine("Lütfen 1. sayıyı giriniz:");
    
    int sayi1=Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Lütfen 2. sayıyı giriniz:");
    
    int sayi2=Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Lütfen '+','-','*','/' işlemlerinden birini yazınız ");
    string islem=Console.ReadLine();
    double sonuc=0;
    switch(islem)
    {
        case "+":
        sonuc=topla(sayi1,sayi2);
        break;
        
        case"-":
        sonuc=çıkar(sayi1,sayi2);
        break;
        
        case"*":
        sonuc=çarp(sayi1,sayi2);
        break;
        
        case"/":
        sonuc=böl(sayi1,sayi2);
        break;
        
        default:
        Console.WriteLine("Hatalı işlem");
        break;
    }
    Console.WriteLine("Sonuç="+sonuc.ToString());
    Console.ReadKey();
    
  }
}
