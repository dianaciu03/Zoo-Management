using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary
{
    public class AnimalManagement
    {
        List<Animal> animalsList;

        public AnimalManagement() 
        {
            animalsList= new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animalsList.Add(animal);
        }

    }
}
