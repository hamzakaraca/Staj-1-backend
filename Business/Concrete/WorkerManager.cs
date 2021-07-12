using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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

        public IResult Delete(Worker worker) 
        {
            _workerDal.Delete(worker);
            return new SuccessResult(Messages.WorkerDeleted);
        }
        public IDataResult<List<Worker>> GetAll()
        {
            return new SuccessDataResult<List<Worker>>(_workerDal.GetAll(),Messages.WorkersListed);
        }

        public IDataResult<Worker> GetById(int id)
        {
            return new SuccessDataResult<Worker>(_workerDal.Get(w=>w.WorkerId==id));
        }

        [ValidationAspect(typeof(WorkerValidator))]
        public IResult Add(Worker worker)
        {
            if (worker.FirstName.Length < 2)
            {
                return new ErrorResult();
            }
            else {
                _workerDal.Add(worker);
                return new SuccessResult(Messages.WorkerAdded);
            };
        }

        public IResult Update(Worker worker)
        {
            _workerDal.Update(worker);
            return new SuccessResult(Messages.WorkerUpdated);
        }
    }
}
