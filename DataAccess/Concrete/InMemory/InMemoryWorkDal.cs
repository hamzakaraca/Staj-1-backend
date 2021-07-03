using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryWorkDal:IWorkDal
    {
        //bellekte kontrol amaçlı oluşturulmuş bir sınıftır herhangi bir teknoloji kullanılmamıştır.Tamamen bellek bazlı çalıştım

        List<Work> _works;
        public InMemoryWorkDal() 
        {
            _works = new List<Work> {
                new Work{WorkId=1,WorkerId=1,WorkName="B YAZILIMI",ProgressStatus="%0",FinalDate= "10.11.2022"},
                new Work{WorkId=2,WorkerId=1,WorkName="A YAZILIMI",ProgressStatus="%100",FinalDate="10.06.2021"}
            };

        }

        public void Add(Work work)
        {
            _works.Add(work);
        }

        public void Delete(Work work)
        {
            //Burada çok uzun kodlardan kaçınmak için linq kullandım.
            Work workToDelete = _works.SingleOrDefault(w => w.WorkId == work.WorkId);
            _works.Remove(workToDelete);
        }

        public Work Get(Expression<Func<Work, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Work> GetAll()
        {
            return _works;
        }

        public List<Work> GetAll(Expression<Func<Work, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Work> GetAllByWorker(int workerId)
        {
            return _works.Where(w=>w.WorkId==workerId).ToList();
        }

        public List<WorkDetailDto> GetWorkDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Work work)
        {
            Work workToUpdate = _works.SingleOrDefault(w => w.WorkId == work.WorkId);
            workToUpdate.WorkerId = work.WorkerId;
            workToUpdate.WorkName = work.WorkName;
            workToUpdate.ProgressStatus = work.ProgressStatus;
            workToUpdate.FinalDate = work.FinalDate;
        }
    }
}
