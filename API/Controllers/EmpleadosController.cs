using Dominio;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Aplicacion.Interfaces;

namespace API.Controllers
{
    public class EmpleadosController: Controller
    {
        private readonly IEmpleadoService _service;
        

       public EmpleadosController(IEmpleadoService service){
        
           _service = service;
       } 

       [HttpGet]
       [Route("api/[controller]")]
       public ActionResult<IEnumerable<Empleado>> GetEmpleado(){
           var empleados = _service.List();
           return Ok(empleados);
       }
        
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public ActionResult<IEnumerable<Empleado>> GetEmpleado(int id)
        {
            var empleado = _service.GetById(id);
            if(empleado!=null){
                return Ok(empleado);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("api/[controller]")]
        public ActionResult CreateEmpleado([FromBody] Empleado empleado)
        {
            _service.Create(empleado);
            return Ok();
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public ActionResult UpdateUsuario([FromBody] Empleado empleado){
            
            _service.Update(empleado);
            return Ok(empleado);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public ActionResult DeleteEmpleado(int id)
        {
            var empleado = new Empleado{Id = id};
            _service.Delete(id);
            return Ok();
        }

    }
}