using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using RESTfulAPI.Models;
using RESTfulAPI.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Http;

namespace RESTfulAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ElephantsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() => Ok(ElephantRepository.GetAll());

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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