
using Bank;

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

Console.WriteLine("Individual:" + individual.Balance);
Console.WriteLine(individual.GetMoney(5500));
Console.WriteLine("Individual:" + individual.Balance);
Console.WriteLine(individual.PutMoney(-300));
Console.WriteLine("Individual:" + individual.Balance);
Console.WriteLine(individual.EFT(1000, individual));
Console.WriteLine("Individual:" + individual.Balance);
Console.WriteLine("-----------------------------------");

Console.WriteLine("Corpareted:" + corpareted.Balance);
Console.WriteLine(corpareted.GetMoney(500));
Console.WriteLine("Corpareted:" + corpareted.Balance);
Console.WriteLine(corpareted.PutMoney(300));
Console.WriteLine("Corpareted:" + corpareted.Balance);
Console.WriteLine(corpareted.EFT(29800, individual));
Console.WriteLine("Corpareted:" + corpareted.Balance);