using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdv
{
    internal class Program
    {
        static void Main(string[] args)
        {

//소멸자 예시
Product product1 = new Product("과자", 1000);

Product product2 = new Product("아이스크림", 2000);
Product product3 = new Product("케이크", 3000);

//속성 (property) 실습
Box box = new Box(10, 10);
box.Width = 100;
box.Height = 100;
box.GetArea();

try
{
box.Width = -10;
}catch (Exception ex) 
{ 
Console.WriteLine(ex.Message);
}

        }
    }
}
