using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    public abstract class Avaliacao : IAvaliavel
    {
        public float Peso {  get; set; }

        public DateTime Data { get; set; }

        protected Avaliacao(float peso)
        {
          Peso = peso;
        }

        public abstract float CalcularNotaFinal();
       

    }

}
