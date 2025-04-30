using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contagem();
            //Limite();
            //Numero();
            //Numero1();
            //Senha();
            //Calculadora();

            //Console.Write("Digite o seu salário: ");
            //double valor = Convert.ToDouble(Console.ReadLine());
            //Conversao(valor);

            //Console.WriteLine("Digite um valor: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite um segundo valor: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite um terceiro valor: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite um quarto valor: ");
            //double num4 = Convert.ToDouble(Console.ReadLine());
            //double valor1 = num1 * num2 * num3 * num4;
            //Mult(valor1);
        }

        public static void Contagem()
        {
            int n = 0;

            while (n <= 1000)
            {
                Console.WriteLine(n);
                n++;
            }
        }

        public static void Limite()
        {
            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = 0;

            while (n <= num)
            {
                Console.WriteLine(n);
                n++;
            }
            
        }

        public static void Numero()
        {
            int n = 5000;

            while (n <= 10000)
            {
                Console.WriteLine(n);
                n++;
            }
        }

        public static void Numero1()
        {
            int n = 0;

            while (n <= 7000)
            {
                Console.WriteLine(n);
                n++;

                if (n == 5501)
                {
                    break;
                }
            }
        }

        public static void Senha()
        {
            int valor = 4513;
            int senha;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite a senha: ");
            Console.ResetColor();
            senha = Convert.ToInt32(Console.ReadLine());

            while (senha != valor)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Senha incorreta!!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite novamente: ");
                Console.ResetColor();
                senha = Convert.ToInt32(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Senha validada com sucesso!");
            Console.ResetColor();
        }

        public static void Calculadora()
        {
            Console.WriteLine("App calculadora\n");
            
            Console.Write("Digite um valor inteiro: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um segundo valor inteiro: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEscolha a opção desejada:\n 1 - SOMA\n 2 - SUBTRAÇÃO\n 3 - MULTIPLIÇÃO\n 4 - DIVISÃO\n> ");
            string escolha = Console.ReadLine();

            while (escolha != "1" && escolha != "2" && escolha != "3" && escolha != "4")
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Opção inválida!");
                Console.ResetColor();

                Console.Write("Escolha a opção desejada:\n 1 - SOMA\n 2 - SUBTRAÇÃO\n 3 - MULTIPLIÇÃO\n 4 - DIVISÃO\n> ");
                escolha = Console.ReadLine();
            }

            switch (escolha)
            {
                case "1":

                    int soma = num1 + num2;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O resultado da soma é: " + soma);
                    Console.ResetColor();
                    break;

                case "2":

                    int subtracao = num1 - num2;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O resultado da subtração é: " + subtracao);
                    Console.ResetColor();
                    break;

                case "3":

                    int mult = num1 * num2;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O resultado da multiplição é: " + mult);
                    Console.ResetColor();
                    break;

                case "4":

                    if (num2 != 0)
                    {
                        int divisao = num1 / num2;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O resultado da divisão é: " + divisao);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("O calculo ira dar erro de divisão por zero!");
                    }
                    break;
            }
        }

        public static void Conversao(double salario)
        {
            Console.Write("Escolha a conversão desejada:\n 1 - Dolár\n 2 - Euro\n 3 - Iene\n> ");
            string escolha = Console.ReadLine();

            while (escolha != "1" && escolha != "2" && escolha != "3")
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Opção inváilida!");
                Console.ResetColor();

                Console.Write("Escolha a conversão desejada:\n 1 - Dolár\n 2 - Euro\n 3 - Iene\n> ");
                escolha = Console.ReadLine();
            }

            switch (escolha)
            {
                case "1":

                    double conv = salario / 5;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A conversão do seu salário para Dolár é de: " + conv);
                    Console.ResetColor();
                    break;

                case "2":

                    double conv1 = salario / 6;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A conversão do seu salário para Euro é de: " + conv1);
                    Console.ResetColor();
                    break;

                case "3":

                    double conv2 = salario / 30.35;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A conversão do seu salário para Iene é de: " + conv2);
                    Console.ResetColor();
                    break;
            }
        }

        public static void Mult(double valor)
        {
            if (valor > 3000)
            {
                double divisao = valor / 2;
                if (divisao % 2 != 0)
                {
                    Console.WriteLine("O resultado da multiplicação foi dividido por 2\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O valor final é impár: " + valor);
                    Console.ResetColor();
                }
                else if (divisao % 2 == 0)
                {
                    Console.WriteLine("O resultado da multiplicação foi dividido por 2\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O valor final é par: " + valor);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Digite uma novo valor: ");
                double novoV = Convert.ToDouble(Console.ReadLine());

                double divisao1 = valor * novoV;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O novo valor dividido pelo o resultado da multiplicação é: " +  divisao1);
                Console.ResetColor();
            }
        }

        public static void ChaveSecreta()
        {
            Console.WriteLine("Digite uma chave de 0 a 9: ");
            int chave = Convert.ToInt32(Console.ReadLine());

            while (chave > 100000000)
            {

            }
        }
    }
}
