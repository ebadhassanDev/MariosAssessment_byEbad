using MariosAssessment_byEbad.Interface;
using MariosAssessment_byEbad.Sql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosAssessment_byEbad.Repository
{
    public class RepositoryService<T> : IRepository<T> where T : class
    {
        private readonly SqlContext _sqlContext;
        public RepositoryService(SqlContext context)
        {
            _sqlContext = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _sqlContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _sqlContext.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _sqlContext.Set<T>().Add(entity);
            _sqlContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _sqlContext.Set<T>().Update(entity);
            _sqlContext.SaveChanges();
        }

        public void Delete(int id)
        {
            T entityToDelete = GetById(id);
            if (entityToDelete != null)
            {
                _sqlContext.Set<T>().Remove(entityToDelete);
                _sqlContext.SaveChanges();
            }
        }
    }
}
