using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface ICustomer
    {
        double Balance { get; set; }

        string GetMoney(double amount);
        double GetMoney2(double amount);
        string PutMoney(double amount);
        string EFT(double amount, Customer customer);
    }
}
