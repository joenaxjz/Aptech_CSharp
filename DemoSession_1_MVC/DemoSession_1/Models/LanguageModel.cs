namespace DemoSession_1.Models;

public class LanguageModel
{
    public List<Languages> findAll()
    {
        return new List<Languages>()
        {
            new Languages{ Id = 1, Name = "Lang 1"},
            new Languages{ Id = 2, Name = "Lang 2"},
            new Languages{ Id = 3, Name = "Lang 3"},
            new Languages{ Id = 4, Name = "Lang 4"},
            new Languages{ Id = 5, Name = "Lang 5"},
        };
    }
}
