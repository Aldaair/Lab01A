using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01A
{
    public class Grifo
    {
        //Propiedades de Nav
        public List<Usuario> Griferos { get; set; }


        public Grifo(List<Usuario> b)
        {
            Griferos = b;
        }

        private int Count = 0;
        public void MostrarUsuarios(List<Usuario> usuarios)
        {
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"{Count++}");
                usuario.ShowInfo();
            }
        }
    }
}
