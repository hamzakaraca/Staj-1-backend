using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EfWorkerDal : IWorkerDal
    {
        public void Add(Worker entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Worker entity)
        {
            throw new NotImplementedException();
        }

        public Worker Get(Expression<Func<Worker, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetAll(Expression<Func<Worker, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Worker entity)
        {
            throw new NotImplementedException();
        }
    }
}
