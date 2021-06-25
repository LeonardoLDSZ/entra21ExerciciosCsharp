using System;

namespace entra21ExerciciosCsharp
{
    class exerciciosLista08
    {
        static void Main(string[] args)
        {
            questao01();
            //questao02();
            //questao03();
            //questao04();
            //questao05();

            static void questao01()
            {

                //Faça um programa para calcular o estoque médio de uma peça, sendo que:
                //ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.
                Console.WriteLine("Informe a quantidade mínima: ");
                int qtdMin = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a quantidade máxima: ");
                int qtdMax = int.Parse(Console.ReadLine());
                int qtdMedio = (qtdMin + qtdMax) / 2;
                Console.WriteLine("O estoque médio é de: " + qtdMedio);
                // ALTERNATIVA
                //Console.WriteLine($"O estoque médio é " + $"{(qtdMax + qtdMin) /2}");
            }
            static void questao02()
            {
                //Faça um programa que:
                //Leia a cotação do dólar
                //Leia um valor em dólares
                //Converta esse valor para Real
                //Mostre o resultado
                double cotacaoDolar = 5.04;
                Console.WriteLine("Informe o valor em dolar: ");
                double valorDolar = double.Parse(Console.ReadLine());
                double convertToReal = cotacaoDolar * valorDolar;
                Console.WriteLine("O valor em real é de: R$ " + convertToReal);
            }
            static void questao03()
            {
                //Faça um programa para pagamento de comissão de vendedores de peças, 
                //levando - se em consideração que sua comissão será de 5 % do total da 
                //venda e que você tem os seguintes dados:
                //-
                //Identificação do vendedor
                //-
                //Código da peça
                //-
                //Preço unitário da peça
                //-
                //Quantidade vendida
                double comissao = 0.05;
                Console.WriteLine("Identique o vendedor: ");
                string vendedor = Console.ReadLine();
                Console.WriteLine("Informe o código da peça: ");
                double codigoPeca = double.Parse(Console.ReadLine());
                Console.WriteLine("Preço unitário da peça: ");
                double precoUnitario = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade vendida: ");
                double qtdVendida = double.Parse(Console.ReadLine());
                double pgtoComissao = (precoUnitario * qtdVendida) * comissao;
                Console.WriteLine("O valor da comissão foi de: R$ " + pgtoComissao);
                //ALTERNATIVA
                //Console.WriteLine($"O valor da comissão foi de R$ " + $"{(precoUnitario * qtdVendida) * comissao}");
            }
            static void questao04()
            {
                //Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois 
                //da adição e multiplicação entre os valores lidos, baseando-se na utilização 
                //do conceito de propriedade distributiva.Dica: se forem lidas as variáveis A, 
                //B, C e D, devem ser somados e multiplicados os valores de A com B, A com              C e A com D; depois B com C, B com D e por último C com D. Note que para cada operação serão
                //utilizadas seis combinações.Assim sendo, devem ser realizadas doze operações 
                //de processamento, sendo seis para as adições e seis para as multiplicações.
                Console.WriteLine("Informe o valor de A: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor de B: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor de C: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor de D: ");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine($"A+B= {a + b} " +
                $" A+C= {a + c}" +
                $" A+D= {a + d}" +
                $" B+C= {b + c}" +
                $" B+D= {b + d}" +
                $" C+D= {c + d}");
                Console.WriteLine($"A*B= {a * b} " +
                    $" A*C= {a * c}" +
                    $" A*D= {a * d}" +
                    $" B*C= {b * c}" +
                    $" B*D= {b * d}" +
                    $" C*D= {c * d}");
            }
            static void questao05()
            {
                //Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, 
                //utilizando um automóvel que faz 12 Km por litro.Para obter o cálculo, o usuário 
                //deve fornecer o tempo gasto na viagem e a velocidade média. Desta forma, será 
                //possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
                //Tendo o valor da distância, basta calcular a quantidade de litros de combustível 
                //utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12.O programa
                //deve apresentar os valores da velocidade média, tempo gasto, a distância percorrida 
                //e a quantidade de litros utilizada na viagem.Dica: trabalhe com valores reais.
                Console.WriteLine("Informe o tempo gasto: ");
                double tempoGasto = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a velocidade média: ");
                double velocidade = double.Parse(Console.ReadLine());
                double distancia = tempoGasto * velocidade;
                double litrosUsados = distancia / 12.0;
                Console.WriteLine("Distância percorrida foi de " + distancia + "km");
                Console.WriteLine("Tempo gasto foi de " + tempoGasto);
                Console.WriteLine("Velocidade média foi de " + velocidade + " km/h");
                Console.WriteLine("Litros usados " + litrosUsados + " litros");
                //Alternativa:
                //Console.WriteLine($"A velocidade média da viagem foi {velocidadeMedia}." +
                //$" A viagem durou {horas} horas." +
                //$" A distancia percorrida foi de {distancia} km" +
                //$" O consumo foi de {consumo} litros de gasolina");
                static void questao06()
                {
                    //Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit.
                    //A fórmula de conversão de temperatura a ser utilizada é F = (9 * C + 160) / 5, em 
                    //que a variável F representa é a temperatura em graus Fahrenheit e a variável C 
                    //representa é a temperatura em graus Celsius.
                    Console.WriteLine("Informe a temperatura em Celsius: ");
                    double tempCelsius = double.Parse(Console.ReadLine());
                    double tempFahrenheit = (9 * tempCelsius + 160) / 5;
                    Console.WriteLine("A temperatura em Kelvin é de: " + tempFahrenheit);
                }

                static void questao07()
                {
                    //Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius.
                    //A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5 / 9, em 
                    //que a variável F é a temperatura em graus Fahrenheit e a variável C é a temperatura 
                    //em graus Celsius.
                    Console.WriteLine("Informe a temperatura em Fahrenheit: ");
                    double tempFahrenheit = double.Parse(Console.ReadLine());
                    double tempCelsius = (tempFahrenheit - 32) * 5 / 9;
                    Console.WriteLine("A temperatura em Celsius é de: " + tempCelsius);
                }
                static void questao08()
                {
                    //Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a 
                    //fórmula: V = 3.14159 * R * R * A Onde as variáveis: V, R e A representam
                    //respectivamente o volume, o raio e a altura.    
                    Console.WriteLine("Informe o raio: ");
                    double R = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o altura: ");
                    double A = double.Parse(Console.ReadLine());
                    double valorVolLata = 3.14159 * R * R * A;
                    Console.WriteLine("O valor do volume da lata de óleo é: " + valorVolLata);
                }
                static void questao09()
                {
                    //Faça um algoritmo que leia a idade de uma pessoa expressa em anos,
                    //meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
                    //Considerar ano com 365 dias e mês com 30 dias.
                    Console.WriteLine("Informe a idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe em meses: ");
                    int meses = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe em dias: ");
                    int dias = int.Parse(Console.ReadLine());
                    double idadeDias = (idade * 365) + (meses * 30) + dias;
                    Console.WriteLine("Sua idade em dias é de: " + idadeDias + " dias");
                }
                static void questao10()
                {
                    //Escrever um programa que leia dois números inteiros e mostre todos os
                    //relacionamentos de ordem existentes entre eles.Os relacionamentos
                    //possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor
                    //ou igual. Njjjjjjjjjjjjjjjjjjjjjjj
                    int A, B;
                    Console.WriteLine("Informe A: ");
                    A = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe B: ");
                    B = int.Parse(Console.ReadLine());
                    if (A == B)
                    {
                        Console.WriteLine("A igual a B");
                    }
                    else if (A > B)
                    {
                        Console.WriteLine("A maior que B");
                        if (A >= B)

                        {
                            Console.WriteLine("A maior igual a B");
                        }
                    }
                    else if (A < B)
                    {
                        Console.WriteLine("A menor que B");
                        if (A <= B)
                        {
                            Console.WriteLine("A menor igual a B");
                        }
                    }
                    else if (A == B)
                    {
                        Console.WriteLine("A igual a B ");
                        if (A != B)
                        {
                            Console.WriteLine("A não igual a B ");
                        }
                    }
                }
            }
        }
    }
}
