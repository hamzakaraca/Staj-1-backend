using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Work:IEntity
    {
        public int WorkId { get; set; }
        public int WorkerId { get; set; }
        public string WorkName { get; set; }
        public string State { get; set; }
        public string FinalDate { get; set; }
    }
}
