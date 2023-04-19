using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AnimalDTO
    {
        public AnimalDTO(int id, string name, string gender, string species, DateTime birthday, string origin, string description, string endangerment, int enclosure, string availability)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Species = species;
            this.Birthday = birthday;
            this.OriginContinent = origin;
            this.Description = description;
            this.Endangerment = endangerment;
            this.Enclosure = enclosure;
            this.Availability = availability;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Gender { get; private set; }

        public string Species { get; private set; }

        public DateTime Birthday { get; private set; }

        public string OriginContinent { get; private set; }

        public string Description { get; private set; }

        public string Endangerment { get; private set; }

        public int Enclosure { get; private set; }

        public string Availability { get; private set; }
    }
}
