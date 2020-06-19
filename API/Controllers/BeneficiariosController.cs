using Dominio;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Aplicacion.Interfaces;

namespace API.Controllers
{
    public class BeneficiariosController : Controller
    {
        private readonly IBeneficiarioService _service;

        public BeneficiariosController(IBeneficiarioService service){
            _service=service;
        }

        [HttpGet]
        [Route("api/[controller]")]
       public ActionResult<IEnumerable<Beneficiario>> GetBeneficiario(){
           var beneficiarios = _service.List();
           return Ok(beneficiarios);
       }

       [HttpGet]
        [Route("api/[controller]/{id}")]
        public ActionResult<IEnumerable<Beneficiario>> GetBeneficiario(int id)
        {
            var beneficiario = _service.GetById(id);
            if(beneficiario!=null){
                return Ok(beneficiario);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("api/[controller]")]
        public ActionResult CreateBeneficiario([FromBody] Beneficiario beneficiario)
        {
            _service.Create(beneficiario);
            return Ok();
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public ActionResult UpdateBeneficiario([FromBody] Beneficiario beneficiario){
            
            _service.Update(beneficiario);
            return Ok(beneficiario);
        }

         [HttpDelete]
        [Route("api/[controller]/{id}")]
        public ActionResult DeleteBeneficiario(int id)
        {
            var beneficiario = new Beneficiario{ID = id};
            _service.Delete(id);
            return Ok();
        }
        
    }
}