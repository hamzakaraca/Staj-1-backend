using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWorkerService
    {
        IDataResult<List<Worker>> GetAll();
        IDataResult<Worker> GetById(int id);
        IResult Add(Worker worker);
        IResult Delete(Worker worker);
        IResult Update(Worker worker);
    }
}
