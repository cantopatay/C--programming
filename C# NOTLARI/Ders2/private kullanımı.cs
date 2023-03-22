
                //private Kullanımı
using System;
class kutu
{
    private double length;
    private double breadth;
    private double height;
    public void setLength(double len){
        length=len;
    }
    public void setBreadth(double bre){
        breadth=bre;        
    }
    public void setHeight(double hei){
        height=hei;
    }
    public double hacim(){
        return length*breadth*height;
    }
}
class kutunun_testi {
  static void Main() {
    kutu kutu1=new kutu();
    kutu kutu2=new kutu();
    
    //Nesne 1YordamÜzerinden 
    kutu1.setLength(6.0);
    kutu1.setBreadth(7.0);
    kutu1.setHeight(9.0);
    
    //Nesne 2YordamÜzerinden 
    kutu2.setLength(7.0);
    kutu2.setBreadth(8.0);
    kutu2.setHeight(5.0);
    
    Console.WriteLine("1. Kutunun hacmi="+kutu1.hacim());
    Console.WriteLine("2. Kutunun hacmi="+kutu2.hacim());
    
  }
}
