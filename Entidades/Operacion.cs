using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Numeracion PrimerOperando { get { return primerOperando; } set { primerOperando = value; } }
        public Numeracion SegundoOperando { get { return segundoOperando; } set { segundoOperando = value; } }

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            PrimerOperando = primerOperando;
            SegundoOperando = segundoOperando;
        }

        public Numeracion Operar(char operador)
        {
            switch (operador)
            {
                case '-': return new Numeracion(Double.Parse(primerOperando.ValorNumerico) - Double.Parse(segundoOperando.ValorNumerico), 0);
                case '*': return new Numeracion(Double.Parse(primerOperando.ValorNumerico) * Double.Parse(segundoOperando.ValorNumerico), 0);
                case '+': return new Numeracion(Double.Parse(primerOperando.ValorNumerico) + Double.Parse(segundoOperando.ValorNumerico), 0);
                case '/':
                    if (Double.Parse(segundoOperando.ValorNumerico) != 0)
                    {
                        return new Numeracion(Double.Parse(primerOperando.ValorNumerico) / Double.Parse(segundoOperando.ValorNumerico), 0);
                    }
                    throw new Exception("No se puede dividir por cero");
                default:
                    throw new Exception("Operador no reconocido");
            }
        }
    }
}
