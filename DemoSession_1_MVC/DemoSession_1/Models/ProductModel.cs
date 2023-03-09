using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace DemoSession_1.Models;

public class ProductModel
{
    private List<Product> products;
    public ProductModel() {
        products = new List<Product>{
           new Product {
                Id = 1,
                Name = "Thanh Long",
                Photo = "pic1.jpg",
                Price = 8.9,
                Quantity = 2,
                Created = DateTime.Now
           },

           new Product {
                Id = 2,
                Name = "Chuoi",
                Photo = "pic2.jpg",
                Price = 7.5,
                Quantity = 14,
                Created = DateTime.Now
           },

           new Product {
                Id = 3,
                Name = "Mang Cut",
                Photo = "pic3.jpg",
                Price = 8.3,
                Quantity = 4,
                Created = DateTime.Now
           }

            };
    
    }
    public List<Product> findAll()
    {
        return products;
    }

    public Product find(int id)
    {
        return products.SingleOrDefault(prods => prods.Id == id);
    }

    public List<Product> search(string keyword)
    {
        return products.Where(pros => pros.Name.Contains(keyword)).ToList();
    }

    public List <Product> searchPrices(double min, double max)
    {
        return products.Where(prods => prods.Price<=max && prods.Price >=min ).ToList();
    }
}
