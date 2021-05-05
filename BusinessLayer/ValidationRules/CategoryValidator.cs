using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş olamaz!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklaması boş olamaz!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adı 3 karakterden daha az olamaz!");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori adı 20 karakterden daha fazla olamaz!");
        }
    }
}
    