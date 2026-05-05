 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    public  class Testes:Avaliacao
    {
        public float NotaTeorica {  get; set; }

        public Testes(float peso, float nota) : base(peso) { NotaTeorica = nota; }
        public override float CalcularNotaFinal() => NotaTeorica * Peso;
   }
}
