using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartasEspaniolas
{
    internal class Carta
    {
        public string Palo { get ; set; }

        public int Numero { get; set; }

        public Carta()
        {
        }
        public Carta(int numero, string palo)
        {   
        }
        public void siguienteCarta(List<Carta>Baraja, List<Carta> Monton)
        {
            Carta siguiente = Baraja[0];
            Console.WriteLine($"{siguiente.Numero} {siguiente.Palo}");
            Monton.Add(siguiente);
            Baraja.Remove(siguiente);
        }
        public void Mezclar(List<Carta> Baraja)
        {
            Baraja = Baraja.OrderBy(item => new Random().Next()).ToList();
            foreach(var carta in Baraja)
            {
                Console.WriteLine(carta);
            }
        }
        public void darCartas(List<Carta>Baraja, List<Carta> Monton)
        {
            Console.WriteLine("¿Cuantas cartas repartir a cada uno?");
            var cartasRecibidas = int.Parse(Console.ReadLine());
            if (cartasRecibidas < Baraja.Count)
            {
                for (int i = 0; i < cartasRecibidas; i++)
                {
                    Carta recibida = Baraja[i];
                    Console.WriteLine($"{ recibida.Numero} { recibida.Palo}");
                }
            }
        }
    }
}
