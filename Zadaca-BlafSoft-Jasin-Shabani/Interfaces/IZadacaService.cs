using Zadaca_BlafSoft_Jasin_Shabani.Models;

namespace Zadaca_BlafSoft_Jasin_Shabani.Interfaces
{
    public interface IZadacaService
    {
        Task<Customer> CreateInstances();
        Task<AllCustomers> CustomerPrint();
    }
}
