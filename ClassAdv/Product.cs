using System;
//엔터 들어간거 기억??
namespace ClassAdv
{
    internal class Product
    {
        private string name;
        private int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        ~Product(){
            Console.WriteLine(this.name + "의 소멸자 호출");
        }
    }
}