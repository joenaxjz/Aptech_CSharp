using System.Reflection.Metadata;

namespace DemoSession_1.Models;

public class Account
{
    public int Id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string description { get; set; }
    public string detail { get; set; }
    public string gender { get; set; }
    public DateTime Dob { get; set; }
    public string certId { get; set; }
    public int[] langIds { get; set; }
    public int roleId { get; set; }
    public bool status { get; set; }
    public Address address { get; set; }
}
