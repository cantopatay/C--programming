//Farklı iki namespacenin kullanımı
using System;
// namespaceler farklı oldugundan bunu yazıyoruz
using sekil;
namespace namespace2
{
    class Program
    {
        static void Main(string[] args)
        {
            daire nesne01=new daire();
            Console.WriteLine(nesne01.r);
        }
    }
}
