using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWorkerService
    {
        List<Worker> GetAll();
        Worker GetById(int id);

        void add(Worker worker);
    }
}
