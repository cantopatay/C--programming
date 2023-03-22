using System;
using System.Collections;

class CollectionsDemo {
     static void Main() {
// For ile ArrayList görüntüleme
        ArrayList futbol = new ArrayList(3);
        futbol.Add(3);
        futbol.Add(6);
		
       

        for(int i=0;i<futbol.Count;i++) 
        {
            Console.WriteLine(futbol[i]);
        }

       Console.ReadKey();
       
        
    }
}