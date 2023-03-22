
using System;
using System.Collection.Generic;
// ref ve out kullanmadan birden fazla sonuç döndürme
class ogrenci{
    public int ogrencino;
    public string adsoyad;
    
    public ogrenci(int _ogrencino,string _adsoyad){
        ogrencino=_ogrencino;
        adsoyad=_adsoyad;
    }
    }
    class ogrenciler{
        List<ogrenci> liste= new List<ogrenci>();
        
        public void ekle(ogrenci ogr){
        liste.Add(ogr);
    }
    public ogrenci get_ogrenci(int i){
        return liste[i];
    }

class HelloWorld {
  static void Main() {
    ögrenciler nesne1=new ogrenciler();
    nesne1.ekle(new ogrenci(25,"Can"));
    nesne1.ekle(new ogrenci(45,"ali"));
    nesne1.ekle(new ogrenci(56,"memet"));
    nesne1.ekle(new ogrenci(74,"umut"));
    ogrenci nesne_ogr=nesne1.get_ogrenci(2);
    Console.WriteLine(nesne_ogr.adsoyad+","+nesne_ogr.ogrencino);
  }
}
