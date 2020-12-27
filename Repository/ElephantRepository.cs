using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RESTfulAPI.Models;

namespace RESTfulAPI.Repository
{
    public static class ElephantRepository
    {
        private static List<Elephant> _elephants;
        private static int _index = 0;

        static ElephantRepository()
        {
            List<Elephant> seedData = new List<Elephant>
            {
                new Elephant
                {
                    Id = ++_index,
                    Name = "Balarama",
                    Affiliation = "Dasara",
                    Species =  "Asian",
                    Sex = "Male"
                },
                new Elephant
                {
                    Id = ++_index,
                    Name = "Black Diamond",
                    Affiliation = "Al G. Barnes Circus",
                    Species =  "Asian",
                    Sex = "Male"
                },
                new Elephant
                {
                    Id = ++_index,
                    Name = "Isilo",
                    Affiliation = "Tembe Elephant Park",
                    Species =  "African",
                    Sex = "Male"
                }
            };
            _elephants = new List<Elephant>(seedData);            
        }

        public static Elephant GetOne(int id) => _elephants.Find(e => e.Id == id);

        public static List<Elephant> GetAll() => _elephants;

        public static Elephant Save(Elephant elephant) 
        {
            elephant.Id = ++_index;

            _elephants.Add(elephant);

            return elephant;
        }        

        public static Elephant Remove(int id) 
        {
            Elephant elephant = GetOne(id);
            _elephants.Remove(elephant);

            return elephant;
        } 
    }
}
