using System;

namespace ders5
{  public class Daire{
    private int r;
    public void set_yaricap(int _r)
    {
        if(_r<0)
        _r=0;
        
        r=_r;
    }
    //yaricapı tekrardan kullanabilmek için
    public int get_yaricap(){
          return r;
    }
    //cevre hesaplamam 
    public double cevre_hesapla(){
        return 2*Math.PI*r;
    }  

} 
    class Program
    {
        static void Main(string[] args)
        {
            Daire nesne01= new Daire();
            //eger public int r olsaydı r'ye ulaşmak için nesne01.r=5;  böyle yazabilirdik
            // ama private int r yazıyor
            nesne01.set_yaricap(3);
            Console.WriteLine( "cevresi:"+nesne01.cevre_hesapla());        
            
        }
    }
}