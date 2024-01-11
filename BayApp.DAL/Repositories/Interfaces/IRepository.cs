using BayApp.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.DAL.Repositories.Interfaces
{
    public interface IRepository <TEntity> where TEntity : BaseEntity, new()
    {
        public Task<IQueryable<TEntity>> GetAllAsync();
        public Task<TEntity> GetByIdAsync(int id);
        public Task Create(TEntity entity);
        public void Update(TEntity entity);
        public Task Delete(int id);
        public Task SaveChanges();
    }
}
