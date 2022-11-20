using ClockingSystem.Models.DTOs;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockingSystem.Infrastructures.DAOs
{
	public class EmployeeDAO
	{
		//取得所有東西
		public IEnumerable<EmployeeDTO> GetAll()
		{
			string sql = @"SELECT * FROM Eployee ORDER BY ID ASC";

			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, null)
						   .AsEnumerable()
						   .Select(row => ToEmployeeDTO(row));
		}

		//轉成EmployeeDTO
		public EmployeeDTO ToEmployeeDTO(DataRow row)
		{
			return new EmployeeDTO
			{
				Id = row.Field<int>("id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name")
			};
		}

		//帳號存在
		public bool AccountExists(string account)
		{
			string sql = @"SELECT COUNT(*) as count 
                           FROM Employee
                           WHERE Account=@Account AND Id != id";

			var parameters = new SqlParametersBuilder().AddNVarchar("account", 50, account).Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			return data.Rows[0].Field<int>("count") > 0;
		}
		
		//建立
		public void Create(EmployeeDTO model)
		{
			string sql = @"INSERT INTO Users(Account, Password, Name) VALUES(@Account, @Password, @Name)";

			var parameters = new SqlParametersBuilder().AddNVarchar("Name", 50, model.Name)
													   .AddNVarchar("Account", 50, model.Account)
													   .AddNVarchar("Password", 50, model.Password)
												       .Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
