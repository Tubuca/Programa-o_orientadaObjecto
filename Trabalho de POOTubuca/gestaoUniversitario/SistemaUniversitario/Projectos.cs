using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    public class Projecto : Avaliacao
    {
        public float NotaPratica { get; set; }

        public float NotaDefesa { get; set; }
        public Projecto(float peso,float pratica, float defesa ) : base(peso) { 

            NotaPratica = pratica;
            NotaDefesa = defesa;
        }   

        public override float CalcularNotaFinal() => ((NotaPratica+NotaDefesa)/2) * Peso;
       

    }
}
