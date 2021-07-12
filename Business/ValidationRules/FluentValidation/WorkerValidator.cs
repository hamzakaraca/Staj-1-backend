using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class WorkerValidator : AbstractValidator<Worker>
    {
        public WorkerValidator()
        {
            RuleFor(wr => wr.FirstName).NotEmpty();
            RuleFor(wr => wr.LastName).MinimumLength(3);
        }
    }
}
