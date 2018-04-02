using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento)
        {
            double icms = new ICMS().CalculaICMS(orcamento);
            Console.WriteLine(icms);
        }
    }
}
