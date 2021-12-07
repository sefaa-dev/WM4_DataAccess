﻿using KuzeyCodeFirst.Data;
using KuzeyCodeFirst.Models.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyCodeFirst.Repository
{
    public abstract class RepositoryBase<T, TId> : IRepository<T, TId> where T : BaseEntity, new()
    {
        protected KuzeyContext _context;
        public DbSet<T> Table { get; protected set; }

        protected RepositoryBase()
        {
            _context = new KuzeyContext();
            Table = _context.Set<T>();
        }





        public virtual T GetById(TId id)
        {
            return Table.Find(id);
        }



        public virtual IQueryable<T> Get(Func<T, bool> predicate = null)
        {
            return predicate == null ? Table : Table.Where(predicate).AsQueryable();
        }

        public virtual IQueryable<T> Get(string[] includes,Func<T,bool> predicate = null)
        {
            IQueryable<T> query = Table;
            foreach (var include in includes)
            {
                query = Table.Include(include);
            }
            return predicate == null ? Table : Table.Where(predicate).AsQueryable();

        }


        public virtual void Add(T entity, bool isSavaLater = false)
        {
            Table.Add(entity);
            if (!isSavaLater)
                this.Save();


        }





        public virtual void Remove(T entity, bool isSavaLater = false)
        {
            Table.Remove(entity);
            if (!isSavaLater)
                this.Save();
        }



        public virtual void Update(T entity, bool isSavaLater = false)
        {
            Table.Update(entity);
            if (!isSavaLater)
                this.Save();
        }




        public virtual int Save()
        {
            return _context.SaveChanges();
        }


    }
}
