﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Colour:IEntity
    {
        public int ColourId { get; set; }
        public string ColoursName { get; set; }
    }
}
