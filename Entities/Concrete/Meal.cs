using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Meal : IEntity
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string MealName { get; set; }
        public int MealImageId { get; set; }
        public decimal MealPrice { get; set; }
    }
}