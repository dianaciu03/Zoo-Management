using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLibrary;

namespace ZooBazaarLogicLibrary
{
    public class AnimalManagement
    {
        DatabaseAnimalHelper helper;

        public AnimalManagement()
        {
            helper = new DatabaseAnimalHelper();
        }

        public Animal DTOToAnimal(AnimalDTO animalDTO)
        {
            return new Animal(
                    animalDTO.Id,
                    animalDTO.Name,
                    animalDTO.Gender,
                    animalDTO.Species,
                    animalDTO.Birthday,
                    (ORIGINCONTINENT)Enum.Parse(typeof(ORIGINCONTINENT), animalDTO.OriginContinent),
                    animalDTO.Description,
                    (ENDANGERMENT)Enum.Parse(typeof(ENDANGERMENT), animalDTO.Endangerment),
                    animalDTO.Enclosure,
                    animalDTO.Availability);
        }

        public AnimalDTO AnimalToDTO(Animal animal)
        {
            return new AnimalDTO(
                    animal.Id,
                    animal.Name,
                    animal.Gender,
                    animal.Species,
                    animal.Birthday,
                    animal.OriginContinent.ToString(),
                    animal.Description,
                    animal.Endangerment.ToString(),
                    animal.Enclosure,
                    animal.Availability);
        }

        public int NewAnimaID()
        {
            return helper.NewAnimalID();
        }

        private List<Animal> DTOToAnimals(List<AnimalDTO> animalsDTO)
        { 
            List<Animal> animals = new List<Animal>();

            foreach(AnimalDTO animalDTO in animalsDTO)
            {
                Animal animal = new Animal(
                    animalDTO.Id,
                    animalDTO.Name,
                    animalDTO.Gender,
                    animalDTO.Species,
                    animalDTO.Birthday,
                    (ORIGINCONTINENT)Enum.Parse(typeof(ORIGINCONTINENT), animalDTO.OriginContinent),
                    animalDTO.Description,
                    (ENDANGERMENT)Enum.Parse(typeof(ENDANGERMENT), animalDTO.Endangerment),
                    animalDTO.Enclosure,
                    animalDTO.Availability);
                animals.Add(animal);
            }

            return animals; 
        }

        public List<Animal> GetAnimals()
        {
            return DTOToAnimals(helper.GetAllAnimals());
        }
            
        public void AddUpdateAnimal(Animal animal)
        {
            
            helper.AddUpdateAnimal(AnimalToDTO(animal));

            GetAnimals().Add(animal);
        }

        public List<Animal> GetSearchedAnimals(string name, string species, string origin, string gender, string availability, string age, string endangerment)
        {
            List<Animal> searchedAnimals = new List<Animal>();
            foreach (Animal animal in GetAnimals())
            {
                if(availability == string.Empty)
                {
                    if ((animal.Name.ToLower().Contains(name.ToLower()) || String.IsNullOrEmpty(name)) && 
                        (animal.Species.ToLower().Contains(species.ToLower()) || String.IsNullOrEmpty(species)) && 
                        (animal.OriginContinent.ToString() == origin || String.IsNullOrEmpty(origin)) &&
                        (animal.Gender == gender || String.IsNullOrEmpty(gender)) &&
                        (animal.GetAge().ToString() == age || String.IsNullOrEmpty(age.ToString())) &&
                        (animal.Endangerment.ToString() == endangerment || String.IsNullOrEmpty(endangerment)))
                    {
                        searchedAnimals.Add(animal);
                    }
                }
                else
                {
                    if ((animal.Name.ToLower().Contains(name.ToLower()) || String.IsNullOrEmpty(name)) &&
                        (animal.Species.ToLower().Contains(species.ToLower()) || String.IsNullOrEmpty(species)) &&
                        (animal.OriginContinent.ToString() == origin || String.IsNullOrEmpty(origin)) &&
                        (animal.Gender == gender || String.IsNullOrEmpty(gender)) &&
                        (animal.GetAge().ToString() == age || String.IsNullOrEmpty(age.ToString())) &&
                        (animal.Endangerment.ToString() == endangerment || String.IsNullOrEmpty(endangerment)) &&
                        (animal.Availability == availability))
                    {
                        searchedAnimals.Add(animal);
                    }
                }
            }
            return searchedAnimals;
        }

        public Animal[] GetAllAnimals()
        {
            return GetAnimals().ToArray();
        }

    }
}
