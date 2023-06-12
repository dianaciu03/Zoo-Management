using DataAccess.DTOs;

namespace DataAccess.AnimalInterfaces
{
    public interface ITransferRepository
    {
        void AddNewTransfer(TransferDTO transfer);
        List<TransferDTO> GetTransferByAnimalId(int id);
        List<TransferDTO> GetAllTransfers();
        void ChangeAnimalAvailability(int transferId, string option);
        void UpdateTransferDates(int transferId, DateTime startDate, DateTime endDate);
    }
}