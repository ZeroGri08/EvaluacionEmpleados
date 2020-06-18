using System.Collections.Generic;
using Dominio;


namespace Aplicacion.Interfaces
{
    public interface IBeneficiarioService
    {
          IEnumerable<Beneficiario> List();

       Beneficiario GetById(int id);

       bool Delete(int id);

       Beneficiario Create(Beneficiario beneficiario);

       Beneficiario Update(Beneficiario beneficiario);
    }
}