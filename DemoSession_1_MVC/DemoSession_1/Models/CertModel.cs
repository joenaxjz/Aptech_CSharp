namespace DemoSession_1.Models;

public class CertModel
{
    public List<Languages> findAll()
    {
        return new List<Languages>()
        {
            new Languages{ Id = 1, Name = "Cert 1"},
            new Languages{ Id = 2, Name = "Cert 2"},
            new Languages{ Id = 3, Name = "Cert 3"},
            new Languages{ Id = 4, Name = "Cert 4"},
            new Languages{ Id = 5, Name = "Cert 5"},
        };
    }
}
