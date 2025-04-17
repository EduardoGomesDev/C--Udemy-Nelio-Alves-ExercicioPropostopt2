using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercicioPropostoPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios Propostos Pt 2");
            Console.WriteLine();

            // Exercício 01: 
            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            Console.Write("Digite um número inteiro qualquer: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine($"O número: {numero} é negativo.");
            }
            else
            {
                Console.WriteLine($"O número: {numero} é positivo.");
            }

            // Exercício 02: 
            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            Console.Write("Digite um número inteiro qualquer: ");
            int numeroInt = int.Parse(Console.ReadLine());

            if (numeroInt % 2 == 0)
            {
                Console.WriteLine($"O número {numeroInt} é Par!");
            }
            else
            {
                Console.WriteLine($"O número {numeroInt} é Ímpar!");
            }

            // Exercício 03
            // Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
            // Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
            // ordem crescente ou decrescente. 
            Console.Write("Digite um valor inteiro para A: ");
            int valorA = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor inteiro para B: ");
            int valorB = int.Parse(Console.ReadLine());

            if (valorA % valorB == 0 || valorB % valorA == 0)
            {
                Console.WriteLine($"Os valores: {valorA} e {valorB} são múltiplos!");
            }
            else
            {
                Console.WriteLine($"Os valores: {valorA} e {valorB} não são múltiplos!");
            }

            // Exercício 04
            // Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            // começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            Console.Write("Digite a hora inicial do jogo: ");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.Write("Digite a hora final do jogo: ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao = 0;
            if (horaFinal > horaInicial)
            {
                // Caso o jogo termine no mesmo dia
                duracao = horaFinal - horaInicial;
            }
            else
            {
                // Caso termine no dia seguinte
                duracao = (24 - horaInicial) + horaFinal;
            }
            // Garantir que a duração seja válida (mínimo 1h, máximo 24 horas)
            if(duracao <= 0 || duracao > 24)
            {
                Console.WriteLine("Duração inválida!");
            }
            else
            {
                Console.WriteLine($"A duração do jogo foi de {duracao} horas.");
            }

            // Execício 05
            // Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            // seguir, calcule e mostre o valor da conta a pagar.

            Console.WriteLine(" Codigo | Especificação   | Preço");
            Console.WriteLine(" 1      | Cachorro quente | R$4.00");
            Console.WriteLine(" 2      | X-Salada        | R$4.50");
            Console.WriteLine(" 3      | X-Bacon         | R$5.00");
            Console.WriteLine(" 4      | Torrada Simples | R$2.00");
            Console.WriteLine(" 5      | Refrigerante    | R$1.50");

            Console.WriteLine();

            Console.Write("Digite o código do produto que você deseja: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do produto que você deseja: ");
            int quantidade = int.Parse(Console.ReadLine());

            if(codigo == 1)
            {
                double valorTotal = (double)quantidade * 4.00;
                Console.WriteLine("Valor total = R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(codigo == 2)
            {
                double valorTotal = (double)quantidade * 4.50;
                Console.WriteLine("Valor total = R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(codigo == 3)
            {
                double valorTotal = (double)quantidade * 5.00;
                Console.WriteLine("Valor total = R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                double valorTotal = (double)quantidade * 2.00;
                Console.WriteLine("Valor total = R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                double valorTotal = (double)quantidade * 1.50;
                Console.WriteLine("Valor total = R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Código invalido, digite novamente.");
            }

            // Exercício 06
            // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
            // seguintes intervalos([0, 25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            // nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”. 
            Console.Write("Digite um número qualquer: ");
            double intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(intervalo < 0.0 || intervalo > 100.0) 
            {
                Console.WriteLine("Fora do intervalo");
            }
            else if(intervalo <= 25)
            {
                Console.WriteLine("Intervalo (0, 25]");
            }
            else if(intervalo <= 50)
            {
                Console.WriteLine("Intervalo (25, 50]");
            }
            else if (intervalo <= 75)
            {
                Console.WriteLine("Intervalo (50, 75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75, 100]");
            }

            // Exercício 08 
            // Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem 
            // que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            // qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$

            // Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
            // mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

            //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de 
            // salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido(abaixo), a taxa é
            // de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
            // duas casas decimais.

            Console.WriteLine("Renda                    | Imposto de Renda");
            Console.WriteLine("De 0.00 a R$2000.00      | Isento");
            Console.WriteLine("De R$2000.01 a R$3000.00 | 8%");
            Console.WriteLine("De R$3000.01 a R$4500.00 | 18%");
            Console.WriteLine("Acima de R$4500.00       | 28%");
            Console.WriteLine();

            Console.Write("Digite o salário de um morador de Lisarb: R$");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if(salario <= 2000.00)
            {
                imposto = 0.0;
            }
            else if(salario <= 3000.00)
            {
                imposto = (salario - 1000.00) * 0.08;
            }
            else if(salario <= 4500.00)
            {
                imposto = (salario - 3000.00) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }

            if(imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}