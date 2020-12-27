using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulAPI.Models
{
    public class Elephant
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Affiliation { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }        
    }
}