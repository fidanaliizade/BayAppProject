using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.Business.Exceptions
{
	public class FeaturedNullException : Exception
	{
		public FeaturedNullException():base("Featured can't be null.")
		{
		}

		public FeaturedNullException(string? message) : base(message)
		{
		}
	}
}
