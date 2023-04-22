using BusinessLogic.AnimalInterfaces;
using DataAccess;
using DataAccess.AnimalInterfaces;
using DataAccess.AnimalRepositories;
using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Animals
{
    public class TransferManagement : ITransferManagement
    {
        private readonly ITransferRepository dth;

        public TransferManagement(ITransferRepository transferRepository)
        {
            dth = transferRepository;
        }

        public void SaveTransfer(Transfer transfer)
        {
            TransferDTO transferDTO = FromTransferToDTO(transfer);
            dth.AddNewTransfer(transferDTO);
        }

        public List<Transfer> GetAllTransfers()
        {
            return new List<Transfer>();
        }

        public List<Transfer> GetAllTransfersById(int id)
        {
            TransferRepository dth = new TransferRepository();
            List<Transfer> transfers = new List<Transfer>();
            foreach (TransferDTO transferDTO in dth.GetTransferByAnimalId(id))
            {
                Transfer transfer = FromDTOToTransfer(transferDTO, transferDTO.Animal);
                transfers.Add(transfer);
            }
            return transfers;
        }

        public Transfer FromDTOToTransfer(TransferDTO transferDTO, AnimalDTO animalDTO)
        {
            IAnimalManagement animalManagement = new AnimalManagement(new AnimalRepository());
            Animal animal = animalManagement.DTOToAnimal(animalDTO);

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

        public TransferDTO FromTransferToDTO(Transfer transfer)
        {
            IAnimalManagement animalManagement = new AnimalManagement(new AnimalRepository());
            AnimalDTO animalDTO = animalManagement.AnimalToDTO(transfer.Animal);
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
