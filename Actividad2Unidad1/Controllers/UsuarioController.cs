using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Datos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Datos(string nombre, DateTime fechaNacimiento)
        {
            int edad = CalcularEdad(fechaNacimiento);
            string anioNacimiento = fechaNacimiento.ToString("yy");

            ViewBag.Nombre = nombre;
            ViewBag.Edad = edad;
            ViewBag.AnioNacimiento = anioNacimiento;

            return View();
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
                edad--;

            return edad;
        }
    }
}
