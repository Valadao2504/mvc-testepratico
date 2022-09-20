using Microsoft.AspNetCore.Mvc;

namespace mvc___teste_prático.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
