                //İndexer Kullanımı
using System;
class Insan
{   string[] isimler=new string[10];
    
    #region indexer            //indexer oluşturuyoruz
    public string this[int i]  // this den sonra mutlaka parametre göstermek gerek
    {
        get{                    // indexer propertielerden oluşuyor
            return isimler[i];
           }
           
        set{
            isimler[i]=value;
           }
           
    }
    #endregion
}
class HelloWorld {
  static void Main() {
      Insan insan =new Insan();
      insan[3]="ahmet";
      insan [6]="murat";
      
    Console.WriteLine(insan[6]); // get sayesinde bu şekilde indexeri çağırabiliyoruz
    Console.WriteLine(insan[3]);
  }
}