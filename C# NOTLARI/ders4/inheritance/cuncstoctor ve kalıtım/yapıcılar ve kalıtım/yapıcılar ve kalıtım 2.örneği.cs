
using System;
class ana{
    public ana(){
    Console.WriteLine("ana sınıfının parametre almayan yapıcı metodu");
                }    
    }
    class yavru:ana{}
class HelloWorld {
  static void Main() {
      yavru y =new yavru();
    
  }
}