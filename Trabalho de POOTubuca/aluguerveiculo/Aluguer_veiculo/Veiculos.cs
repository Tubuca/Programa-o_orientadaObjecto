using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguer_veiculo
{
    public class Veiculo
    {
        private String Matricula;

        private String Marca;

        private double Quilometragem;

        private String Modelo;

        private int AnoFabricacao;

        private String Cor;

       

        public Veiculo(String matricula, String marca, double km, String modelo, int ano, String cor)
        {
            Matricula = matricula;
            Marca = marca;
            Quilometragem = km;
            Modelo = modelo;
            AnoFabricacao = ano;
            Cor = cor;
        }

        public String get_Matricula()
        {
            return Matricula;
        }

        public void set_Matricula(String value)
        {
            Matricula = value;
        }

        public String get_Marca()
        {
            return Marca;
        }

        public void set_Marca(String value)
        {
            Marca = value;
        }

       

        public String get_Modelo()
        {
            return Modelo;
        }

        public void set_Moledo(String value)
        {
            Modelo=value;
        }

        public int get_AnoFabricacao()
        {
            return AnoFabricacao;
        }

        public void set_AnoFabricacao(int value)
        {
            AnoFabricacao = value;
        }
        public double get_Quilometragem()
        {
            return Quilometragem;
        }
        public String get_Cor()
        {
            return Cor;
        }

        public void set_Cor(String value)
        {
          Cor = value;
        }

        public void AtualizarQuilomentragem(double  quimpercoridos)

        {
            if (quimpercoridos > 0)
            {
                this.Quilometragem += quimpercoridos;
            }

        }

        public void ApresentarDados()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"Veiculo: {Marca}  {Modelo}");
            Console.WriteLine($"Matricula: {Matricula} | Cor: {Cor}");
            Console.WriteLine($"Quilometragem:  {Quilometragem} km");
            Console.WriteLine("---------------------------------------------------------------");
        }

    }

}
