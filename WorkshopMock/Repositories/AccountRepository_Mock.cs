using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopMock.Repositories
{
    public class AccountRepository_Mock : IAccountRepository
    {
        public decimal Balance { get; set; }
        public bool IsSaved { get; set; }

        public void Edit(string accountId, decimal money)
        {
            IsSaved = true;
        }

        public decimal GetBalance(string accountId)
        {
            return Balance;
        }
    }
}
