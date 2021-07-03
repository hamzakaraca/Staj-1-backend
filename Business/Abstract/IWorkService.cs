using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWorkService
    {
        List<Work> GetAll();

        List<Work> GetAllByWorkerId(int id);
        List<Work> GetAllByState(string message);
        List<WorkDetailDto> GetWorkDetails();
    }
}
