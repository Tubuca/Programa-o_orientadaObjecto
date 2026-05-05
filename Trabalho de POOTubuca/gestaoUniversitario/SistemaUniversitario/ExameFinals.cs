using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    public class ExameFinal : Avaliacao
    {
        public float NotaExame {  get; set; }

        public ExameFinal(float peso,float nota) : base(peso) { NotaExame = nota; }

        public override float CalcularNotaFinal() => NotaExame = Peso;
      

    }
}
