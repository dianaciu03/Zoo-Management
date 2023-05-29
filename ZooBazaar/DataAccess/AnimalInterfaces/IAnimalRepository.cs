namespace DataAccess.AnimalInterfaces
{
    public interface IAnimalRepository
    {
        void AddMateRelationship(int animalIDMale, int animalIDFemale);
        void AddParentChildRelationship(int animalIDParent, int animalIDChild);
        void AddUpdateAnimal(AnimalDTO animal);
        void ChangeAvailability(int animalID, string animalAvailability);
        List<AnimalDTO> GetAllAnimals(string sortBy);
        AnimalDTO? GetAnimalByID(int id);
        List<AnimalDTO> GetChildren(int animalID);
        List<AnimalDTO> GetMates(int animalID, string gender);
        List<AnimalDTO> GetParents(int animalID);
        List<AnimalDTO> GetSiblings(int animalID);
        List<AnimalDTO> OtherInSpeciesSearch(int animalID, string species);
        List<AnimalDTO> SearchForAnimals(string name, string species, string origin, string gender, int? birthYear, string endangerment, string availability);
        string[] GetAllSpecies();
        void ChangeAnimalAvailability(int animalId, string option);
        string GetOrginEnclosureOfSpecies(string species, out int enclosureNumber);

    }
}