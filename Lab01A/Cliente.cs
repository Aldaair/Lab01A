using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01A
{
    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }

        public Cliente(string nombre, double saldo, double litrosCargados) : base(nombre, saldo)
        {
            LitrosCargados = litrosCargados;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"LitrosCargados: {LitrosCargados}");
        }
    }
}
