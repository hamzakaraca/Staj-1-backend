using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlansController : ControllerBase
    {
        IPlanService _planService;

        public PlansController(IPlanService planService)
        {
            _planService = planService;
        }
        public List<Plan> Get() 
        {
            var result = _planService.GetAll();
            return result.Data;
        }
    }
}
