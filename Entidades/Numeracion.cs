using System.Linq;
using System.Text;

namespace Entidades
{
    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        public ESistema Sistema { get { return sistema; } }

        public string ValorNumerico
        {
            get
            {
                if (Sistema == ESistema.Binario)
                {
                    return DecimalABinario((int)this.valorNumerico);
                }
                return valorNumerico.ToString();
            }
        }

        private double BinarioADecimal(string valor)
        {
            string nueva = Revertir(valor);
            double suma = 0;
            int contador = 0;
            if (EsBinario(valor))
            {
                foreach (char i in nueva)
                {
                    if (i == '1')
                    {
                        suma += (int)Math.Pow(2, contador);
                    }
                    contador++;
                }
            }
            return suma;
        }

        private string Revertir(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this.valorNumerico.ToString(); ;
            }
            else
            {
                return this.DecimalABinario((int)valorNumerico);
            }
        }

        private string DecimalABinario(int valor)
        {
            List<int> binario = new List<int>();
            //Math.Abs(valor);
            if (valor >= 0)
            {

                while (valor > 1)
                {
                    binario.Add(valor % 2);
                    valor = valor / 2;
                }
                if (valor <= 1)
                    binario.Add(valor);

                binario.Reverse();
                StringBuilder sb = new StringBuilder();
                foreach (int i in binario)
                {
                    sb.Append($"{i}");
                }
                return sb.ToString();
            }
            return "Número inválido";
        }

        private string DecimalABinario(string valor)
        {
            return DecimalABinario(Int16.Parse(valor));
        }

        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                if (c == '0' || c == '1')
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void InicializarValores(string valor, ESistema sistema)
        {
            if (sistema == ESistema.Decimal && Double.TryParse(valor, out double valorParseado))
            {
                this.valorNumerico = valorParseado;
                this.sistema = sistema;
            }
            else if (sistema == ESistema.Binario && EsBinario(valor))
            {
                this.valorNumerico = BinarioADecimal(valor);
                this.sistema = sistema;
            }

        }

        public Numeracion(double valor, ESistema sistema)
        {
            InicializarValores(valor.ToString(), sistema);
        }

        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        #region Operadores

        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }

        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.Sistema == n2.Sistema;
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            double resultado = Double.MinValue;
            if (Double.TryParse(n1.ValorNumerico, out double valor1) && Double.TryParse(n2.ValorNumerico, out double valor2))
            {
                resultado = valor1 + valor2;
            }
            return new Numeracion(resultado, n1.Sistema);
        }
        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            double resultado = Double.MinValue;
            if (Double.TryParse(n1.ValorNumerico, out double valor1) && Double.TryParse(n2.ValorNumerico, out double valor2))
            {
                resultado = valor1 - valor2;
            }
            return new Numeracion(resultado, n1.Sistema);
        }
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            double resultado = Double.MinValue;
            if (Double.TryParse(n1.ValorNumerico, out double valor1) && Double.TryParse(n2.ValorNumerico, out double valor2))
            {
                resultado = valor1 * valor2;
            }
            return new Numeracion(resultado, n1.Sistema);
        }
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            double resultado = Double.MinValue;
            if (Double.TryParse(n1.ValorNumerico, out double valor1) && Double.TryParse(n2.ValorNumerico, out double valor2) && valor2 != 0)
            {
                resultado = valor1 / valor2;
            }
            return new Numeracion(resultado, n1.Sistema);
        }
        #endregion
    }

    public enum ESistema
    {
        Decimal,
        Binario
    }
}
