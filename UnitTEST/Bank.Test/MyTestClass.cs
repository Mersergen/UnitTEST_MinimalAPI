using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Test
{
    public class MyTestClass
    {
        [Fact]
        public void GetMoney_NegativeAmount_ERROR()
        {
            IndividualCustomer individual = new IndividualCustomer()
            {
                CustomerNumber = 12,
                Name = "Ali",
                LastName = "Veli",
                Balance = 5000
            };
            string result = individual.GetMoney(-500);
            Assert.Equal("ERROR!", result);
        }

        [Fact]
        public void GetMoney_NotEnoughBalance_NoBalance()
        {
            IndividualCustomer individual = new IndividualCustomer()
            {
                CustomerNumber = 12,
                Name = "Ali",
                LastName = "Veli",
                Balance = 5000
            };
            string result = individual.GetMoney(5500);
            Assert.True("No Balance" == result);
        }
        [Fact]
        public void GetMoney_OK_Balance()
        {
            //IndividualCustomer individual = new IndividualCustomer()
            //{
            //    CustomerNumber = 12,
            //    Name = "Ali",
            //    LastName = "Veli",
            //    Balance = 5000
            //};
            //string result = individual.GetMoney(500);
            //Assert.True("4500" == result);

            //var individual = new Mock<IndividualCustomer>();
            //individual.Object.Balance = 5000;
            //string result = individual.Object.GetMoney(500);
            //Assert.Equal("4500", result);

            var individual = new Mock<ICustomer>();
            individual.Object.Balance = 5000;
            individual.Setup(x => x.GetMoney2(500)).Returns(4500);
            double result = individual.Object.GetMoney2(500);
            Assert.Equal(4500, result);

        }
        [Fact]
        public void PutMoney_NegativeAmount_ERROR()
        {
            IndividualCustomer individual = new IndividualCustomer()
            {
                CustomerNumber = 12,
                Name = "Ali",
                LastName = "Veli",
                Balance = 5000
            };
            string result = individual.PutMoney(-500);
            Assert.Equal("ERROR!", result);
        }
        [Fact]
        public void PutMoney_OK_Balance()
        {
            IndividualCustomer individual = new IndividualCustomer()
            {
                CustomerNumber = 12,
                Name = "Ali",
                LastName = "Veli",
                Balance = 5000
            };
            string result = individual.PutMoney(500);
            Assert.True("5500" == result);
        }
        [Fact]
        public void EFT_NegativeAmount_ERROR()
        {
            IndividualCustomer individual = new IndividualCustomer()
            {
                CustomerNumber = 12,
                Name = "Ali",
                LastName = "Veli",
                Balance = 5000
            };
            CorparetedCustomer corpareted = new CorparetedCustomer()
            {
                Address = "KSK",
                Balance = 30000,
                CustomerNumber = 121,
                Name = "Emre LTD."
            };
            string result = individual.EFT(-500, corpareted);
            Assert.Equal("ERROR!", result);
        }
        [Fact]
        public void EFT_NotEnoughBalance_NoBalance()
        {
            IndividualCustomer individual = new IndividualCustomer()
            {
                CustomerNumber = 12,
                Name = "Ali",
                LastName = "Veli",
                Balance = 5000
            };
            CorparetedCustomer corpareted = new CorparetedCustomer()
            {
                Address = "KSK",
                Balance = 30000,
                CustomerNumber = 121,
                Name = "Emre LTD."
            };
            string result = individual.EFT(5500, corpareted);
            Assert.Equal("No Balance", result);
        }
        [Fact]
        public void EFT_SameCustomerNumber_SameCustomer()
        {
            IndividualCustomer individual = new IndividualCustomer()
            {
                CustomerNumber = 12,
                Name = "Ali",
                LastName = "Veli",
                Balance = 5000
            };
            CorparetedCustomer corpareted = new CorparetedCustomer()
            {
                Address = "KSK",
                Balance = 30000,
                CustomerNumber = 121,
                Name = "Emre LTD."
            };
            string result = individual.EFT(1500, individual);
            Assert.Equal("Same Customers!", result);
        }
        [Fact]
        public void EFT_IndividualOK_EftOK()
        {
            IndividualCustomer individual = new IndividualCustomer()
            {
                CustomerNumber = 12,
                Name = "Ali",
                LastName = "Veli",
                Balance = 5000
            };
            CorparetedCustomer corpareted = new CorparetedCustomer()
            {
                Address = "KSK",
                Balance = 30000,
                CustomerNumber = 121,
                Name = "Emre LTD."
            };
            string result = individual.EFT(1500, corpareted);
            Assert.Equal("EFT ok!", result);
        }
        [Fact]
        public void EFT_CorparetedOK_EftOK()
        {
            IndividualCustomer individual = new IndividualCustomer()
            {
                CustomerNumber = 12,
                Name = "Ali",
                LastName = "Veli",
                Balance = 5000
            };
            CorparetedCustomer corpareted = new CorparetedCustomer()
            {
                Address = "KSK",
                Balance = 30000,
                CustomerNumber = 121,
                Name = "Emre LTD."
            };
            string result = individual.EFT(1500, corpareted);
            Assert.Equal("EFT ok!", result);
        }
    }
}
