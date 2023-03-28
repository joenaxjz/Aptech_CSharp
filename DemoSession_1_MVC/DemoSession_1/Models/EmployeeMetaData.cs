using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DemoSession_1.Models;

public class EmployeeMetaData
{
	

	[MinLength(3)]
	[MaxLength(20)]
	[Required]
	public string username { get; set; }

	[Required]
	[RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
	public string password { get; set; }

	[EmailAddress]
	[Required]
	public string email { get; set; }

	[Url]
	public string? Website { get; set; }

	// giới hạn độ tuổi từ 18 đến 60
	[Range(18, 60)]
	public int Age { get; set; }

	[Required]
	public string fullname { get; set; }
}
[ModelMetadataType(typeof(EmployeeMetaData))]
public partial class Employee
{

}
