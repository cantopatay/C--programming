//operator overloading kullanımı (DateTime örneği)
using System;
class HelloWorld {
  static void Main() {
      DateTime baslangic = new DateTime();
      baslangic=DateTime.Now;             //Baslangıç zamanı oluşturduk
      for(int i=0;i<1000000000;i++){
                                          //burda işlem yapsın da zaman kaybı oluşsun diye yaptık              
      }
      DateTime bitis =new DateTime();
      bitis=DateTime.Now;                 //bitiş zamanı oluşturduk
    Console.WriteLine("baslangıç zamanı;"+baslangic); //burdaki + operatörü yazıyla DateTime özeliğini birlestirmiş 
    Console.WriteLine("bitiş zamanı:"+bitis);
    TimeSpan zamanfarkı= bitis-baslangic; //burdaki - operatörü zaman kaybını gösteriyor yani çıkarma işleminden farklı
    Console.WriteLine("gecen zaman:"+zamanfarkı);
  }
}