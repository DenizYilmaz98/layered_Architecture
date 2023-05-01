using FluentValidation;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Validation_Rules
{
    public class WriterValidator:AbstractValidator<Writer>
    {

        public WriterValidator()
        {
            RuleFor(x => x.writerName).NotEmpty().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(x => x.writerMail).NotEmpty().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(x => x.writerPassword).NotEmpty().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(x => x.writerName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz");
            RuleFor(x => x.writerName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz");
            RuleFor(x => x.CCID).NotEmpty().WithMessage("Lütfen bu alanı boş geçmeyiniz");

        }

    }
}
