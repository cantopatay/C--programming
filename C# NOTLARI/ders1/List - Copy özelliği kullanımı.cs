

        // List - Copy özelliği kullanımı

using System;
using System.Collections.Generic;
//List özelliğinde using System.Collections.Generic kullanılır

class HelloWorld {
  static void Main() 
  {
    int[] dizi = new int[3]; //Yeni bir 3lük dizi olusturduk
    dizi[0]=5;
    dizi[1]=8;
    dizi[2]=4;
    //List'e kopyalama işlemi
    List<int> list= new List<int>(dizi); 
    //List'in boyutunu Gösterme
    Console.WriteLine(list.Count);
  }
}
