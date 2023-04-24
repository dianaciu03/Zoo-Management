using BusinessLogic.Animals;
using DataAccess;
using DataAccess.DTOs;

namespace BusinessLogic.AnimalInterfaces
{
    public interface ITransferManagement
    {
        List<Transfer> GetAllTransfersNoAnimal();
        List<Transfer> GetAllTransfersById(int id);
        void SaveTransfer(Transfer transfer);
        void ChangeAnimalAvailability(int transferId, string option);
    }
}