using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PlanDetailDto:IDto
    {
        public int PlanId { get; set; }
        public string WorkName { get; set; }
        public string WorkerName { get; set; }
        public string ProgressStatus { get; set; }
        public string FinalDate { get; set; }
    }
}
