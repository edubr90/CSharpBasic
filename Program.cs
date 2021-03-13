using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. 
            //Escreva um programa que leia o número de maçãs compradas, 
            //calcule e escreva o valor total da compra.
            //Exercise1();


            //2 - Escreva um programa para ler o ano de nascimento de uma pessoa e escrever uma mensagem 
            //que diga se ela poderá ou não votar este ano(não é necessário considerar o mês em que ela nasceu).
            //Exercise2();

            //3 - Elabore um algoritmo que dada a idade de um nadador classifique-o em uma das seguintes categorias: 
            //Infantil A = 5 a 7 anos Infantil B = 8 a 11 anos 
            //Juvenil A = 12 a 13 anos 
            //Juvenil B = 14 a 17 anos 
            //Adultos = Maiores de 18 anos.
            //Exercise3();

            //4 - Tendo como dados de entrada a altura e o sexo de uma pessoa, 
            //construa um algoritmo que calcule seu peso ideal, 
            //utilizando as seguintes fórmulas: 
            //Para homens: (72.7 * h) - 58 
            //Para mulheres: (62.1 * h) - 44.7
            //(h = altura)
            //Exercise4();

            //5 - Elabore um alg que leia um número. 
            //Se positivo armazene - o em A, se for negativo, em B.
            //No final mostrar o resultado
            //Exercise5();

            //C Sharp III 030321
            //Vence 7 de março de 2021 23:59
            //Instruções
            //Faça os seguintes programas em C#:

            //1)  Escreva um algoritmo que leia um valor inicial A 
            //e imprima a seqüência de valores do cálculo de A! e o seu resultado. 
            //Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
            //Exercise6();

            //2) Escrever um algoritmo que leia um valor para uma variável N de 1 a 10
            //e calcule a tabuada de N. Mostre a tabuada na forma: 
            //0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N = 10N.
            //Exercise7();

            //C Sharp IV 100321
            //Vence amanhã às 23:59
            //Instruções
            //Faça os seguintes exercícios em c#:

            //1) Receba um array de inteiros e retorna a quantidade de elementos 
            //do array que são números negativos.
            //Exercise8();

            //2) Receber 10 valores em um array e fazer a soma dos valores.
            //Exercise9();

        }



        
        private static void Exercise1()
        {

            decimal applesSmallerThanDozenPrice = 0.30m;
            decimal applesLargerThanDozenPrice = 0.25m;

            Console.WriteLine("Digite quantas maçãs você comprou...");
            var userResult = Console.ReadLine();

            int valueResult = 0;

            if (Int32.TryParse(userResult, out valueResult))
            {

                var totalPrice = valueResult >= 12
                    ? valueResult * applesLargerThanDozenPrice
                    : valueResult * applesSmallerThanDozenPrice;

                Console.WriteLine(String.Format("\nValor total da compra: R$ {0}", totalPrice));
            }
            else
                Console.WriteLine("O valor informado não é um número inteiro!");

            Console.ReadKey();
        }

        private static void Exercise2()
        {


            int limitAge = 16;
            Console.WriteLine("Qual é o seu ano de nascimento?");
            var valueResult = Console.ReadLine();

            int enteredValue = 0;

            if (Int32.TryParse(valueResult, out enteredValue))
            {
                var currentYear = DateTime.Now.Year;
                int ageCalculated = currentYear - enteredValue;

                if (ageCalculated < limitAge)
                    Console.WriteLine("A sua idade ainda não permite votação");
                else
                    Console.WriteLine("A sua idade é válida para a votação");
            }
            else
                Console.WriteLine("O valor fornecido é inválido!");

            Console.ReadKey();


        }

        private static void Exercise3()
        {
            Console.WriteLine("Digite a sua idade...");
            var userEntry = Console.ReadLine();

            int entryResult = 0;
            if(Int32.TryParse(userEntry, out entryResult))
            {
                int ageResult = entryResult;

                if(ageResult < 5)
                    Console.WriteLine("Idade não atinge o mínimo necessário");
                if (ageResult >= 5 && ageResult < 8)
                    Console.WriteLine("Categoria Infantil A");
                else if (ageResult >= 8 && ageResult < 12)
                    Console.WriteLine("Categoria Infantil B");
                else if (ageResult >= 12 && ageResult < 14)
                    Console.WriteLine("Categoria Juvenil A");
                else if (ageResult >= 14 && ageResult < 18)
                    Console.WriteLine("Categoria Juvenil B");
                else if (ageResult >= 18)
                    Console.WriteLine("Categoria Adulto");
            }
            else
                Console.WriteLine("Idade informada não é um número inteiro");

            Console.ReadKey();


        }

        private static void Exercise4()
        {
            Console.WriteLine("Digite a sua altura...");
            var height = Console.ReadLine();

            Console.Write("Digite o seu sexo...");
            var genre = Console.ReadLine();
            decimal heightResult = 0;

            if (decimal.TryParse(height, out heightResult))
            {
                decimal recomendedHeight = 0;
                if (genre.Contains("Masculino") || genre.Contains("Masc") || genre.Contains("M"))
                    recomendedHeight = (72.7m * heightResult) - 58;
                else if (genre.Contains("Feminino") || genre.Contains("Fem") || genre.Contains("F"))
                    recomendedHeight = (62.1m * heightResult) - 44.7m;

                if (recomendedHeight > 0)
                    Console.WriteLine("O cálculo do seu peso ideal é " + recomendedHeight);
                else
                    Console.WriteLine("Não foi possível calcular o peso ideal");


            }
            else
                Console.WriteLine("O valor digitado não é válido");

            Console.ReadKey();

            
        }

        private static void Exercise5()
        {
            Console.WriteLine("Digite um número");
            var entryValue = Console.ReadLine();

            int value = 0;
            if (Int32.TryParse(entryValue, out value))
            {
                int a = 0;
                int b = 0;

                a = value >= 0 ? value : a;
                b = value < 0 ? value : b;

                var message = string.Format
                    ("O valor digitado está armazenado em {0} e é um numero {1}",
                    value >= 0 ? "A" : "B",
                    value >= 0 ? "Positivo" : "Negativo");

                Console.WriteLine(message);
            }
            else
                Console.WriteLine("O valor digitado não é um número");

            Console.ReadKey();
        }

        private static void Exercise6()
        {
            Console.WriteLine("Digite um numero");
            var entryValue = Console.ReadLine();

            int value = 0;

            if (Int32.TryParse(entryValue, out value))
            {

                int result = 0;
                string message = string.Format("{0} x ", value);

                for (int i = value - 1; i >= 1; i--)
                {
                    if (result == 0)
                        result = value * i;
                    else
                        result = result * i;

                    message += i == 1
                        ? string.Format("{0} = {1}", i, result)
                        : string.Format("{0} x ", i);
                }

                Console.WriteLine(message);

            }
            else
                Console.WriteLine("O valor digitado não é um número!");

            Console.ReadKey();
        }

        private static void Exercise7()
        {
            Console.WriteLine("Digite um número de 1 a 10");
            var entryValue = Console.ReadLine();

            int value = 0;
            if (Int32.TryParse(entryValue, out value))
            {

                if (value > 0 && value < 11)
                {

                    string message = "";

                    for (int i = 0; i <= 10; i++)
                    {
                        int result = value * i;
                        message += string.Format("{0} x {1} = {2}, ", value, i, result);
                    }

                    Console.WriteLine(message);

                }
                else
                    Console.WriteLine("O valor digitado não está entre 1 e 10");

            }
            else
                Console.WriteLine("O valor digitado não é um número inteiro!");

            Console.ReadKey();
        }

        private static void Exercise8()
        {
            Console.WriteLine("Digite valores númericos separando por vírgula(,)");
            string userEntry = Console.ReadLine();

            var values = userEntry.Trim().Split(',');

            int negativeCount = 0;

            foreach (var value in values)
            {
                int val = 0;
                if (Int32.TryParse(value, out val))
                {
                    if (val < 0)
                        negativeCount++;
                }
                else
                    Console.WriteLine(string.Format("O valor {0} nao é um numero!", value));
            }

            Console.WriteLine(string.Format("O array informado contem {0} números negativos", negativeCount));

            Console.ReadKey();
        }

        private static void Exercise9()
        {
            Console.WriteLine("Digite valores númericos separando por vírgula(,)");
            string userEntry = Console.ReadLine();

            var values = userEntry.Trim().Split(',');

            int sum = 0;

            foreach (var value in values)
            {
                int val = 0;
                if (Int32.TryParse(value, out val))
                {
                    sum += val;
                }
                else
                    Console.WriteLine(string.Format("O valor {0} nao é um numero!", value));
            }

            Console.WriteLine(string.Format("A soma dos valores do array é {0}", sum));

            Console.ReadKey();
        }

    }
}
