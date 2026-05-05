using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    public class UnidadeCurricular
    {
        public string Nome { get; set; }

        public int Codigo { get; set; }

        private List<Avaliacao>_avaliacoes = new List<Avaliacao>();
        private List<Estudante>_estudantes  = new List<Estudante>();

        public void AdicionarAvaliacao(Avaliacao aval) => _avaliacoes.Add(aval);
        public void InscreverEstudante(Estudante est)=> _estudantes.Add(est);


        public void EmitirPauta()
        {
            Console.WriteLine($"---Pauta--:{Nome} ({Codigo}) ---");

            var pauta = _estudantes.Select(est => new
            {
                Nome= est.Nome,
                NotaFinal =_avaliacoes.Sum(a => a.CalcularNotaFinal())

            })

                .OrderByDescending(x => x.NotaFinal);
            foreach (var item in pauta)
            {
                Console.WriteLine($"Estudante: {item.Nome} | Nota Final: {item.NotaFinal:F2}");
            }

        }

      

    }
}
