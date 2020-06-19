using System.Collections.Generic;
using System.Linq;
using Dominio;
using Persistencia.Interface;

namespace Persistencia
{
    public class SqlData : IData
    {
        
            private readonly DataContext _context;

            public SqlData(DataContext context)
            {
                _context=context;
            }
            public Beneficiario CreateBeneficiario(Beneficiario beneficiario)
            {
                _context.Beneficiarios.Add(beneficiario);
                _context.SaveChanges();
                return beneficiario;
            }

            public Empleado CreateEmpleado(Empleado empleado)
            {
                _context.Empleados.Add(empleado);
                _context.SaveChanges();
                return empleado;

            }

            public bool DeleteBeneficiario(int id)
            {
                var beneficiario = new Beneficiario{ID = id};
                _context.Beneficiarios.Remove(beneficiario);
                _context.SaveChanges();

                return true;
            }

            public bool DeleteEmpleado(int id)
            {
                var empleado = new Empleado{Id = id};
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
                return true;
            }

            public Beneficiario GetBeneficiarioById(int id)
            {
                var beneficiario = _context.Beneficiarios.Find(id);
                return beneficiario;
            }

            public IEnumerable<Beneficiario> GetBeneficiariosList()
            {
                var beneficiarios = _context.Beneficiarios.ToList();
                return beneficiarios;
            }

            public Empleado GetEmpleadoById(int id)
            {
                var empleado = _context.Empleados.Find(id);
                return empleado;
            }

            public IEnumerable<Empleado> GetEmpleadosList()
            {
                var empleados = _context.Empleados.ToList();
                return empleados;
            }

            public Beneficiario UpdateBeneficiario(Beneficiario beneficiario)
            {
                _context.Beneficiarios.Update(beneficiario);
                _context.SaveChanges();
                return beneficiario;
            }

            public Empleado UpdateEmpleado(Empleado empleado)
            {
                _context.Empleados.Update(empleado);
                _context.SaveChanges();
                return empleado;
            }
        
    }
}