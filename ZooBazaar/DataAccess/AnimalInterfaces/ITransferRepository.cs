using DataAccess.DTOs;

namespace DataAccess.AnimalInterfaces
{
    public interface ITransferRepository
    {
        void AddNewTransfer(TransferDTO transfer);
        List<TransferDTO> GetTransferByAnimalId(int id);
    }
}