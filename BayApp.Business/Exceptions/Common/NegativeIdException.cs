using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.Business.Exceptions.Common
{
	public class NegativeIdException : Exception
	{
		public NegativeIdException():base("Id can't be null.")
		{
		}

		public NegativeIdException(string? message) : base(message)
		{
		}
	}
}
