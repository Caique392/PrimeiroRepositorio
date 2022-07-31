using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeiraAPISolo.Models;

namespace PrimeiraAPISolo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private static List<ClienteModel> clientes = new List<ClienteModel>();

        [HttpGet()]
        public List<ClienteModel> Get()
        {
            return clientes;
        }
       [HttpPost()]
        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            clientes.Add(new ClienteModel(nome));
        }

        [HttpDelete]
        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(X => X.Cliente.Equals(nome))));
        }
    }
}
