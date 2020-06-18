using System.Collections.Generic;
using Dominio;

namespace Aplicacion.Interfaces
{
    public interface IEmpleadoService
    {
       IEnumerable<Empleado> List();

       Empleado GetById(int id);

       bool Delete(int id);

       Empleado Create(Empleado empleado);

       Empleado Update(Empleado empleado);
    }
}