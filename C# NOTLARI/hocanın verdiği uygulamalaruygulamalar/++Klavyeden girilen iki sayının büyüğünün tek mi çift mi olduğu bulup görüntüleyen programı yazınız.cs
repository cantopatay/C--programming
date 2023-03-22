//Klavyeden girilen iki sayının büyüğünün tek mi çift mi olduğu bulup görüntüleyen programı yazınız
using System;
class HelloWorld {
  static void Main() {
      int ks=0 , bs=0; int sayi;
      for(int a=0;a<2;a++)
      {
      Console.Write(a+1+". sayıyı giriniz:");
      sayi=Convert.ToInt32(Console.ReadLine());
      if(a==0)
         {
            ks=sayi;
            bs=sayi;
         }
      else{
             if(bs<sayi)
             bs=sayi;
          }
          
      }
      Console.Write("Büyük sayı:"+bs);
      Console.Write("\n");
      if(bs%2==0)
      Console.Write("Büyük sayı çifttir");
      else{
      Console.Write("Büyük sayı tektir");
      }
      
      
  }
}
