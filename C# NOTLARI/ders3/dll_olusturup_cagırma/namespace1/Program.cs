using System;
using ornek;
// using ornek i çalıştırabilmek için namespace1.csproj un içine 
// <ItemGroup>
//   <Reference Include="MyAssembly">
//     <HintPath>buraya dll dosyasının konumu </HintPath>
//   </Reference>
// </ItemGroup>
//kodlarını yazmamız gerekli

namespace namespace1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 nesne1=new Class1(); // Class1 dll dosyasındaki sınıfın adı
            Console.WriteLine(nesne1.deger); //burda dll dosyasındaki degeri çagırdık
        }
    }
}
