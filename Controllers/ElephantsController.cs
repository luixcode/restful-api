using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using RESTfulAPI.Models;
using RESTfulAPI.Repository;
using Microsoft.AspNetCore.JsonPatch;

namespace RESTfulAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ElephantsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() => Ok(ElephantRepository.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetOne([FromRoute] int id)
        {
            Elephant elephant = ElephantRepository.GetOne(id);
            if (elephant == null)
            {
                return NotFound();
            }

            return Ok(elephant);
        }

        [HttpPost]
        public IActionResult Save(ElephantTargetBinding target)
        {
            Elephant elephant = target.ToElephant();            
            return Ok(ElephantRepository.Save(elephant));
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            Elephant elephant = ElephantRepository.Remove(id);
            if (elephant == null)
            {
                return NotFound();
            }

            return Ok(elephant);
        }

        [HttpPatch("{id}")]
        public IActionResult Update(int id, JsonPatchDocument<Elephant> jsonPatch)
        {
            Elephant elephant = ElephantRepository.GetOne(id);
            
            if (elephant == null)
            {
                return NotFound();
            }

            jsonPatch.ApplyTo(elephant);

            return Ok(elephant);
        }
    }
}