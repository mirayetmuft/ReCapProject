
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
    public class ColoursController : ControllerBase
    {
        IColourService _colourService;

        public ColoursController(IColourService colourService)
        {
            _colourService = colourService;
        }
        [HttpPost("add")]
        public IActionResult Add(Colour colour)
        {
            var result = _colourService.Add(colour);
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
        public IActionResult Remove(Colour colour)
        {
            var result = _colourService.Delete(colour);
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
        public IActionResult Update(Colour colour)
        {
            var result = _colourService.Update(colour);
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
            var result = _colourService.GetAll();
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
            var result = _colourService.GetAllById(Id);
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
