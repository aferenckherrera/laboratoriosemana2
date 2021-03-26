using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appcompras.Models;

namespace appcompras.Controllers 
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }
        [HttpPost]
        public IActionResult Execute(Producto objproducto)
        {
            Double result = 0.0;
            if("Comprar"== objproducto.accion)
            {
                result=(objproducto.cantidad*objproducto.precio)*1.18;
            }
            ViewData["Message"]= "El total de compra más IGV es:" +result;
            return View("Index");
        }
    }
}
