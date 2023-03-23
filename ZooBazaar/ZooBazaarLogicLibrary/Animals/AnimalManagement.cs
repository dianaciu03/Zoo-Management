using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLibrary;
using Interfaces;

namespace ZooBazaarLogicLibrary
{
    public class AnimalManagement
    {
        List<IAnimal> animalsList;
        DatabaseAnimalHelper helper = new DatabaseAnimalHelper();

        public AnimalManagement()
        {
            animalsList = new List<IAnimal>();
            animalsList = helper.GetAllAnimals();

           
        }

        public List<Animal> Animals { get { return animalsList;} }

        public void AddAnimal(Animal animal)
        {
            animalsList.Add(animal);
        }

        public List<Animal> GetSearchedAnimals(string name, string species, string origin, string gender, string availability, string age, string endangerment)
        {
            List<Animal> searchedAnimals = new List<Animal>();
            foreach (Animal animal in animalsList)
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
            return animalsList.ToArray();
        }
    }
}
