using System;
class program {
    //harici veri
    public int x=90;
    //static veri
    public static int y=90;
    
    public const double E=2.7;
    public readonly double F=1.1;
    public readonly static double G=1.8;
    
  static void Main() {
    program _p=new program();
    
    Console.WriteLine(_p.x);//Nesne oluşturup çağırdık bellek daha etkin kullanılır
    Console.WriteLine(program.y);//Nesneoluşturulmadan çağırdık
    Console.WriteLine(program.E);//const ifade direk statictir
    Console.WriteLine(_p.F);//readonly bir ifade static değilse nesne üzerinden çağırılır
    Console.WriteLine(program.G);//readonly bir ifade static ise ddirek çağrılır
    
  }
}