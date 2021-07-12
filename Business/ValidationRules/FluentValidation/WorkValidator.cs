using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class WorkValidator : AbstractValidator<Work>
    {
        public WorkValidator()
        {
            RuleFor(w => w.WorkName).NotEmpty();
            RuleFor(w => w.WorkName).MinimumLength(2);
            RuleFor(w => w.ProgressStatus).NotEmpty();
        }
    }
}
