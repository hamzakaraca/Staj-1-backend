using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPlanService
    {
        IResult Add(Plan plan);
        IResult Delete(Plan plan);
        IResult Update(Plan plan);
        IDataResult<List<PlanDetailDto>> GetPlanDetail();
        IDataResult<List<Plan>> GetAll();
        IDataResult<Plan> GetById(int planId);
    }
}
