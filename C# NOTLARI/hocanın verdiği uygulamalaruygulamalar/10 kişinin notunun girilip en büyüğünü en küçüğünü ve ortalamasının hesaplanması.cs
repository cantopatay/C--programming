/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() 
  {     
      // 10 kişinin notunun girilip en büyüğünü en küçüğünü ve ortalamasının hesaplanması
      int bs=0,ks=0,toplam=0;
    for(int a=0,b;a<10;a++)
           {
               Console.WriteLine(a+1+". sayiyi giriniz:");
               b=Convert.ToInt32(Console.ReadLine());
               if(b>100||b<0)
               {
                   Console.Write("Hatalı not girdiniz");
                   a--;
                   continue;
               }
               if(a==0)
               {
                   bs=b;
                   ks=b;
               }
               else
               {
                   if(b>bs)
                   bs=b;
                   if(b<ks)
                   ks=b;
               }
               toplam+=b;
           }
           Console.Write("En büyük:{0}\nEn küçük:{1}\nOrtalama:\n"+toplam/10,bs,ks);
  }
}
