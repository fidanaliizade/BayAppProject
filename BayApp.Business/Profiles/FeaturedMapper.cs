using AutoMapper;
using BayApp.Business.ViewModels.FeaturedVMs;
using BayApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.Business.Profiles
{
	public class FeaturedMapper : Profile
	{
		public FeaturedMapper()
		{
			CreateMap<Featured, FeaturedCreateVM>();
			CreateMap<Featured, FeaturedCreateVM>().ReverseMap();
			CreateMap<Featured,FeaturedUpdateVM>();
			CreateMap<Featured, FeaturedUpdateVM>().ReverseMap();
			CreateMap<Featured, FeaturedListItemVM>();
			CreateMap<Featured, FeaturedListItemVM>().ReverseMap();
			CreateMap<FeaturedUpdateVM, FeaturedDetailVM>();
			CreateMap<FeaturedUpdateVM, FeaturedDetailVM>().ReverseMap();
		}
	}
}
