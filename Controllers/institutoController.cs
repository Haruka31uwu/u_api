using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u_api.Repositories;

namespace u_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class institutoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPInstitutos rpinst = new RPInstitutos();
            return Ok(rpinst.getInstitutos());
        }
        [HttpGet("{nombre}")]
        public IActionResult Get(string nombre)
        {
            RPInstitutos rpinst = new RPInstitutos();
            var instRet = rpinst.getInstituto(nombre);
            if(instRet == null){
                var nf = NotFound("El instituto " + nombre.ToString() + " no existe");
                return nf;
            }
            return Ok(instRet);
        }
    }
}
