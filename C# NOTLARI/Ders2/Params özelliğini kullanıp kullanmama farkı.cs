
        //params Kullanmak
using System;
class HelloWorld {
static int parametre(params int[] değerler)
{   
     //toplama işlemi
     int toplam=0;
    foreach(int değer in değerler)
    {       
       toplam+=değer;    
    }
 
    return toplam;
}

  static void Main() {
      //Farklı toplamaişlemi parametre sayısına dikkat
    int a=parametre(2,5,3,2);
    int b=parametre(4,6,7,8);
    int c=parametre(7,4,0);
    
    // Eğer Params kullanmazsak uzun uzun belirtmek gerekiyor
    //  int a=parametre(new int[]={2,5,3,2});
    // int b=parametre(new int[]={5,7,3});
    // int c=parametre(new int[]={7,5,0});
    
    // sonuçlar gösteriliyor
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    
  }
}
