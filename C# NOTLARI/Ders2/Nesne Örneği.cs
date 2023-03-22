            //Araba Sınıfını ve özelliklerini tanımlama
using System;
class HelloWorld {
    public class araba{
        private double yakit;
        private int hız;
        
        //Cunstructor oluşturduk class ismiyle aynı olmak zorunda yani araba yazılacak
        public araba(double ı,int o ){
            yakit=ı;
            hız=o;
        }
        //Yakıt alt ve üst sınırı belirleme
        public void set_yakıt(double y){
            if(y>60)
            y=60;
            if(y<0)
            y=0;
            yakit=y;
        }
        //Hız alt ve üst sınırı belirleme
        public void set_hız(int h){
            if(h>200)
            h=200;
            if (h<0)
            h=0;
            hız=h;
        }
        //yakıt doldurma komutu ve yakıt miktarı aşması durumunda set_yakıt fonksiyonunu çağırma
        public void yakit_yukle(double a){
            a=yakit+a;
            set_yakıt(a);
        }
        //yakıt durumunu görme
        public double get_yakıt()
        {
            return yakit;
        }
        //Hız Durumunu görme
        public int get_hız()
        {
            return hız;
        }
        public string göster()
        {
            return "Yakıt durumu:"+yakit.ToString()+ "Hız durumu:"+hız.ToString();
        }
        public void sur(){
            if(hız<50)
            yakit-=3;
            else if(hız<90)
            yakit-=1;
            else if(hız<140)
            yakit-=2;
            else if(hız<180)
            yakit-=3;
            else 
            yakit-=4;
            
            set_yakıt(yakit);
        }
    }
  static void Main() {
      //Sınıf içinde iki tane nesne Çıkardık
    araba nesne1=new araba(50,80);
    Console.WriteLine("ilk aracın "+nesne1.göster());
    nesne1.sur();
    Console.WriteLine("ilk aracın "+nesne1.göster());
    //Hızını Değiştirdik
    nesne1.set_hız(90);
    nesne1.sur();
    Console.WriteLine("ilk aracın "+nesne1.göster());
    nesne1.set_hız(120);
    nesne1.sur();
    Console.WriteLine("ilk aracın "+nesne1.göster());
    nesne1.set_hız(220);
    nesne1.sur();
    Console.WriteLine("ilk aracın "+nesne1.göster());
    
    araba nesne2=new araba(24,60);
    Console.WriteLine("ikinci aracın"+nesne2.göster());
    nesne2.sur();
    Console.WriteLine("ikinci aracın"+nesne2.göster());
    nesne2.set_hız(90);
    nesne2.sur();
    Console.WriteLine("ikinci aracın"+nesne2.göster());
    nesne2.set_hız(120);
    nesne2.sur();
    Console.WriteLine("ikinci aracın"+nesne2.göster());
    nesne2.set_hız(220);
    nesne2.sur();
    Console.WriteLine("ikinci aracın"+nesne2.göster());
  }
}
