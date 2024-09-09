using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Guerrero
    {
        public string nombre;
        public int nivel = 0;
        public double experiencia = 0;
        public bool tieneOrejas;
        public int orejasDeVictimas;
        public float ataque = 35f;

        public Guerrero()
        {

        }
        public Guerrero(string argNombre)
        {
            this.nombre = argNombre;
        }
        public void Atacar()
        {
            Console.WriteLine("Atacando");
        }
        
        public int VerNive()
        {
            return nivel;
        }

        public void RecibirExperiencia (double nuevaExperiencia)
        {
            experiencia += nuevaExperiencia;
            if (experiencia > 10)
            {
                nivel++;
                experiencia = 0;
            }
        }
    }
}
