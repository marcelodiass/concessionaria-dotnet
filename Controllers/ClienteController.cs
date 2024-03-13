using Microsoft.AspNetCore.Mvc;
using Concessionaria.Models;

namespace Concessionaria.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> listaCliente = new List<Cliente>();

            listaCliente.Add(new Cliente("Thiago", "12345678900", "Av Paulista", "11999999999", "thiago@gmail.com"));
            listaCliente.Add(new Cliente("Marcelo", "50588422894", "Av Paulista", "11982464588", "marcelodias@gmail.com"));

            return View(listaCliente);
        }
    }
}
