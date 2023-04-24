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
            TransferDTO transferDTO = AnimalEntityMapping.FromTransferToDTO(transfer);
            dth.AddNewTransfer(transferDTO);
        }

        public List<Transfer> GetAllTransfersNoAnimal()
        {
            List <Transfer> transfers = new List<Transfer>();
            foreach (TransferDTO transferDTO in dth.GetAllTransfers())
            {
                transfers.Add(AnimalEntityMapping.FromDTOToTransferNoAnimal(transferDTO));
            }
            return transfers;
        }

        public List<Transfer> GetAllTransfersById(int id)
        {
            List<Transfer> transfers = new List<Transfer>();
            foreach (TransferDTO transferDTO in dth.GetTransferByAnimalId(id))
            {
                Transfer transfer = AnimalEntityMapping.FromDTOToTransfer(transferDTO, transferDTO.Animal);
                transfers.Add(transfer);
            }
            return transfers;
        }

        public void ChangeAnimalAvailability(int transferId, string option)
        {
            dth.ChangeAnimalAvailability(transferId, option);
        }



    }
}
