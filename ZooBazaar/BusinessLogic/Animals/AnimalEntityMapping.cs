using DataAccess;
using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Animals
{
    public static class AnimalEntityMapping
    {
        public static Animal DTOToAnimal(this AnimalDTO animalDTO)
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

        public static AnimalDTO AnimalToDTO(this Animal animal)
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

        public static List<Animal> DTOToAnimals(this List<AnimalDTO> animalsDTO)
        {
            List<Animal> animals = new List<Animal>();

            foreach (AnimalDTO animalDTO in animalsDTO)
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

        public static Transfer FromDTOToTransfer(TransferDTO transferDTO, AnimalDTO animalDTO)
        {
            Animal animal = DTOToAnimal(animalDTO);
            return new Transfer(
                transferDTO.TransferId,
                transferDTO.ZooName,
                transferDTO.ZooAddress,
                transferDTO.Description,
                transferDTO.StartDate,
                transferDTO.EndDate,
                animal,
                transferDTO.ZooPhone);
        }

        public static TransferDTO FromTransferToDTO(Transfer transfer)
        {
            AnimalDTO animalDTO = AnimalToDTO(transfer.Animal);
            return new TransferDTO(
                transfer.TransferId,
                transfer.ZooName,
                transfer.ZooAddress,
                transfer.Description,
                transfer.StartDate,
                transfer.EndDate,
                transfer.ZooPhone,
                animalDTO);
        }
    }
}
