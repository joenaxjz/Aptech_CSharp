using DemoSession2_MVC.Models;

namespace DemoSession2_MVC.Services;

public interface AccountService
{
    public List<Account> findAll();
    public bool login (string username, string password);
    public Account find(string username);
}
