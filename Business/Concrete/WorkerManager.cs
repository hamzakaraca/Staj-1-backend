using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class WorkerManager : IWorkerService
    {
        IWorkerDal _workerDal;

        public WorkerManager(IWorkerDal workerDal)
        {
            _workerDal = workerDal;
        }

        public void add(Worker worker)
        {
            if (worker.FirstName.Length > 2)
            {
                _workerDal.Add(worker);
            }
            else { Console.WriteLine("ekleme başarısız"); } ;
        }

        public List<Worker> GetAll()
        {
            return _workerDal.GetAll();
        }

        public Worker GetById(int id)
        {
            return _workerDal.Get(w=>w.WorkerId==id);
        }
        
    }
}
