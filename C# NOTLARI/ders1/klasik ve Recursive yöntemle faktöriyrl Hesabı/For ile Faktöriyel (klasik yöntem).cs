
                //For ile Faktöriyel (klasik yöntem)
using System;
class program {
   
  static void Main()
    {
        
        int faktöriyel=1;
        Console.WriteLine("Lütfen Faktöriyeli Alınacak sayıyı Giriniz:");
        int n=Convert.ToInt32(Console.ReadLine());
        for(int x=n;x>=1;x--)
        {
            faktöriyel*=x;
        }
        
       Console.WriteLine(n+" sayısının faktöriyeli="+faktöriyel);
        
    }
}
