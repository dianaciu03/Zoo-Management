using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.AnimalInterfaces;
using BusinessLogic.Animals;
using DataAccess;
using DataAccess.AnimalInterfaces;
using DataAccess.AnimalRepositories;

namespace BusinessLogic
{
    public class AnimalManagement : IAnimalManagement
    {
        private readonly IAnimalRepository animalHelper;

        public AnimalManagement(IAnimalRepository animalRepository)
        {
            animalHelper = animalRepository;
        }

        public int NewAnimaID()
        {
            return animalHelper.NewAnimalID();
        }

        public List<Animal> GetAnimals(string sortBy)
        {
            return AnimalEntityMapping.DTOToAnimals(animalHelper.GetAllAnimals(sortBy));
        }

        public void AddUpdateAnimal(Animal animal)
        {
            animalHelper.AddUpdateAnimal(AnimalEntityMapping.AnimalToDTO(animal));
            GetAnimals("AnimalId").Add(animal);
        }

        public List<Animal> GetSearchedAnimals(string name, string species, string origin, string gender, string availability, int? age, string endangerment)
        {
            return AnimalEntityMapping.DTOToAnimals(animalHelper.SearchForAnimals(name, species, origin, gender, age, endangerment, availability));
        }

        public Animal[] GetAllAnimals(string sortBy)
        {
            return GetAnimals(sortBy).ToArray();
        }

        public List<Animal> OtherInSpeciesSearch(int id, string species)
        {
            return AnimalEntityMapping.DTOToAnimals(animalHelper.OtherInSpeciesSearch(id, species));
        }

        public Result<ParentRelationship> AddParentChildRelationship(Animal animalParent, Animal animalChild)
        {
            if (DateTime.Compare(animalChild.Birthday, animalParent.Birthday) < 0) { return Result<ParentRelationship>.Fail("A child cant be older than its parent"); }
            if (GetParents(animalParent.Id).Count >= 2) { return Result<ParentRelationship>.Fail("The child animal already has 2 parents"); }
            animalHelper.AddParentChildRelationship(animalParent.Id, animalChild.Id);
            return Result<ParentRelationship>.Ok(new ParentRelationship(animalParent, animalChild));
        }

        public void AddMateRelationship(int animalIDMale, int animalIDFemale)
        {
            animalHelper.AddMateRelationship(animalIDMale, animalIDFemale);
        }

        public List<Animal> GetParents(int animalID)
        {
            return AnimalEntityMapping.DTOToAnimals(animalHelper.GetParents(animalID));
        }

        public List<Animal> GetChildren(int animalID)
        {
            return AnimalEntityMapping.DTOToAnimals(animalHelper.GetChildren(animalID));
        }

        public List<Animal> GetMates(int animalID, string gender)
        {
            return AnimalEntityMapping.DTOToAnimals(animalHelper.GetMates(animalID, gender));
        }

        public List<Animal> GetSiblings(int animalID)
        {
            return AnimalEntityMapping.DTOToAnimals(animalHelper.GetSiblings(animalID));
        }
    }
}
