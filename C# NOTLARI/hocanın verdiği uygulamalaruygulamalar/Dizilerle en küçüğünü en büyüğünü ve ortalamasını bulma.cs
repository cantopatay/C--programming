/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      //  Dizilerle en küçüğünü en büyüğünü ve ortalamasını bulma
      //dizi.Length anlamı dizinin boyu kadar demek.
    int[] dizi={4,6,67,80,45,67,6,87}; 
		int ks= 0, bs=0, toplam=0;
		for(int a=0; a<dizi.Length; a++)
		{
			toplam+=dizi[a];
		
			if(a==0)
			{
			ks=dizi[a];
			bs=dizi[a];
			continue;
	   		}
			if(ks>dizi[a])
				ks=dizi[a];
			if(bs<dizi[a])
				bs=dizi[a];
		 }	
		Console.WriteLine("Küçük sayı:"+ks);
		Console.WriteLine("büyük sayı:"+bs);
		Console.WriteLine("Ortalama:"+toplam/dizi.Length);
  }
}
