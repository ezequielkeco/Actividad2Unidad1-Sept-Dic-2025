using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class OperacionesController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(double valor1, double valor2, string operacion)
        {
            double resultado = 0;
            string mensaje = "";

            switch (operacion)
            {
                case "Suma":
                    resultado = valor1 + valor2;
                    break;
                case "Resta":
                    resultado = valor1 - valor2;
                    break;
                case "Multiplicación":
                    resultado = valor1 * valor2;
                    break;
                case "División":
                    mensaje = (valor2 == 0) ? "No se puede dividir entre cero." : "";
                    resultado = (valor2 != 0) ? valor1 / valor2 : 0;
                    break;
                case "Potenciación":
                    resultado = Math.Pow(valor1, valor2);
                    break;
            }

            ViewBag.Valor1 = valor1;
            ViewBag.Valor2 = valor2;
            ViewBag.Operacion = operacion;
            ViewBag.Resultado = mensaje == "" ? resultado.ToString() : mensaje;

            return View();
        }
    }
}
