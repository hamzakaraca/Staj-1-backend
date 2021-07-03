using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Plan:IEntity
    {
        public int PlanId { get; set; }
        public int WorkId { get; set; }
        public string Direction { get; set; }
    }
}
