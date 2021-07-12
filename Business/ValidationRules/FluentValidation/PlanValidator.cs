using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PlanValidator : AbstractValidator<Plan>
    {
        public PlanValidator()
        {
            RuleFor(p => p.Direction).MinimumLength(8);
            RuleFor(p => p.WorkId).NotEmpty();
            
        }
    }
}
