//Cuncstructor overloading kullanımı
using System;
public class X{
    private int m;
    public X(){
        m=0;
    }
    public X(int x){
        m=x;
    }
    public X(int x,int y){
        m=x+y;
    }
    public int get_x(){
        return m;
    }
}
class HelloWorld {
  static void Main() {
    X nesne1=new X();
    Console.WriteLine(nesne1.get_x());
    X nesne2=new X(5);
    Console.WriteLine(nesne2.get_x());
    X nesne3 =new X(8,9);
    Console.WriteLine(nesne3.get_x());

  }
}