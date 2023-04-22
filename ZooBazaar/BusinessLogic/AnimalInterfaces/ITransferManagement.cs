using BusinessLogic.Animals;
using DataAccess;
using DataAccess.DTOs;

namespace BusinessLogic.AnimalInterfaces
{
    public interface ITransferManagement
    {
        Transfer FromDTOToTransfer(TransferDTO transferDTO, AnimalDTO animalDTO);
        TransferDTO FromTransferToDTO(Transfer transfer);
        List<Transfer> GetAllTransfers();
        List<Transfer> GetAllTransfersById(int id);
        void SaveTransfer(Transfer transfer);
    }
}