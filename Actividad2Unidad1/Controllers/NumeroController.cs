using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroController : Controller
    {
        [HttpGet]
        public IActionResult CalcularFibo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Verificar(int numero)
        {
            bool pertenece = EsFibonacci(numero);
            ViewBag.Numero = numero;
            ViewBag.Mensaje = pertenece
                ? $"El número {numero} pertenece a la serie de Fibonacci."
                : $"El número {numero} NO pertenece a la serie de Fibonacci.";
            return View("CalcularFibo");
        }

        private bool EsFibonacci(int n)
        {
            int x1 = 5 * n * n + 4;
            int x2 = 5 * n * n - 4;

            return EsCuadradoPerfecto(x1) || EsCuadradoPerfecto(x2);
        }

        private bool EsCuadradoPerfecto(int x)
        {
            int raiz = (int)Math.Sqrt(x);
            return raiz * raiz == x;
        }
    }
}
