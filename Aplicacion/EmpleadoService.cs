using System.Collections.Generic;
using Aplicacion.Interfaces;
using Dominio;
using Persistencia.Interface;

namespace Aplicacion
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IData _data;

        public EmpleadoService(IData data)
        {
            _data=data;
        }

        public Empleado Create(Empleado empleado)
        {
            return _data.CreateEmpleado(empleado);
        }

        public bool Delete(int id)
        {
            return _data.DeleteEmpleado(id);
        }

        public Empleado GetById(int id)
        {
            return _data.GetEmpleadoById(id);
        }

        public IEnumerable<Empleado> List()
        {
            return _data.GetEmpleadosList();
        }

        public Empleado Update(Empleado empleado)
        {
            return _data.UpdateEmpleado(empleado);
        }
    }
}