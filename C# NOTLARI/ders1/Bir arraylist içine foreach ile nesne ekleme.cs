using System;
using System.Collections;

class CollectionsDemo {
    public static void Main(String[] args) {
// Bir arraylist içine foreach ile nesne ekleme
        ArrayList futbol = new ArrayList(3);
        futbol.Add("cantopatay");
        futbol.Add("umutcan");
		
       

        foreach (string oyuncular in futbol) {
            Console.WriteLine(oyuncular);
        }

       
        
    }
}