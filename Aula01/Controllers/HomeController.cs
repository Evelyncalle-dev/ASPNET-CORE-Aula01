using Aula01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aula01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //CRIANDO PROPIEDADES DINÂMICAS
            ViewBag.UsuarioLogado = "Cidade";
            ViewBag.DataAcesso = DateTime.Now.ToLongDateString();
            ViewBag.NivelAcesso = "Administrador";
            
            return View();
        }

        public IActionResult Privacy()
        {
            //Criando no privacy
            ViewBag.Nome = "Gabriela";
            ViewBag.Endereço = "rua 107";
            ViewBag.Email = "gabriela@gmail.com";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
