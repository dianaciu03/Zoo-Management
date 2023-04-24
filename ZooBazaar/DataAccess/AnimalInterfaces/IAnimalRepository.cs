namespace DataAccess.AnimalInterfaces
{
    public interface IAnimalRepository
    {
        void AddMateRelationship(int animalIDMale, int animalIDFemale);
        void AddParentChildRelationship(int animalIDParent, int animalIDChild);
        void AddUpdateAnimal(AnimalDTO animal);
        void ChangeAvailability(int animalID, string animalAvailability);
        List<AnimalDTO> GetAllAnimals(string sortBy);
        List<AnimalDTO> GetChildren(int animalID);
        List<AnimalDTO> GetMates(int animalID, string gender);
        List<AnimalDTO> GetParents(int animalID);
        List<AnimalDTO> GetSiblings(int animalID);
        List<AnimalDTO> OtherInSpeciesSearch(int animalID, string species);
        List<AnimalDTO> SearchForAnimals(string name, string species, string origin, string gender, int? age, string endangerment, string availability);
    }
}