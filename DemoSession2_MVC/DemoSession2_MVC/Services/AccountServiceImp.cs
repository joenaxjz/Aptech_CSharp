using DemoSession2_MVC.Models;

namespace DemoSession2_MVC.Services;

public class AccountServiceImp : AccountService
{
    private List<Account> accounts;
    public AccountServiceImp()
    {
        accounts = new List<Account>
        {
            new Account {
            username = "acc1",
            password = "$2b$10$LqQam9s4V70QNsX9VjltsOBSTd/lf8JFwyOcidJbTQO037lHM7pvW",
            fullname = "Tuan anh"
            },
            new Account {
            username = "acc2",
            password = "$2b$10$LqQam9s4V70QNsX9VjltsOBSTd/lf8JFwyOcidJbTQO037lHM7pvW",
            fullname = "Tuan anh1"
            },
            new Account {
            username = "acc3",
            password = "$2b$10$LqQam9s4V70QNsX9VjltsOBSTd/lf8JFwyOcidJbTQO037lHM7pvW",
            fullname = "Tuan anh333"
            }
        };
    }

    public Account find(string username)
    {
       return accounts.SingleOrDefault(acc => acc.username == username); 
    }

    public List<Account> findAll()
    {
        return accounts;
    }



    public bool login(string username, string password)
    {
        var account = accounts.SingleOrDefault(acc => acc.username == username);
        if (account != null) {
            return BCrypt.Net.BCrypt.Verify(password, account.password);
        }
        return false;       
    }
}
