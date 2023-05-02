using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CorparetedCustomer : Customer
    {
        public string Address { get; set; }

        public override string EFT(double amount, Customer customer)
        {
            if (amount < 0) return "ERROR!";
            else if (Balance < amount) return "No Balance";
            else if (this.CustomerNumber == customer.CustomerNumber) return "Same Customers!";
            else
            {
                this.Balance -= amount;
                customer.Balance += amount;
                return "EFT ok!";
            }
        }
    }
}
