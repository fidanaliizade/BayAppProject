using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.Business.ViewModels.UserVMs
{
	public class RegisterVM
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
	}

	public class RegisterVMValidation: AbstractValidator<RegisterVM>
	{
		public RegisterVMValidation()
		{
			RuleFor(r=>r.Name).NotEmpty();
			RuleFor(r=>r.Surname).NotEmpty();
			RuleFor(r=>r.UserName).NotEmpty();
			RuleFor(r=>r.Email).EmailAddress().NotEmpty();
			RuleFor(p => p.Password).NotEmpty().WithMessage("Password is required.");
			
			RuleFor(r => r).Must(r => r.ConfirmPassword == r.Password).WithMessage("Password and confirmpassword must be same.");
		}
	}

}
