using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class WorkDetailDto : IDto
    {
        public int WorkId { get; set; }
        public string WorkerName { get; set; }
        public string WorkName { get; set; }
        public string ProgressStatus { get; set; }
        public string FinalDate { get; set; }
    }
}
