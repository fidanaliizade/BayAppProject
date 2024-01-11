using AutoMapper;
using BayApp.Business.Exceptions;
using BayApp.Business.Exceptions.Common;
using BayApp.Business.Services.Interfaces;
using BayApp.Business.ViewModels.FeaturedVMs;
using BayApp.Core.Entities;
using BayApp.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.Business.Services.Implementations
{
	public class FeaturedServices : IFeaturedServices
	{
		private readonly IFeaturedRepository _repository;
		private readonly IMapper _mapper;

		public FeaturedServices(IFeaturedRepository repository, IMapper mapper)
        {
			_repository = repository;
			_mapper = mapper;
		}
        public async Task Create(FeaturedCreateVM createVM)
		{
			var feature = _mapper.Map<FeaturedCreateVM, Featured>(createVM);
			await _repository.Create(feature);
			await _repository.SaveChanges();
		}

		public async Task Delete(int id)
		{
			if (id <= 0) throw new NegativeIdException();
			await _repository.Delete(id);
			await _repository.SaveChanges();
		}

		public async Task<IEnumerable<FeaturedListItemVM>> GetAll()
		{
			var features =  await _repository.GetAllAsync();
			return  _mapper.Map<IEnumerable<FeaturedListItemVM>>(features);
		}

		public async Task<FeaturedDetailVM> GetById(int id)
		{
			if(id<=0) throw new NegativeIdException();	
			var feature = await _repository.GetByIdAsync(id);
			return _mapper.Map<FeaturedDetailVM>(feature);
		}

		public async Task Update(FeaturedUpdateVM updateVM)
		{
			if (updateVM.Id <= 0) throw new NegativeIdException();
			if (_repository.GetByIdAsync(updateVM.Id) == null) throw new FeaturedNullException();
			var feature = await _repository.GetByIdAsync(updateVM.Id);
		    _repository.Update(_mapper.Map(updateVM, feature));
			await _repository.SaveChanges();

		}
	}
}
