using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoModel1
{
    public class EmpleadoModel
    {
        public EmpleadoModel()
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
                empleados[0] = e;
            }
            else
            {
                Empleado1[] tmp = new Empleado1[empleados.Length + 1];
                Array.Copy(empleados, tmp, empleados.Length);
                empleados = new Empleado1[tmp.Length];
                Array.Copy(tmp, empleados, tmp.Length - 1);
                empleados[tmp.Length - 1] = e;

            }

        }
        public decimal SalarioMaximo()
        {
            decimal max = decimal.MinValue;
            int a = empleados.Length;
            for (int i=0;i<a;i++)
            {
                if (max<empleados[i].Sueldo)
                {
                    max = empleados[i].Sueldo;
                }
            }
            return max;
        }
        public decimal SalarioMinimo()
        {
            decimal min = decimal.MaxValue;
            int a = empleados.Length;
            for (int i = 0; i < a; i++)
            {
                if (min > empleados[i].Sueldo)
                {
                    min = empleados[i].Sueldo;
                }
            }
            return min;
        }
        public decimal promedio()
        {
            decimal promedio = 0;
            for (int i = 0; i < empleados.Length; i++)
            {
                promedio += empleados[i].Sueldo;

            }
            promedio = promedio / empleados.Length;
            return promedio;
        }
        public string Encima()
        {
            decimal a = promedio();
            string b="";
            for (int i = 0; i<empleados.Length;i++)
            {
                if (a < empleados[i].Sueldo)
                {
                    b = "Sueldo numero"+(i+1)+": " + empleados[i].Sueldo;
                }
            }
            return b;
        }
    }
}
