using System.Collections.Generic;
using Aplicacion.Interfaces;
using Dominio;
using Persistencia.Interface;

namespace Aplicacion
{
    public class BeneficiarioService : IBeneficiarioService
    {
        private readonly IData _data;

        public BeneficiarioService(IData data)
        {
            _data = data;
        } 

        public Beneficiario Create(Beneficiario beneficiario)
        {
            return _data.CreateBeneficiario(beneficiario);
        }

        public bool Delete(int id)
        {
            return _data.DeleteBeneficiario(id);
        }

        public Beneficiario GetById(int id)
        {
            return _data.GetBeneficiarioById(id);
        }

        public IEnumerable<Beneficiario> List()
        {
            return _data.GetBeneficiariosList();
        }

        public Beneficiario Update(Beneficiario beneficiario)
        {
            return _data.UpdateBeneficiario(beneficiario);
        }
    }
}