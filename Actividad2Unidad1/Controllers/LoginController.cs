using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class LoginController : Controller
    {
        private const string UsuarioValido = "docente";
        private const string ContrasenaValida = "P@ssw0rd";

        [HttpGet]
        public IActionResult ValidarLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Autenticar(string usuario, string contrasena)
        {
            if (usuario == UsuarioValido && contrasena == ContrasenaValida)
            {
                // Si las credenciales son correctas, redirige a la vista Bienvenido
                return RedirectToAction("Bienvenido");
            }
            else
            {
                // Si son incorrectas, muestra un mensaje en la misma vista
                ViewBag.Error = "Usuario incorrecto";
                return View("ValidarLogin");
            }
        }

        public IActionResult Bienvenido()
        {
            return View();
        }
    }
}
