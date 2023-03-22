        //Statıc işleyişi 
using System;
class a{
    //static olmayan veri
    public int x=5;
    //static olan veri
    public static int y=6;
    
}
class program {
    //static olmayan veri2
    public int c=45;
    
  static void Main() {
      a nesne01 = new a();
      //static olmayan nesneyi böyle cağırdık
    Console.WriteLine(nesne01.x);
    //static olan nesneyi böyle çağırdık
    Console.WriteLine(a.y);
    //static olmayan veri2 yi böyle çağırdok
    program nesne02= new program();
    Console.WriteLine(nesne02.c);
  }
}