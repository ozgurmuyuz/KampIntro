using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } //ürün id si
        public int CategoryId { get; set; } //ürünün hangi kategoriye ait olduğu (foreign key)
        public string ProductName { get; set; }    //ürün adı
        public double UnitPrice { get; set; }   //ürün fiyatı
        public int UnitsInStock { get; set; }    //stok adedi

    }
}
