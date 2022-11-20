using ClockingSystem.Infrastructures.DAOs;
using ClockingSystem.Models.DTOs;
using ClockingSystem.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockingSystem.Models
{
	public class UserService
	{
		public void Create(EmployeeDTO model)
		{
			//商業邏輯
			bool isExists = new EmployeeDAO().AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");
			new EmployeeDAO().Create(model);


			#region 轉到INFRA-DAO
			//string sql = @"INSERT INTO Users(Account, Password, Name) VALUES(@Account, @Password, @Name)";

			//var parameters = new SqlParametersBuilder()
			//					 .AddNvarchar("Account", 50, model.Account)
			//					 .AddNvarchar("Password", 50, model.Password)
			//					 .AddNvarchar("Name", 50, model.Name)
			//					 .Build();

			//new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			#endregion

		}

		//login的認證
		public bool Authenticate(LoginVM model)
		{
			var user = Get(model.Account);
			if (user == null) return false;

			return (user.Password == model.Password);
		}

		public EmployeeVM Get(string account)
		{
			string sql = @"SELECT *
						   FROM Employee
						   WHERE Account=@Account";

			var parameters = new SqlParametersBuilder().AddNVarchar("Account", 50, account)
													   .Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);


			if (data.Rows.Count == 0)
			{
				return null;
			}

			//將找到的一筆紀錄由DataTable轉換到UserVM
			return ToEmployeeVM(data.Rows[0]);
		}


		//轉成EmployeeVM
		public EmployeeVM ToEmployeeVM(DataRow row)
		{
			return new EmployeeVM
			{
				Id = row.Field<int>("Id"),
				Name = row.Field<string>("Name"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
			};
		}
	}

	
}
