using BayApp.Business.ViewModels.FeaturedVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.Business.Services.Interfaces
{
	public interface IFeaturedServices
	{
		public Task<IEnumerable<FeaturedListItemVM>> GetAll();
		public Task<FeaturedDetailVM> GetById(int id);
		public Task Create(FeaturedCreateVM createVM);
		public Task Update(FeaturedUpdateVM updateVM);
		public Task Delete(int id);	

	}
}
