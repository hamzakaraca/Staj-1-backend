using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWorkDal : IWorkDal
    {
       
        public void Add(Work entity)
        {
            //Burada performans kazancı olsun belleği çok oyalamasın diye böyle bir yol izledim.
            using (WorkCenterContext context = new WorkCenterContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }


        public void Delete(Work entity)
        {
            using (WorkCenterContext context = new WorkCenterContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Work Get(Expression<Func<Work, bool>> filter)
        {
            using (WorkCenterContext context = new WorkCenterContext())
            {
                return context.Set<Work>().SingleOrDefault(filter);
            }
        }

        public List<Work> GetAll(Expression<Func<Work, bool>> filter = null)
        {
            using (WorkCenterContext context = new WorkCenterContext())
            {
                return filter == null ? context.Set<Work>().ToList() : context.Set<Work>().Where(filter).ToList();
            }
        }
        public void Update(Work entity)
        {
            using (WorkCenterContext context = new WorkCenterContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
