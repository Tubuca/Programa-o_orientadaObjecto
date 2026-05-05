using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    public class Estudante : Pessoa
    {
        public int numMatricula {  get; set; }

        public String Curso { get; set; }
        public float NotaAcumulada {  get; set; }


    }
}
