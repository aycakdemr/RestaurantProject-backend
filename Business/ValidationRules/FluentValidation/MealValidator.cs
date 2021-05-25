using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class MealValidator : AbstractValidator<Meal>
    {
        public MealValidator()
        {
            RuleFor(a => a.MealName).NotEmpty().WithMessage("yemek adı boş geçilemez");
            RuleFor(a => a.MealName).MinimumLength(2).WithMessage("yemek adı min iki karakter olmalı");
            RuleFor(a => a.MealPrice).GreaterThan(10).WithMessage("yemek fiyatı min on lira olmalı");
            RuleFor(a => a.MealImageId).NotEmpty().WithMessage("yemek fotoğrafı boş geçilemez");

        }
    }
}
