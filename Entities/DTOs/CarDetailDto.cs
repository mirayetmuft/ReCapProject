﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public string BrandName { get; set; }
        public string CarName { get; set; }
        public string ColourName { get; set; }
        public double DailyPrice { get; set; }



    }
}
