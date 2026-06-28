using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorLoteria
{
    public class Jugador
    {
        public HashSet<int> NumerosElegidos { get; private set; }
        public Jugador()
        {
            NumerosElegidos = new HashSet<int>();
        }
        public string RegistrarNumero(int numero, int min, int max)
        {
            if (numero < min || numero > max)
            {
                return $"Error! El numero {numero} debe estar entre {min} y {max}.";
            }
            if (!NumerosElegidos.Add(numero))
            {
                return $"El numero {numero} ya fue seleccionado! registrado correctamente.";
            }

            return string.Empty; // Esto no se alcanzará debido a los retornos anteriores, pero se incluye para evitar advertencias de compilación.
        }
        public void LimpiarJugada()
        {
            NumerosElegidos.Clear();
        }
    }
}
