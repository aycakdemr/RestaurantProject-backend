using Business.Concrete;
using DataAccess.Concrete;

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
    public class MenusController : ControllerBase
    {
        MenuManager menuManager = new MenuManager(new EfMenuDal());

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = menuManager.getall();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
