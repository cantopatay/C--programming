              //out ile voidden Değer döndürme
using System;
class HelloWorld {
    static void Main() {
    bool a;
    int max=Max(6,8, out a);
    Console.WriteLine(a);
  }
    static int Max(int x, int y,out bool b)
    {
        if (x>y)
        b=true;
        else
        b=false;
             return Math.Max(x,y);
        
       
    }
  
}