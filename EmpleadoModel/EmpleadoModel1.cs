using Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmpleadoModel
{
    public class EmpleadoModel1
    {
        public EmpleadoModel1()
        {

        }
        public Empleado1[] empleados;
        public void add(Empleado1 e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("Error, no puede ser null");
            }
            else if (empleados == null)
            {
                    empleados = new Empleado1[1];
                    empleados[0] = null;
            }
            else 
            {
                Empleado1[] tmp = new Empleado1[empleados.Length+1];
                Array.Copy(empleados,tmp,empleados.Length);
                empleados = new Empleado1[tmp.Length];
                Array.Copy(tmp, empleados, tmp.Length - 1);
                empleados[tmp.Length - 1] = e;

            }
            
        }
    }
    
}
