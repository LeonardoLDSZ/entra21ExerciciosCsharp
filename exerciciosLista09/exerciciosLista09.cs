using System;

namespace exerciciosLista09
{
    class exerciciosLista09
    {
        static void Main(string[] args)
        {
            questao01();
            //questao02();
            //questao03();
            //questao04();
            //questao05();
            //questao06();
            //questao07();
            //questao08();
            //questao09();
            //questao10();
            //questao11();
            //questao12();
            //questaoSwitch01();
            //questaoSwitch02();
            //questaoSwitch03();

            static void questao01()
            {
                //1 Ler dois valores inteiros para as variáveis A e B, efetuar a 
                //troca dos valores de modo que a variável A passe a possuir o 
                //valor da variável B, e a variável B passe a possuir o valor 
                //da variável A. Apresentar os valores trocados.
                Console.WriteLine("Informe a: ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe b: ");
                int b = int.Parse(Console.ReadLine());

                int aux = a;
                a = b;
                b = aux;

                Console.WriteLine("a: " + a);
                Console.WriteLine("b: " + b);
            }
            static void questao02()
            {
                //2 Escreva um programa que leia um número inteiro e exiba o seu módulo.
                //O módulo de um número x é: x se x for maior ou igual a zero
                //x * (-1) se x é menor que zero


                Console.WriteLine("Informe o número: ");
                int numero = int.Parse(Console.ReadLine());
            }
            static void questao03()
            {
                // 3 Escreva um programa que leia 3 números inteiros e imprima 
                //na tela os valores em ordem decrescente.

                Console.WriteLine("Diga o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Diga o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Diga o terceiro número: ");
                int n3 = int.Parse(Console.ReadLine());

                if (n1 > n2 && n2 > n3)
                {
                    Console.WriteLine(n1 + " " + n2 + " " + n3);
                }
                else if (n1 > n3 && n3 > n2)
                {
                    Console.WriteLine(n1 + " " + n3 + " " + n2);
                }
                else if (n2 > n1 && n1 > n3)
                {
                    Console.WriteLine(n2 + " " + n1 + " " + n3);
                }
                else if (n2 > n3 && n3 > n1)
                {
                    Console.WriteLine(n2 + " " + n3 + " " + n1);
                }
                else if (n3 > n1 && n3 > n2)
                {
                    Console.WriteLine(n3 + " " + n1 + " " + n2);
                }
                else
                {
                    Console.WriteLine(n3 + " " + n2 + " " + n1);
                }
            }
            static void questao04()
            {
                //4 Escreva um programa que leia dois números e apresente 
                //a diferença do maior para o menor
                Console.WriteLine("Digite o 1o numero: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o 2o numero: ");
                int n2 = int.Parse(Console.ReadLine());


                if (n1 > n2)
                {
                    int diferenca = n1 - n2;
                    Console.WriteLine("Diferença- n1>n2: " + diferenca);
                }

                else
                {
                    int diferenca = n2 - n1;
                    Console.WriteLine("Diferença- n2>n1: " + diferenca);
                }
            }
            static void questao05()
            {
                //5 Escreva um programa que leia quatro notas escolares de um aluno e 
                //apresentar uma mensagem que o aluno foi aprovado se o valor da média 
                //escolar for maior ou igual a 7.Se o valor da média for menor que 7, 
                //solicitar a nota da recuperação, somar com o valor da média e obter 
                //a nova média.Se a nova média for maior ou igual a 7, apresentar uma 
                //mensagem informando que o aluno foi aprovado na recuperação.Se o aluno 
                //não foi aprovado, apresentar uma mensagem informando esta condição. 
                //Apresentar junto com as mensagens o valor da média do aluno.

                Console.WriteLine("Informe a 1a nota: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a 2a nota: ");
                double n2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a 3a nota: ");
                double n3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a 4a nota: ");
                double n4 = double.Parse(Console.ReadLine());

                double media = (n1 + n2 + n3 + n4) / 4;

                if (media >= 7)
                {
                    Console.WriteLine("Aluno aprovado com média " + media);
                }
                else
                {
                    Console.WriteLine("Informe a nota da recuperação: ");
                    double nR = int.Parse(Console.ReadLine());
                    double novaMedia = (nR + media) / 2;
                    if (novaMedia >= 7)
                    {

                        Console.WriteLine("Aluno aprovado na recuperação com nota " + nR + " ficando sua média em " + novaMedia);
                    }
                    else
                    {
                        Console.WriteLine("Aluno tirou " + nR + " e sua media ficou em " + novaMedia + " logo, não foi aprovado");
                    }
                }
            }
            static void questao06()
            {
                //6 Escreva um programa que leia dois números e exiba mensagem informando 
                //o valor do maior número e o valor do menor número. Se os dois números 
                //forem iguais, o programa deve exibir mensagem informando este fato.
                Console.WriteLine("Informe o 1o numero: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o 2o numero: ");
                int n2 = int.Parse(Console.ReadLine());
                if (n1 > n2)
                {
                    Console.WriteLine("O maior numero é " + n1 + " e o menor numero é " + n2);
                }
                else if (n2 > n1)
                {
                    Console.WriteLine("O maior numero é " + n2 + " e o menor numero é " + n1);
                }
                else
                {
                    Console.WriteLine("Os números são iguais: " + n1 + " e " + n2);
                }
            }
            static void questao07()
            {
                //7 Escreva um programa que leia um número inteiro. Verificar por meio de 
                //condição se o valor fornecido está na faixa entre 0(zero) e 9(nove).
                //Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem 
                //“valor válido”. Caso contrário, apresentar a mensagem “valor inválido”.

                Console.WriteLine("Informe o número: ");
                int num = int.Parse(Console.ReadLine());

                if (num >= 0 && num <= 9)
                {
                    Console.WriteLine("Valor válido!");
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            static void questao08()
            {
                //Escreva um programa que leia um número inteiro(variável CODIGO). Verificar se
                //o código é igual a 1, igual a 2 ou igual a 3.Caso não seja, apresentar a mensagem
                //“Código inválido”. Ao ser verificado o código e constatado que é um valor válido,
                //o programa deve verificar cada código em separado para determinar seu valor por 
                //extenso, ou seja, apresentar a mensagem “um”,” dois” ou “três”. (Utilizar o comando
                //Switch).

                Console.WriteLine("Informe um número: ");
                int num = int.Parse(Console.ReadLine());

                if (num == 1 || num == 2 || num == 3)
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Um");
                            break;
                        case 2:
                            Console.WriteLine("Dois");
                            break;
                        case 3:
                            Console.WriteLine("Três");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Código inválido!");
                }
            }
            static void questao09()
            {
                //9 -Escreva um programa que leia três valores para os lados de um triângulo 
                //(variáveis A, B e C).Verificar se cada lado é menor que a soma dos outros 
                //dois lados. Se sim, saber de A== B e se B == C, sendo verdade o triângulo 
                //é equilátero; se não, verificar de A== B ou se A == C ou se B == C, sendo 
                //verdade o triângulo é isóscele; e caso contrário, o triângulo será escaleno. 
                //Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.
                Console.WriteLine("Informe A: ");
                int A = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe B: ");
                int B = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe C: ");
                int C = int.Parse(Console.ReadLine());
                int soma = A + B + C;
                //if (A < soma )
                if (A == B && B == C)
                {
                    Console.WriteLine("É um triangulo equilátero");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("É um triangulo isóscele");
                }
                else
                {
                    Console.WriteLine("É um triangulo escaleno");
                }
            }
            static void questao10()
            {
                //Escrever um programa declarando três variáveis do tipo inteiro(a, b e c).//
                //Ler um valor maior que zero para cada variável(se o valor digitado não é 
                //válido, mostrar mensagem e ler novamente). Exibe o menor valor lido multiplicado 
                //pelo maior e o maior valor dividido pelo menor.
                Console.WriteLine("Informe a: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe c: ");
                double c = double.Parse(Console.ReadLine());
                if (a > 0 && b > 0 && c > 0)
                {

                    if (a > b && a > c && b > c)
                    {
                        Console.WriteLine("Resultado, menor x maior: " + (c * a) + " e maior / menor: " + a / c);
                    }
                    else if (b > a && b > c && c > a)
                    {
                        Console.WriteLine("Resultado, menor x maior: " + (a * b) + " e maior / menor: " + b / a);
                    }
                    else if (c > a && c > b && a > b)
                    {
                        Console.WriteLine("Resultado, menor x maior: " + (b * c) + " e maior / menor: " + c / b);
                    }
                    else if (a > b && a > c && c > b)
                    {
                        Console.WriteLine("Resultado, menor x maior: " + (b * a) + " e maior / menor: " + a / b);
                    }
                    else if (b > a && b > c && a > c)
                    {
                        Console.WriteLine("Resultado, menor x maior: " + (c * b) + " e maior / menor: " + b / c);
                    }
                    else
                    {
                        Console.WriteLine("Resultado, menor x maior: " + (a * c) + " e maior / menor: " + c / a);
                    }
                }
                else
                {
                    Console.WriteLine("Um dos valores é inválido. Reinicie");
                }
            }
            static void questao11()
            {
                //11 - Faça um programa que leia um número inteiro e mostre uma mensagem na tela 
                //indicando se este número é positivo ou negativo. Pare a execução do programa 
                //quando o usuário requisitar.

                Console.WriteLine("Informe o número: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("Número positivo");
                }
                else
                {
                    Console.WriteLine("Número negativo");
                }
            }
            static void questao12()
            {
                //12 Faça um programa que leia um número.Se positivo armazene - o em A, 
                //se for negativo, em B.No final  mostrar o resultado.
                Console.WriteLine("Informe o numero: ");
                int num = int.Parse(Console.ReadLine());
                int A = 0;
                int B = 0;

                if (num > 0)
                {
                    B = num;
                }
                else
                {
                    A = num;
                }
                Console.WriteLine("Número negativo, armazenado em A: " + A);
                Console.WriteLine("Número positivo, armazenado em B: " + B);
            }
            static void questaoSwitch01()
            {
                //01/03 Escreva um programa que exiba as seguintes opções e realize os que se pede 
                //em cada uma delas: 1 – Adição
                // 2 – Subtração
                // 3 – Multiplicação
                // 4 – Divisão


                Console.WriteLine("Informe um número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe outro número: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Escolha uma operação: ");
                double resultado = double.Parse(Console.ReadLine());

                switch (resultado)
                {
                    case 1:
                        Console.WriteLine("Adição: " + (n1 + n2));
                        break;
                    case 2:
                        Console.WriteLine("Subtração: " + (n1 - n2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplicação: " + (n1 * n2));
                        break;
                    case 4:
                        Console.WriteLine("Divisão: " + (n1 / n2));
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }
        }
        static void questaoSwitch02()
        {
            //02/03 um programa que leia dois números inteiros e apresente as opções 
            //para usuário escolher o que deseja realizar:
            //1 – Verificar se um dos números lidos é ou não múltiplo do outro
            //2 – Verificar se os dois números lidos são pares
            //3 – Verificar se a média dos dois números é maior ou igual a 7.
            //4 – Sair

            Console.WriteLine("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora escolha as opções a seguir: ");
            Console.WriteLine("1 – Verificar se um dos números lidos é ou não múltiplo do outro");
            Console.WriteLine("2 – Verificar se os dois números lidos são pares: ");
            Console.WriteLine("3 – Verificar se a média dos dois números é maior ou igual a 7: ");
            Console.WriteLine("4 – Sair ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (n1 % n2 == 0) //AGUARDAR CORREÇÃO
                    {
                        Console.WriteLine("O primeiro é multiplo do segundo");
                    }
                    else
                    {
                        Console.WriteLine("O segundo é multiplo do primeiro");
                    }
                    break;
                case 2:
                    if (n1 % 2 == 0 && n2 % 2 == 0)
                    {
                        Console.WriteLine("Os dois números são pares");
                    }
                    else
                    {
                        Console.WriteLine("Os dois não são pares!");
                    }
                    break;
                case 3:
                    {
                        if ((n1 + n2 / 2) >= 7)
                        {
                            Console.WriteLine("Média dos dois é maior ou igual a 7");
                        }
                        else
                        {
                            Console.WriteLine("Média dos dois não é maior ou igual a 7");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Reinicie");
                    break;
            }

        }
        static void questaoSwitch03()
        {
            //03/03 Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa 
            //que calcule seu peso ideal, utilizando as seguintes fórmulas: (h = altura)
            //- Para homens: (72.7 * h) - 58
            //- Para mulheres: (62.1 * h) - 44.7

            Console.WriteLine("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o sexo (M/F): ");
            string sexo = Console.ReadLine();

            switch (sexo)
            {
                case ("M"):
                    {
                        Console.WriteLine("Peso ideal do homem: " + ((72.7 * altura) - 58) + "kg");
                    }
                    break;
                case ("F"):
                    {
                        Console.WriteLine("Peso ideal da mulher: " + ((62.1 * altura) - 48) + "kg");
                    }
                    break;
                default:
                    Console.WriteLine("Opção válida. Reinicie.");
                    break;
            }
        }
    }
    }

