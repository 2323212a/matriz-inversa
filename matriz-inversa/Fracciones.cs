using System;

namespace matriz_inversa
{
    public class Fraccion
    {
        public long Numerador { get; }
        public long Denominador { get; }

        public Fraccion(long numerador, long denominador)
        {
            long gcd = MCD(numerador, denominador);
            Numerador = numerador / gcd;
            Denominador = denominador / gcd;
        }
        public double ADecimal()
        {
            return (double)Numerador / Denominador;
        }

        public static Fraccion DesdeDouble(double valor, double tolerancia = 1.0E-6)
        {
            long denominador = 1;
            long numerador = (long)Math.Round(valor * denominador);

            while (Math.Abs((double)numerador / denominador - valor) > tolerancia && denominador < 10000)
            {
                denominador++;
                numerador = (long)Math.Round(valor * denominador);
            }

            return new Fraccion(numerador, denominador);
        }

        private static long MCD(long a, long b)
        {
            if (b == 0) return Math.Abs(a);
            return MCD(b, a % b);
        }

        public override string ToString()
        {
            if (Denominador == 1)
                return Numerador.ToString();
            else
                return $"{Numerador}/{Denominador}";
        }
    }
}
