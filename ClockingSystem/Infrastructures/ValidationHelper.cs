using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockingSystem.Infrastructures
{
	public class ValidationHelper
	{
		public static bool Validate<T>(T model, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{

			//得知驗證規則
			ValidationContext context = new ValidationContext(model, null, null);

			//用來存放錯誤的集合，因為可能有多種錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			//this.errorProvider.Clear();
			errorProvider.Clear();
			bool ValidateAllProperties = true; //是否驗證所有規則，而非只驗證Required規則

			bool isValid = Validator.TryValidateObject(model, context, errors, ValidateAllProperties);

			if (!isValid)
			{
				DisplayErrorByErrorProvider(errors, map, errorProvider);
			}

			return isValid;
		}

		private static void DisplayErrorByErrorProvider(List<ValidationResult> errors, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault(); ;
				if (map.TryGetValue(propName, out Control ctrl))
				{
					errorProvider.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
	}
}
