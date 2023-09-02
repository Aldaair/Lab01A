using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01A
{
    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }

        public Empleado(string nombre, double saldo, double sueldo) : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"LitrosCargados: {Sueldo}");
        }
    }
}
