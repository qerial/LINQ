using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    public class ProductData
    {
        public static readonly List<Product> products = new List<Product>()
        {
            new Product() 
            {Id = 1, Name = "Kala",
                Category = "Liha",
                Price = 5.99, Amount = 2 },
            new Product() {            
            Id = 2, Name = "Kana",
                Category = "Liha",
                Price = 4.39, Amount = 2 },
            new Product() {           
            Id = 3, Name = "Kirves",
                Category = "Tööriistad",
                Price = 120, Amount = 1 },
            new Product() {          
            Id = 4, Name = "Blender",
                Category = "Köögimasinad",
                Price = 55, Amount = 1 },
            new Product() {          
            Id = 5, Name = "Sprite",
                Category = "Joogid",
                Price = 2, Amount = 3 },
            new Product() {          
            Id = 6, Name = "Banaan",
                Category = "Puuviljad",
                Price = 0.40, Amount = 6 },
            new Product() {          
            Id = 7, Name = "Kodujuust",
                Category = "Piimatooted",
                Price = 1.69 , Amount = 4 },
            new Product() {            
            Id = 8, Name = "Monster",
                Category = "Energia joogid",
                Price = 2, Amount = 2},
            new Product() {         
            Id = 9, Name = "Hp hiir",
                Category = "Arvuti",
                Price = 7.99, Amount = 1 },
            new Product() {            
            Id = 10, Name = "Dell monitor",
                Category = "Arvuti",
                Price = 110, Amount = 1 },
        };
    }
}
