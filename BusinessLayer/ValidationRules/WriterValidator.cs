using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterNane).NotEmpty().WithMessage("Yazar adı boş olamaz!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Açıklaması boş olamaz!");
            RuleFor(x => x.WriterNane).MinimumLength(2).WithMessage("Yazar adı 2 karakterden daha az olamaz!");
            RuleFor(x => x.WriterNane).MaximumLength(50).WithMessage("Yazar adı 50 karakterden daha fazla olamaz!");
            RuleFor(x => x.WriterNane).Must(x => x.Contains("a")).WithMessage("Yazar adı içerisinde 'a' bulunmalı!");
        }
    }
}
