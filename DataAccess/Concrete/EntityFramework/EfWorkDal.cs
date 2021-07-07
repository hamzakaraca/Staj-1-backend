using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWorkDal : EfEntityRepositoryBase<Work, WorkCenterContext>, IWorkDal
    {
        public List<WorkDetailDto> GetWorkDetails()
        {
            using (WorkCenterContext context=new WorkCenterContext())
            {
                var result = from wo in context.Works
                             join we in context.Workers on wo.WorkerId equals we.WorkerId
                             select new WorkDetailDto {WorkId=wo.WorkId,WorkName=wo.WorkName,WorkerName=we.FirstName,ProgressStatus=wo.ProgressStatus,FinalDate=wo.FinalDate };
                return result.ToList();
            }
        }

        
    }
}
