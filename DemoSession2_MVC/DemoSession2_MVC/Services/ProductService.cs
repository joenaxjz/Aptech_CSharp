using DemoSession2_MVC.Models;

namespace DemoSession2_MVC.Services;

public interface ProductService
{
    public List<Product> findAll();
    public Product findId(int id);  
    public List<Product> search(string keyword);
    public List<Product> searchPrices (double min, double max);
    public List<Product> searchCreated(string date1, string date2);
}

