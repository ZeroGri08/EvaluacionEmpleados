using System.Collections.Generic;
using Dominio;

namespace Persistencia.Interface
{
    
    public interface IData
    {
        #region Empleados
        IEnumerable<Empleado> GetEmpleadosList();

        Empleado GetEmpleadoById(int id);

        Empleado CreateEmpleado(Empleado empleado);

        Empleado UpdateEmpleado(Empleado empleado);

        bool DeleteEmpleado(int id);
        #endregion


        #region Beneficiarios

        IEnumerable<Beneficiario> GetBeneficiariosList();

        Beneficiario GetBeneficiarioById(int id);

        Beneficiario CreateBeneficiario(Beneficiario beneficiario);

        Beneficiario UpdateBeneficiario(Beneficiario beneficiario);

        bool DeleteBeneficiario(int id);

        #endregion

    }
}