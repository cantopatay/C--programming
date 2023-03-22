                    //Ref ile Voidden DeğerDÖndürmek
using System;
class HelloWorld {
            //Amacı Void bir fonksiyondan değer döndürmemize yarıyor
    static void kareal(ref double a){
    a=a*a;
}

  static void Main() {
      double i=3.45;
      Console.WriteLine("double sayı:", i);
      kareal(ref i);  //burda i'ye değer atadı
    Console.WriteLine("Girdiğin Değerin Karesi:",i);
  }
}
