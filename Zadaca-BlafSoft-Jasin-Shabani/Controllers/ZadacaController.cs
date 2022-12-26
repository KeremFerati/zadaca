using Microsoft.AspNetCore.Mvc;
using Zadaca_BlafSoft_Jasin_Shabani.Interfaces;
using Zadaca_BlafSoft_Jasin_Shabani.Models;

namespace Zadaca_BlafSoft_Jasin_Shabani.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZadacaController : Controller
    {
        private readonly IZadacaService _zadacaService;
        public ZadacaController(IZadacaService zadacaService)
        {
            _zadacaService = zadacaService;
        }
       [HttpGet(Name = "Zadaca")]
        public Task<AllCustomers> Get()
        {
            var response = _zadacaService.CustomerPrint();
            return response;

        }
    }
}
