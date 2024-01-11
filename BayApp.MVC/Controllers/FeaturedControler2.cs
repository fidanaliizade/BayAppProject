using AutoMapper;
using BayApp.Business.Services.Interfaces;
using BayApp.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace BayApp.MVC.Controllers
{
	public class FeaturedControler2 : Controller
	{
		private readonly IFeaturedServices _service;
		private readonly AppDbContext _db;
		private readonly IMapper _mapper;

		public FeaturedControler2(IFeaturedServices service, AppDbContext db, IMapper mapper)
        {
			_service = service;
			_db = db;
			_mapper = mapper;
		}
        public async Task<IActionResult>  Index()
		{	
			return View();
		}
	}
}
