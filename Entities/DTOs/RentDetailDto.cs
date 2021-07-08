using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentDetailDto:IDto
    {
       
        public string CarName { get; set; }
        public string CarDetail { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnTime { get; set; }

    }
}
