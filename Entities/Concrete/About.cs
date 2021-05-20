﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class About :IEntity
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public string Description { get; set; }
    }
}
