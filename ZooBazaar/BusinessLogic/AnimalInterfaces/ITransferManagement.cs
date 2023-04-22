using BusinessLogic.Animals;
using DataAccess;
using DataAccess.DTOs;

namespace BusinessLogic.AnimalInterfaces
{
    public interface ITransferManagement
    {
        List<Transfer> GetAllTransfers();
        List<Transfer> GetAllTransfersById(int id);
        void SaveTransfer(Transfer transfer);
    }
}