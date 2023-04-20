using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class AnimalManagement
    {
        DatabaseAnimalHelper animalHelper;

        public AnimalManagement()
        {
            animalHelper = new DatabaseAnimalHelper();
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
            return animalHelper.NewAnimalID();
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
            return DTOToAnimals(animalHelper.GetAllAnimals());
        }
            
        public void AddUpdateAnimal(Animal animal)
        {
            
            animalHelper.AddUpdateAnimal(AnimalToDTO(animal));

            GetAnimals().Add(animal);
        }

        public List<Animal> GetSearchedAnimals(string name, string species, string origin, string gender, string availability, int? age, string endangerment)
        {
            return DTOToAnimals(animalHelper.SearchForAnimals(name, species, origin, gender, age, endangerment, availability));
        }

        public Animal[] GetAllAnimals()
        {
            return GetAnimals().ToArray();
        }

        public List<Animal> OtherInSpeciesSearch(int id, string species)
        {
            return DTOToAnimals(animalHelper.OtherInSpeciesSearch(id, species));
        }

        public Result<ParentRelationship> AddParentChildRelationship(Animal animalParent, Animal animalChild)
        {
            if (DateTime.Compare(animalChild.Birthday, animalParent.Birthday) < 0) { return Result<ParentRelationship>.Fail("A child cant be older than its parent"); }
            if (GetParents(animalParent.Id).Count >= 2) { return Result<ParentRelationship>.Fail("The child animal already has 2 parents"); }
            animalHelper.AddParentChildRelationship(animalParent.Id, animalChild.Id);
            return Result<ParentRelationship>.Ok(new ParentRelationship(animalParent ,animalChild));
        }

        public void AddMateRelationship(int animalIDMale, int animalIDFemale)
        {
            animalHelper.AddMateRelationship(animalIDMale, animalIDFemale);
        }

        public List<Animal> GetParents(int animalID)
        {
            return DTOToAnimals(animalHelper.GetParents(animalID));
        }

        public List<Animal> GetChildren(int animalID)
        {
            return DTOToAnimals(animalHelper.GetChildren(animalID));
        }

        public List<Animal> GetMates(int animalID, string gender)
        {
            return DTOToAnimals(animalHelper.GetMates(animalID, gender));
        }

        public List<Animal> GetSiblings(int animalID)
        {
            return DTOToAnimals(animalHelper.GetSiblings(animalID));
        }
    }
}
