using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExitFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncrementoSalarialController : ControllerBase
    {
       
       private readonly IBaseService<IncrementoSalarial> _service;

       public IncrementoSalarialController(IBaseService<IncrementoSalarial> service)
       {
            _service = service;
       }

       [HttpGet]
       public async Task<ActionResult<IEnumerable<IncrementoSalarial>>> Get()
       {
           IEnumerable data = await _service.Find();
           return Ok(data);

       }
        
    }
}