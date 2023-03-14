namespace DemoSession_1.Models;

public class RoleModel
{
	public List<Role> findAll()
	{
		return new List<Role>()
		{
			new Role{ Id = 1, Name = "Admin"},
			new Role{ Id = 2, Name = "Emp1"},
			new Role{ Id = 3, Name = "Emp2"},
			new Role{ Id = 4, Name = "Emp3"},
			new Role{ Id = 5, Name = "Manager"},
		};
	}
}
