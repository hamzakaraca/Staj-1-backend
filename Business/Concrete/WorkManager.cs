using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WorkManager : IWorkService
    {
        //Burada herhangi bir dataaccess nesnesinin adının geçmeme nedeni bu projeye daha sonra farklı bir dataaccess nesnesi eklenecek olursa sistem duraksamasın diye.Bunun yerine tüm veri erişim nesenelerinin referansını tutabilen soyut sınıfı olan IWorkDal ı kullandım.
        IWorkDal _workDal;

        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        public List<Work> GetAll()
        {
            return _workDal.GetAll();
            
        }

        public List<Work> GetAllByState(string message)
        {
            return _workDal.GetAll(w=>w.State== message);
        }

        public List<Work> GetAllByWorkerId(int id)
        {
            return _workDal.GetAll(w => w.WorkerId == id);
        }
    }
}
