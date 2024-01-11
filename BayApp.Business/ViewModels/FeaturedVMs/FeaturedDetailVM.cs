using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.Business.ViewModels.FeaturedVMs
{
	public class FeaturedDetailVM
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string? Icon { get; set; }

	}

	public class FeaturedDetailVMValidation : AbstractValidator<FeaturedCreateVM>
	{
		public FeaturedDetailVMValidation()
		{
			RuleFor(x => x.Title).NotEmpty().MaximumLength(70);
			RuleFor(x => x.Description).NotEmpty().MaximumLength(70);
		}
	}
}

