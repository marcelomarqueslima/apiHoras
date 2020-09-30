using ApiHorasDomain.Shared;
using ApiHorasInfraData.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiHorasInfraData.Repositories
{
    public class BaseRepository<T, B> where T : EntityBase<B>
    {
        protected readonly ApiHorasContext _context;

        public BaseRepository(ApiHorasContext context)
        {
            _context = context;
        }

        protected virtual void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        protected virtual void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        protected virtual void Delete(Guid id)
        {
            _context.Set<T>().Remove(Select(id));
            _context.SaveChanges();
        }

        protected virtual T Select(Guid id) => _context.Set<T>().Find(id);

        protected virtual IList<T> Select() => _context.Set<T>().ToList();
    }
}
