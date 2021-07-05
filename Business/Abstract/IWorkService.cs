using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWorkService
    {
        IDataResult<List<Work>> GetAll();

        IDataResult<List<Work>> GetAllByWorkerId(int id);
        IDataResult<List<Work>> GetAllByState(string message);
        IDataResult<List<WorkDetailDto>> GetWorkDetails();
        IDataResult<Work> GetById(int workId);
        IResult Add(Work work);
        IResult Update(Work work);
        IResult Delete(Work work);

    }
}
