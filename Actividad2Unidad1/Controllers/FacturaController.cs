using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class FacturaController : Controller
    {
        [HttpGet]
        public IActionResult Facturar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(decimal monto, string opcion)
        {
            decimal subtotal = monto;
            decimal impuesto = 0;
            decimal descuento = 0;
            decimal total = monto;

            if (opcion == "ITBIS")
            {
                impuesto = monto * 0.18m;
                total = subtotal + impuesto;
            }
            else if (opcion == "DESCUENTO")
            {
                descuento = monto * 0.15m;
                total = subtotal - descuento;
            }

            ViewBag.Subtotal = "RD$ " + subtotal.ToString("N2");
            ViewBag.Impuesto = impuesto > 0 ? "RD$ " + impuesto.ToString("N2") : "-";
            ViewBag.Descuento = descuento > 0 ? "RD$ " + descuento.ToString("N2") : "-";
            ViewBag.Total = "RD$ " + total.ToString("N2");

            return View("Facturar");
        }
    }
}

