using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calc");
            while (true)
            {
                Console.WriteLine("Escolha uma operacao");
                string pergunta = """
                1 - Soma
                2 - Subtrair
                3 - Dividir
                4 - Multiplicar
                """;
                Console.WriteLine(pergunta);

                ReadResult read = new ReadResult(); //criação do objeto
                string operacao = read.Read(); //nome da função/acessar (o "." e a porta pra acessar)

                Console.WriteLine("Digite um numero:");
                string num1 = read.Read();
                decimal convertido1 = read.ConvertFromString(num1);
                Console.WriteLine("Digite outro numero:");
                string num2 = read.Read();
                decimal convertido2 = read.ConvertFromString(num2);
                Calculadora calc = new Calculadora();


                decimal resultado = operacao switch  
                {
                    "1" => calc.Somar(convertido1, convertido2),
                    "2" => calc.Subtrair(convertido1, convertido2),
                    "3" => calc.Dividir(convertido1, convertido2),
                    "4" => calc.Multiplicar(convertido1, convertido2),
                    _ => decimal.MinValue
                };
                Console.WriteLine("O resultado é " + resultado);
            }
        }
    }
}

