

        // List - Contains özelliği kullanımı 
        //List üzerinde arama yapar ve bool sonuç döndürür

using System;
using System.Collections.Generic;
using System.Linq;
//Contains Özelliğinde using System.Linq Kullanılır
//List özelliğinde using System.Collections.Generic kullanılır

class HelloWorld {
  static void Main() 
  {
      //List Oluşturma
    List<string> hayvanlar =new List<string>();
    hayvanlar.Add("kedi");
    hayvanlar.Add("köpek");
    hayvanlar.Add("aslan");
    
    //Arama
    if(hayvanlar.Contains("kedi"))
    {
      Console.WriteLine("Kedi Bulunuyor.");
    }
    //Arama Büyük Küçük harf Duyarsız
    if(hayvanlar.Contains("ASLAN",StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine("ASLAN bulundu (Ama büyük küçük harf ayırmaksızın.)");
    }
    
    if(hayvanlar.Contains("yılan"))
    {
      Console.WriteLine("yılan Bulunuyor.");
    }  
    else 
      {Console.WriteLine("yılan Bulunmuyor.");}
      
// bool değeri yani false true değeri döndürüyor
      Console.WriteLine(hayvanlar.Contains("fish"));
  }
}
