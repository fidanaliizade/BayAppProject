using BayApp.Core.Entities;
using BayApp.DAL.Context;
using BayApp.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.DAL.Repositories.Implementations
{
    public class FeaturedRepository : Repository<Featured>, IFeaturedRepository
    {
        public FeaturedRepository(AppDbContext db) : base(db)
        {
        }
    }
}
