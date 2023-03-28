using System.ComponentModel.DataAnnotations;

namespace DemoSession_1.Models;

public partial class Employee
{
	public string username { get; set; }

	public string password { get; set; }

	public string email { get; set; }

	public string? Website { get; set; }

	public int Age { get; set; }

	public string fullname { get; set; }
}
