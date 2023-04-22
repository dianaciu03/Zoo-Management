﻿using DataAccess;

namespace BusinessLogic.AnimalInterfaces
{
    public interface IAnimalManagement
    {
        void AddMateRelationship(int animalIDMale, int animalIDFemale);
        Result<ParentRelationship> AddParentChildRelationship(Animal animalParent, Animal animalChild);
        void AddUpdateAnimal(Animal animal);
        Animal[] GetAllAnimals(string sortBy);
        List<Animal> GetAnimals(string sortBy);
        List<Animal> GetChildren(int animalID);
        List<Animal> GetMates(int animalID, string gender);
        List<Animal> GetParents(int animalID);
        List<Animal> GetSearchedAnimals(string name, string species, string origin, string gender, string availability, int? age, string endangerment);
        List<Animal> GetSiblings(int animalID);
        int NewAnimaID();
        List<Animal> OtherInSpeciesSearch(int id, string species);
    }
}