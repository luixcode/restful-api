using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using RESTfulAPI.CustomAttributes;
using RESTfulAPI.Models;

namespace RESTfulAPI.Models
{
    public class ElephantTargetBinding
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Affiliation { get; set; }
        [Required]
        public string Species { get; set; }
        [Sex]
        public string Sex { get; set; }

        public Elephant ToElephant()
        {
            return new Elephant
            {
                Name = Name,
                Affiliation = Affiliation,
                Species = Species,
                Sex = Sex
            };
        }
    }
}
