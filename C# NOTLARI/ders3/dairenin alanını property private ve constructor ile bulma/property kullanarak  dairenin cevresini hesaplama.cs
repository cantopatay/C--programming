                //property kullanma
    using System;

namespace ders5
{  public class Daire{
    private int r;
    //property kullanma 
    //property asla parantez kullanmaz asagıda yaricapi ile yazılan prophertydir
    public int yaricapi{
        set{    
            if(value<0) // burdaki value eşittirden sonra gelen anlamındadır
            r=0;
            else
            r=value;
        }
        get{
            return r;
        }
    }
    //property ile cevre hesaplama
    public double cevresi{
        get{return 2*Math.PI*r;}
    }  

} 
    class Program
    {
        static void Main(string[] args)
        {
            Daire nesne01= new Daire();
            //burda direk property sayesinde deger verebildik
            nesne01.yaricapi=4;
            //property sayesinde parantez kullanmadan belirtebildik
            Console.WriteLine("yaricapi:"+nesne01.yaricapi);
            Console.WriteLine( "cevresi:"+nesne01.cevresi);        
            
        }
    }
}