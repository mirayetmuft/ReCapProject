using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:User,IEntity  
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
