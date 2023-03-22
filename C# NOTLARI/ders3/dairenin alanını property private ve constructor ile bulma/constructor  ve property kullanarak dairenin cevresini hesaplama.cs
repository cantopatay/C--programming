                //constructor kullanma
    using System;

namespace ders5
{  public class Daire{
    private int r;
    
    public Daire(int _r){  //constructor
        this.yaricapi= _r;
    }
    
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
            //constructor sayesinde yarıçapı böyle belirttik
            Daire nesne01= new Daire(4);
            //ccnstructor yapmasaydık nesne.yaricapi=4 yazardık propertie olduğundan
            Console.WriteLine("yaricapi:"+nesne01.yaricapi);
            Console.WriteLine( "cevresi:"+nesne01.cevresi);        
            
        }
    }
}