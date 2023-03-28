using DemoSession2_MVC.Models;
using System.Globalization;

namespace DemoSession2_MVC.Services;


public class ProductServiceImp : ProductService
{
    private List<Product> products;
    public ProductServiceImp()
    {
        products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "banana",
                Image = "img1.jpg",
                Price = 10.3,
                Created = DateTime.ParseExact("20/07/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),
            },
             new Product()
            {
                Id = 2,
                Name = "dragon fruit",
                Image = "img2.jpg",
                Price = 8.3,
                Created = DateTime.ParseExact("14/08/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),
            },
              new Product()
            {
                Id = 3,
                Name = "product 3",
                Image = "img3.jpg",
                Price = 17.3,
                Created = DateTime.ParseExact("05/11/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),
            }
        };
    }


    public List<Product> findAll()
    {
        return products;
    }

    public List<Product> search(string keyWord)
    {
        return products.Where(p => p.Name.Contains(keyWord)).ToList();
    }
    public List<Product> searchPrices(double min, double max)
    {
        return products.Where(prods => prods.Price <= max && prods.Price >= min).ToList();
    }

    public List<Product> searchCreated(string date1, string date2)
    {
        var from = DateTime.ParseExact(date1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        var to = DateTime.ParseExact(date2, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        return products.Where(pro => pro.Created >= from && pro.Created <= to).ToList();

    }
    public Product findId(int id )
    {
        return products.SingleOrDefault(pro => pro.Id == id);
    }
}