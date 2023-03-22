

        // List - IndexOf özelliği kullanımı 
        //istenilen değeri araştırma

using System;
using System.Collections.Generic;
//List özelliğinde using System.Collections.Generic kullanılır

class HelloWorld {
  static void Main() 
  {
    List<int> list= new List<int>(new int[] {45,56,23,10});
    int araştır=list.IndexOf(23); //varsa yerini gösterir
    Console.WriteLine(araştır);
    araştır=list.IndexOf(36);   //yoksa -1 olarak gözükür
    Console.WriteLine(araştır);
    Console.ReadKey();
  }
}
