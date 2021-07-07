using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPlanDal : EfEntityRepositoryBase<Plan, WorkCenterContext>, IPlanDal
    {
        public List<PlanDetailDto> GetPlanDetails()
        {
            using (WorkCenterContext context = new WorkCenterContext())
            {
                var result = from p in context.Plans
                             join wo in context.Works on p.WorkId equals wo.WorkId
                             join we in context.Workers on p.WorkerId equals we.WorkerId
                             select new PlanDetailDto {PlanId=p.PlanId, WorkName = wo.WorkName , ProgressStatus = wo.ProgressStatus, FinalDate = wo.FinalDate,WorkerName=we.FirstName+" "+we.LastName };
                return result.ToList();
            }
            
        }
    }
}
