using ClockingSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockingSystem.Models.DTOs
{
	public class EmployeeDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
	}

	public static class EmployeeDTOExts
	{
		public static EmployeeVM ToEmployeeVM(this EmployeeDTO dto)
		{
			return new EmployeeVM
			{
				Id = dto.Id,
				Name = dto.Name,
				Account = dto.Account,
				Password = dto.Password,
			};
		}
	}
}
