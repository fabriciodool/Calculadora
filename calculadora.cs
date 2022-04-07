using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mallu estava na escolinha, e sua professora estava para aplicar uma prova de matemática
com operações básicos. A professora falou que seria possível utilizar uma calculadora.
Então Malluzinha começou a imaginar como seria desenvolver uma calculadora com os
seguintes requisitos:
1. Ter operadores aritméticos básicos: soma, subtração, multiplicação e divisão;
2. A calculadora deve ter um botão para ligar e desligar, não pode parar de rodar
enquanto o botão de desligar não for ativado;

    */

                Console.Write("digite ligar ou desligar: ");

                string ligar = Console.ReadLine();
                          

                Console.WriteLine("Digite o primeiro número: ");

                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");

                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o operador: ");

                string operador = Console.ReadLine();

                int resultado = 0;

                if (operador == "+")
                {
                    resultado = num1 + num2;
                }
                else if (operador == "-")
                {
                    resultado = num1 - num2;
                }
                else if (operador == "*")
                {
                    resultado = num1 * num2;
                }
                else if (operador == "/")
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Operador inválido");
                }
                Console.WriteLine("Resultado: " + resultado);

                Console.Write("Digite sair para sair");

                string sair = Console.ReadLine();
            }
        }
    }
        