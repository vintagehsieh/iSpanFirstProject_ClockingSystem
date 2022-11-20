using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockingSystem.Models
{
	public class LoginVM
	{
		[Required(ErrorMessage = "必須輸入帳號")]
		public string Account { get; set; }

		[Required(ErrorMessage = "必須輸入密碼")]
		public string Password { get; set; }
	}
}
