     //konuların uygulanması
class Daire{
    private int r;
    
    Daire(int _r){
        set_yaricap(_r);
    }
    Daire(){
        r=1;
    }
    void set_yaricap(int _r){
        if(_r<0)
        r=0;
        else 
        r=_r;
    }
    int get_yaricap(){
        return r;
    }
    double cevre_hesapla(){
        return 2*Math.PI* this.r;
    }
    double alan_hesapla(){
        return Math.PI*r*r;
    }
}       
//inheritance(kalıtım)
//Override etemeden direk yazabiliyoruz
class Kure extends Daire{
    double alan_hesapla(){
       // return 4*Math.PI*r*r; yaparsak çalışmaz çünkü r private olarak 
       //tanımlanmış bu yüzden doğrudan çağıramayız bunun için get_yaricap var
       return 4*Math.PI*get_yaricap()*this.get_yaricap();
    }
        
}
public class Main
{   
	public static void main(String[] args) {
		System.out.println("Merhaba java dünyası");
		Daire nesne01 = new Daire(6);
		System.out.println("Daire cevresi"+nesne01.cevre_hesapla());
	    System.out.println("Daire yaricap"+nesne01.get_yaricap());
	    
	    Kure nesne02 =new Kure();
	    System.out.println("Küre cevresi"+nesne02.cevre_hesapla());
	    System.out.println("Küre yaricap"+nesne02.get_yaricap());
	    System.out.println("Küre yaricap"+nesne02.alan_hesapla());

	} 
}
