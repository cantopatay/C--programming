

        // List - Count ve Clear özelliği kullanımı

using System;
using System.Collections.Generic;
//List özelliğinde using System.Collections.Generic kullanılır

class HelloWorld {
  static void Main() {
    List<bool> list=new List<bool>();
    list.Add(true);
    list.Add(false);
    list.Add(true);
    Console.WriteLine("ilk boyutu="+list.Count); //3
    list.Clear();
    Console.WriteLine("list.Clear özelliğinden sonraki boyutu="+list.Count); //0
  }
}
