using System;
                //Nesne Ürettik
public class kutu{
    public int x;
    
    public int y;
    
    public int z;
    //Eğer bu işlemi sürekli kullanıcaksak fonksiyon oluşturuyoruz
    public int hacim_hesapla()
    {
        return x*y*z;
    }
}
class HelloWorld {
  static void Main() {
                //Nesneye Sınıf Tanımladık
    kutu k01= new kutu();
    k01.x= 4;
    k01.y=8;
    k01.z=5;
     Console.WriteLine("k01'in Hacmi ="+k01.x*k01.y*k01.z);
    kutu k02= new kutu();
    k02.x= 9;
    k02.y=4;
    k02.z=3;
    Console.WriteLine("k02'nin Hacmi ="+k02.x*k02.y*k02.z);
    //Fonksiyonun Çğırılması
     Console.WriteLine("Fonksiyon özelliğiyle Hesaplanan k01sınıfın Hacmi ="+k01.hacim_hesapla());
     Console.WriteLine("Fonksiyon özelliğiyle Hesaplanan k02sınıfın Hacmi ="+k02.hacim_hesapla());
    
  }
}
