using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class WorkManager : IWorkService
    {
        //Burada herhangi bir dataaccess nesnesinin adının geçmeme nedeni
        //bu projeye daha sonra farklı bir dataaccess nesnesi eklenecek olursa
        //sistem duraksamasın diye.Bunun yerine tüm veri erişim nesenelerinin referansını
        //tutabilen soyut sınıfı olan IWorkDal ı kullandım.
        // dependency injection yaptım.
        IWorkDal _workDal;

        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        [SecuredOperation("work.add,admin")]
        [ValidationAspect(typeof(WorkValidator))]
        public IResult Add(Work work)
        {
            IResult result = BusinessRules.Run(CheckIfWorkNameExists(work.WorkName));
            if (result !=null)
            {
                return result;
            }
            _workDal.Add(work);
            return new SuccessResult(Messages.WorkAdded);
        }

        public IResult Delete(Work work)
        {
            _workDal.Delete(work);
            return new SuccessResult(Messages.WorkDeleted);
        }

        public IDataResult<List<Work>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Work>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Work>>(_workDal.GetAll(),Messages.WorksListed);
            
        }

        public IDataResult<List<Work>> GetAllByState(string message)
        {
            return new SuccessDataResult<List<Work>>(_workDal.GetAll(w=>w.ProgressStatus== message));
        }

        public IDataResult<List<Work>> GetAllByWorkerId(int id)
        {
            return new SuccessDataResult<List<Work>>(_workDal.GetAll(w => w.WorkerId == id));
        }

        public IDataResult<Work> GetById(int workId)
        {
            return new SuccessDataResult<Work>(_workDal.Get(w => w.WorkId == workId));
        }

        public IDataResult<List<WorkDetailDto>> GetWorkDetails()
        {
            return new SuccessDataResult<List<WorkDetailDto>>(_workDal.GetWorkDetails());
        }

        public IResult Update(Work work)
        {
            _workDal.Update(work);
            return new SuccessResult(Messages.WorkUpdated);
        }

        private IResult CheckIfWorkNameExists(string workName) 
        {
            var result = _workDal.GetAll(w => w.WorkName == workName).Any();
            if (result)
            {
                return new ErrorResult(Messages.WorkNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
