namespace TesteSoftware
{
    public class Calculadora
    {
        public static int Somar (int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Subtrair (int n1, int n2)
        {
            return n1 - n2;
        }
        public static double Dividir (int n1, int n2)
        {
            if (n2 ==0)
            {
                throw new DivideByZeroException ("Não é possível dividir por zero!");
            }
            return(double)n1 / n2;
        }
        public static int Multiplicar (int n1, int n2)
        {
            return n1 * n2;
        }
        public static (double? raiz1, double? raiz2) Bhaskara (double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double raiz2 = (-b - Math.Sqrt(delta)) / 2 * a;
                return (raiz1, raiz2);
            }
            else if(delta == 0)
            {
                double raiz = -b / (2 * a);
                return (raiz, raiz);
            }
            else
            {
                return (null, null);
            }
        }
    }

    public class Voto
    {
        public String PodeVotar(int idade)
        {
            if (idade < 16)
            {
                return "Não pode votar.";
            }
            else if (idade >= 18 && idade <= 70)
            {
                return "Voto obrigatório.";
            }
            else
            {
                return "Voto facultativo.";
            }
        }
    }
}
