using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u_api.Modelos;
using u_api.Repositories;

namespace u_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class universidadController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPUniversidades rpuni = new RPUniversidades();
            return Ok(rpuni.getUniversidades());
        }
        [HttpGet("{nombre}")]
        public IActionResult Get(string nombre)
        {
            RPUniversidades rpuni = new RPUniversidades();
            var uniRet = rpuni.getUniversidad(nombre);
            if (uniRet == null)
            {
                var nf = NotFound("La Universidad " + nombre.ToString() + " no existe.");
                return nf;
            }
            return Ok(uniRet);
        }[HttpPost("add")]
        public IActionResult AgregarUniversidad(Universidad nuni)
        {
            RPUniversidades rpuni = new RPUniversidades();
            rpuni.addUniversidad(nuni);
            return CreatedAtAction(nameof(AgregarUniversidad), nuni);
        }
    }
}
