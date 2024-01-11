﻿using BayApp.Core.Entities.Common;
using BayApp.DAL.Context;
using BayApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.DAL.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly AppDbContext _db;
        public DbSet<TEntity> Table;
        public Repository(AppDbContext db)
        {
            _db = db;
            Table=db.Set<TEntity>();
        }
        public async Task Create(TEntity entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await Table.FindAsync(id);
            entity.IsDeleted = true;
        }

 

        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            IQueryable<TEntity> query =  Table.Where(e=>!e.IsDeleted);
            return query;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task SaveChanges()
        {
            await _db.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            Table.Update(entity);
        }
    }
}
