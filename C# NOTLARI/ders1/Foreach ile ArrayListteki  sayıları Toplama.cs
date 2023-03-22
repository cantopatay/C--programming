using System;
using System.Collections;

class CollectionsDemo {
     static void Main() {
//  Foreach ile sayıları Toplama 
        ArrayList futbol = new ArrayList();
        futbol.Add(3);
        futbol.Add(6);
         
         int toplam=0;
         // Burda sadece foreach içinde dönüşüm yeterli olacaktır
        foreach(int i in futbol) 
        {
            toplam+= i;
            
        }
        Console.WriteLine(toplam);

       Console.ReadKey();
       
        
    }
}