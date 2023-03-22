using System;
using System.Collections;

class CollectionsDemo {
     static void Main() {
//  ArrayList ile sayıları toplama 
        ArrayList futbol = new ArrayList();
        futbol.Add(3);
        futbol.Add(6);
         
         int toplam=0;
        for(int i=0;i<futbol.Count;i++) 
        {
            // burda Array ı dönüştürme işlemi yaptık
            // futbol.count arraylistin değerini veriri yani boyutunu
            toplam+= (int) futbol[i];
            
        }
        Console.WriteLine(toplam);

       Console.ReadKey();
       
        
    }
}