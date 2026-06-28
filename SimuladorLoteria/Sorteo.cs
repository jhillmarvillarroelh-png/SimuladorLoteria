using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorLoteria
{
    public class Sorteo
    {
        private Random _random;
        public Sorteo()
        {
            _random = new Random();
        }
        public HashSet<int> RealizarSorteo(int cantidad, int min, int max)
        {
            HashSet<int> ganadores = new HashSet<int>();
            while (ganadores.Count < cantidad)
            {
                int numero = _random.Next(min, max + 1);
                ganadores.Add(numero);
            }
            return ganadores;
        }
    }
}
