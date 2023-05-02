using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Customer : ICustomer
    {
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public virtual string EFT(double amount, Customer customer)
        {
            double tax = 100;
            if (amount < 0) return "ERROR!";
            else if (Balance < (amount + tax)) return "No Balance";
            else if (this.CustomerNumber == customer.CustomerNumber) return "Same Customers!";
            else
            {
                this.Balance -= (amount + tax);
                customer.Balance += amount;
                return "EFT ok!";
            }
        }

        public string GetMoney(double amount)
        {
            if (amount < 0) return "ERROR!";

            if (Balance < amount) return "No Balance";

            this.Balance -= amount;
            return this.Balance.ToString();
        }

        public double GetMoney2(double amount)
        {
            return this.Balance -= amount;
        }

        public string PutMoney(double amount)
        {
            if (amount < 0) return "ERROR!";

            this.Balance += amount;
            return this.Balance.ToString();
        }
    }
}
