using System;

namespace exerciciosLista10
{
    class exerciciosLista10
    {
        static void Main(string[] args)
        {
            questao26();
            //questao28();
            //questao29();
            //questao30();
            //questao31();
            //questao312();
            //questao35();
            //questao38();
            //questao39();
            //questao45();
            //questao49();
            //questao56();
            //questao57();
            //questao59();


            static void questao26()
            {
                /* 26 - Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente. 
                 * */

                for (int num = 100; num >= 1; num--)
                {
                    Console.WriteLine(num);
                }

            }

            static void questao28()
            {
                /* 28) Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.
                 * */

                for (int num = 100; num >= 100 && num <= 200; num++)
                {
                    if (num % 2 == 1)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            static void questao29()
            {
                /*(29) Faça um programa que exiba os números de 1 até 2000. 
                 */

                for (int num = 1; num <= 2000; num++)
                {
                    Console.WriteLine(num);
                }
            }
            static void questao30()
            {
                /* 30) Faça um programa para imprimir uma tabuada. 
                 */
                Console.WriteLine("Informe um número para saber a tabuada: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    int formula = num * i;
                    Console.WriteLine(num + " X " + i + " = " + formula);
                }

            }
            static void questao31()
            {
                /*
                 * 31) Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido 
                 * é par ou ímpar. Exiba ao final a soma total dos números pares lidos e também a soma dos números
                 * ímpares lidos. Suporemos que o número de elementos deste conjunto não é conhecido, e que um 
                 * número negativo será utilizado para sinalizar o fim dos dados.          
                 */

                int numero = 0, qtdPar = 0, qtdImpar = 0;
                while (numero >= 0)
                {
                    Console.WriteLine("Digite um número positivo (negativos encerra): ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero >= 0)
                    {
                        if (numero % 2 == 0)
                        {
                            qtdPar++;
                            Console.WriteLine("O número é par");
                        }
                        else
                        {
                            qtdImpar++;
                            Console.WriteLine("O numero é impar");
                        }
                    }
                }
                Console.WriteLine("Quantidade de numeros pares: " + qtdPar);
                Console.WriteLine("Quantidade de numeros impares: " + qtdImpar);

            }
            static void questao312()
            {
                int numero = 0, somaImpares = 0, somaPares = 0;
                do
                {
                    if (numero != 0)
                    {

                        if (numero % 2 == 0)
                        {
                            Console.WriteLine("O numero é par!");
                            somaPares += numero;
                        }
                        else
                        {
                            Console.WriteLine("O numero é impar!");
                            somaImpares += numero;
                        }
                    }
                    Console.WriteLine("Informe um numero");
                    numero = int.Parse(Console.ReadLine());

                } while (numero > 0);
                Console.WriteLine($"A soma dos numeros pares é igual a {somaPares}");
                Console.WriteLine($"A soma dos numeros pares é igual a {somaImpares}");
            }

            static void questao35()
            {
                /*
                 * 35) Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba 
                 * uma mensagem: "Múltiplo de 10".
                 * 
                 */

                for (int num = 1; num <= 100; num++)
                {

                    if (num % 10 == 0)
                    {

                        Console.WriteLine(num + " -> Multiplo de 10");
                    }
                    else
                    {
                        Console.WriteLine(num);
                    }
                }
            }

            static void questao38()
            {
                /*
                 * 38) Faça um programa que leia as variáveis Ce N, respectivamente código 
                 * e número de horas trabalhadas de um operário. E calcule o salário sabendo-se 
                 * que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule
                 * o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável.
                 * A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o 
                 * salário total e o salário excedente. O programa só deve parar de rodar quando o 
                 * usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?". 
                 */
                int horasNormais = 0, horasExtras = 0;
                char continuacao = 'N';
                while (continuacao != 'S' && continuacao != 's')
                {
                    Console.Clear();
                    Console.WriteLine("Informe as horas trabalhadas no dia de hoje");
                    horasNormais += int.Parse(Console.ReadLine());
                    if (horasNormais > 50)
                    {
                        horasExtras = horasNormais - 50;
                        horasNormais = 50;
                    }
                    else
                    {
                        horasExtras = 0;
                    }
                    Console.WriteLine("Deseja encerrar o programa?");
                    continuacao = Console.ReadKey().KeyChar;        //ReadKey, le a primeira tecla pressionada - KeyChar - Informa a tecla acionada
                }
                Console.Clear();
                Console.WriteLine($"O salário normal é {horasNormais * 10}");
                Console.WriteLine($"O salário excedente é {horasExtras * 20}");
            }
            static void questao39()
            {
                /*
                 * 39) Faça um programa que leia um número inteiro e mostre uma mensagem 
                 * indicando se este número é par ou ímpar, e se é positivo ou negativo. 
                 * O programa só deve parar de rodar quando o usuário responder "S" na 
                 * seguinte pergunta, "Deseja encerrar o programa?" . 
                  * */

                bool parar = false;

                do
                {
                    Console.WriteLine("Informe um numero inteiro: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Numero é par");
                    }
                    else
                    {
                        Console.WriteLine("Número não é par");
                    }
                    if (num < 0)
                    {
                        Console.WriteLine("Numero é negativo");
                    }
                    else
                    {
                        Console.WriteLine("Numero é positivo");
                    }

                    Console.WriteLine("Deseja sair? S/N: ");
                    string letra = Console.ReadLine();
                    if (letra == "S" || letra == "s")
                    {
                        parar = true;
                    }


                } while (parar == false);

            }

            static void questao45()
            {
                /*
                 * 45) Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa 
                 * que foi realizada a leitura. 
                */

                int n = 0;
                int[] vs;

                Console.WriteLine("Escreva a quantidde de números a serem invertida: ");
                n = int.Parse(Console.ReadLine());

                vs = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Informe um número inteiro: ");
                    vs[i] = int.Parse(Console.ReadLine());
                }
                for (int i = n - 1; i >= 0; i--) //INVERTIDO//
                {
                    Console.WriteLine(vs[i]);
                }

            }

            static void questao49()
            {
                /*49) Leia 2 vetores de inteiros V1 e 12 de N componentes cada (no máximo 50). 
                 * Determine e imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições.
                 * 
                 */

                int[] v1, v2;
                int tamanho, identicos = 0;

                Console.WriteLine("Informe o tamanho dos vetores: ");
                tamanho = int.Parse(Console.ReadLine());

                if (tamanho > 0)
                {
                    v1 = new int[tamanho];
                    v2 = new int[tamanho];
                    for (int i = 0; i < tamanho; i++)
                    {
                        Console.WriteLine("Informe o um número para v1: ");
                        v1[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o um número para v2: ");
                        v2[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < tamanho; i++)
                    {
                        if (v1[i] == v2[i])
                        {
                            identicos++;
                        }

                    }
                    Console.WriteLine($"Nos dois vetores há {identicos} numeros identicos");
                }

            }

            static void questao56()
            {
                /*
                 * 56) Fazer um programa para ler um vetor de inteiros positivos de 50 posições. 
                 * Imprimir a quantidade de números pares e de múltiplos de 5

                 */

                int[] numeros = new int[50];
                int qtdPar = 0, qtdMultiplo = 0;

                for (int i = 0; i < 50; i++)
                {
                    if (i % 2 == 0)
                    {
                        qtdPar++;
                    }

                    if (i % 5 == 0)
                    {
                        qtdMultiplo++;
                    }
                }

                Console.WriteLine("Quantidade pares: " + qtdPar);
                Console.WriteLine("Quantidade multiplos de 5: " + qtdMultiplo);

            }
            static void questao57()
            {
                /* 57 Fazer um programa que leia uma frase e imprima somente as vogais. 

                 */
                string palavra;
                string[] vogais = new string[] { "A", "E", "I", "O", "U" };
                bool achou = false;
                Console.WriteLine("Informe uma palavra: ");
                palavra = Console.ReadLine().ToUpper().Trim(); //letra maiuscula ou toLower minuscula
                for (int i = 0; i < palavra.Length; i++)
                {
                    string letra = palavra.Substring(i, 1);
                    for (int j = 0; j < vogais.Length; j++)
                    {
                        achou = letra == vogais[j];
                        if (achou)
                        {
                            break;
                        }
                        //achou = letra.Equals(vogais[j],StringComparison.InvariantCultureIgnoreCase);
                        //if (achou)
                        //{
                        //    break;
                        //}
                    }
                    if (achou)
                    {
                        Console.Write(letra + " ");
                    }
                }

            }

            static void questao59()
            {
                /*
                 * 59) Escreva um programa que solicite dois caracteres de A a Z ao usuário e 
                 * imprima o número de caracteres existente entre eles. Assuma que o usuário 
                 * digite os 2 caracteres em ordem alfabética. Caso não o estejam, emitir 
                 * mensagem de erro. Exemplo: Digite 2 caracteres:jto numero de caracteres 
                 * entre eles é: 9 
                */
                char char1, char2;

                Console.WriteLine("Informe um caracter de A a Z: ");
                char1 = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine("Informe outro caracter de A a Z: ");
                char2 = char.Parse(Console.ReadLine().ToUpper());
                if (char1 > char2)
                {
                    Console.WriteLine("Caracteres fora de ordem alfabética: ");
                }
                else
                {
                    int distancia = (char2 - char1) - 1;
                    Console.WriteLine($"Há {distancia} numeros entre si");
                }

            }

        }
    }
}
