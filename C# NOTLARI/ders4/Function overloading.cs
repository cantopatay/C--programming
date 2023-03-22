            //Function  overloading
using System;
public class islem{
    #region parametre sayısının farklı olması
    //parametre sayısı farklı
    public int topla(){
        return 0;
    }
    public int topla(int sayi){
        return sayi;
    }
    public int topla(int sayi1,int sayi2){
        return sayi1+sayi2;
    }
    public int topla(int sayi1,int sayi2, int sayi3){
        return sayi1+sayi2+sayi3;
        }
    #endregion
    
    #region parametre türlerinin farklı olması
    //parametre türü farklı
    public int topla(string x){
        return Convert.ToInt32(x);
    }
    public int topla(string sayix, int sayi2){
        return Convert.ToInt32(sayix)+sayi2;
    }
    public int topla(int[] y){
        int t=0;
        for(int i=0;i<y.Length;i++)
            t+=y[i];
        
        return t;
    }
    #endregion
    
    // Aynı parametrelerin kullanılmaması dikkat edinilmeli mesela
    // public int topla(string sayix, int sayi2){
    //     return Convert.ToInt32(sayix)+sayi2;}
    // ve 
    // public double topla(string sayix, int sayi2){
    //     return(double) (Convert.ToDouble(sayix)+sayi2);}
    //bu çalışmaz
    
    
}
class HelloWorld {
  static void Main() {
      //Function overloadinglerin çağırılması
      islem _i =new islem();
    Console.WriteLine(_i.topla());
    Console.WriteLine(_i.topla(3));
    Console.WriteLine(_i.topla(4,5));
    Console.WriteLine(_i.topla(4,5,6));
    Console.WriteLine(_i.topla("4"));
    Console.WriteLine(_i.topla("4",6));
    int[] sayilar={2,4,5,6,8,3,9};
    Console.WriteLine(_i.topla(sayilar));
  }
}