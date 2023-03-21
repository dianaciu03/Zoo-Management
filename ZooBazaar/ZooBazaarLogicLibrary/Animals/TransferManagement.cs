using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLibrary.Animals
{
    public class TransferManagement
    {
        List<Transfer> transfers;

        public TransferManagement()
        {
            transfers = new List<Transfer>();
        }

        public void AddTransferToList(Transfer transfer)
        {
            transfers.Add(transfer);
        }

        private void SetTransferId(Transfer transfer)
        {

        }
    }
}
