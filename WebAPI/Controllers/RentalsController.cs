using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        public class CustomersController : ControllerBase
        {
            IRentalService _rentalService;

            public CustomersController(IRentalService rentalService)
            {
                _rentalService = rentalService;
            }
            [HttpPost("add")]
            public IActionResult Add(Rental rental)
            {
                var result = _rentalService.Add(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }

            [HttpPost("delete")]
            public IActionResult Delete(Rental rental)
            {
                var result = _rentalService.Delete(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            [HttpPost("update")]
            public IActionResult Update(Rental rental)
            {
                var result = _rentalService.Add(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                var result = _rentalService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }

            [HttpGet("getbyId")]
            public IActionResult GetById(int Id)
            {
                var result = _rentalService.GetById(Id);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
        }
}
