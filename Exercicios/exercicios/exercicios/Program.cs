using System;
using System.Drawing;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
            /*double a = 5;
            double b = 8;
            double media = (a + b) / 2;
            Console.WriteLine("A média é:" + media);*/

            // 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            //double a = 5;
            //double b = 8;
            //double c = 10;
            //double d = 20;
            //double media = (a + b + c + d) / 4;
            //Console.WriteLine("A média é:" + media); 

            // 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.

            //int a = 10;
            //int b = 20;
            //int temporaria = a;
            //a = b;
            //b = temporaria;
            //Console.WriteLine("A:" + a + " B:" + b);

            //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            //int dia = 29;
            //int mes = 09;
            //String ano1 = "19";
            //String ano2 = "98";
            //Console.WriteLine(ano1 + ano2 + "/" + mes + "/" + dia);
            //Console.WriteLine(ano2 + "/" + mes + "/" + dia);

            //5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            //(medido em Km/ l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            //consumido para percorrê-la(medido em l).

            //double distancia;
            //distancia = double.Parse(Console.ReadLine());
            //double combustivel;
            //combustivel = double.Parse(Console.ReadLine());
            //double combustivelMedia = combustivel / distancia;
            //Console.WriteLine(combustivelMedia);

            //6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
            //de IPI(única) a ser acrescentada.

            //int codigo1, qtdPecas1, vlrUnd1, ipi1;
            //int codigo2, qtdPecas2, vlrUnd2, ipi2;

            //codigo1 = int.Parse(Console.ReadLine());
            //qtdPecas1 = int.Parse(Console.ReadLine());
            //ipi1 = int.Parse(Console.ReadLine());
            //vlrUnd1 = int.Parse(Console.ReadLine());
            //codigo2 = int.Parse(Console.ReadLine());
            //qtdPecas2 = int.Parse(Console.ReadLine());
            //vlrUnd2 = int.Parse(Console.ReadLine());
            //ipi2 = int.Parse(Console.ReadLine());

            //Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            //Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.

            //int vendedor;
            //double salario, comissao, vendas, salarioTotal;

            //vendedor = int.Parse(Console.ReadLine());
            //vendas = double.Parse(Console.ReadLine());
            //comissao = double.Parse(Console.ReadLine());
            //salario = double.Parse(Console.ReadLine());

            //salarioTotal = ((vendas / 100) * comissao) + salario;
            //Console.WriteLine("Vendedor: " + vendedor + " Salário Total:" + salarioTotal);


            //8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            //A fórmula da conversão é F = (9 * C + 160) / 5.

            //double celsius;
            //celsius = double.Parse(Console.ReadLine());
            //double fahrenheit = (9 * celsius + 160) / 5;
            //Console.WriteLine("Temperatura em Fahrenheit é:" + fahrenheit);


            //9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior
            //do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
            //Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00;
            //se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
            //Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            //da entrada e das duas prestações, de acordo com as regras acima.
            //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
            //conseqüente pagamento dos boletos das duas prestações.

            //double valorProduto;
            //double entrada, pretacao2, pretacao3;

            //valorProduto = double.Parse(Console.ReadLine());

            //if (valorProduto % 3 == 0)
            //{
            //    entrada = (valorProduto / 3);
            //    pretacao2 = (valorProduto / 3);
            //    pretacao3 = (valorProduto / 3);

            //}
            //else {
            //    entrada = (valorProduto / 3 + 1);
            //    pretacao2 = (valorProduto - entrada) / 2;
            //    pretacao3 =  pretacao2;
            //}

            //Console.WriteLine("Entrada: " + entrada + " Prestação 2: " + pretacao2 + " Prestação 3: " + pretacao3);

            //10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo
            //    para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
            //    realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as
            //    notas de menor valor fossem distribuídas em número mínimo possível.
            //    Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            //    uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
            //    Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas
            //    de acordo com o critério da “distribuição ótima”.

            int valorSolicitado,notas;
            

            valorSolicitado = int.Parse(Console.ReadLine());

            int n100 = valorSolicitado / 100;
            int r100 = valorSolicitado % 100;

            int n50 = r100 / 50;
            int r50 = r100 % 50;

            int n20 =  r50 / 20;
            int r20 =  r50  % 20;

            int n10 = r20 / 10;
            int r10 = r20 % 10;

            int n5 = r10 / 5;
            int r5 = r10 % 5;

            int n2 = r5 / 2;
            int r2 = r5 % 2;

            int n1 = r2;

            if(n100 != 0){
                Console.WriteLine( "Nota de R$100: " + n100);

            }
            if (n50 != 0)
            {
                Console.WriteLine("Nota de R$50: " + n50);  

            }
            if (n20 != 0)
            {
                Console.WriteLine("Nota de R$20: " + n20);

            }
            if (n10 != 0)
            {
                Console.WriteLine("Nota de R$10: " + n10);

            }
            if (n5 != 0)
            {
                Console.WriteLine("Nota de R$5: " + n5);

            }
            if (n2 != 0)
            {
                Console.WriteLine("Nota de R$2: " + n2);

            }
            if (n1 != 0)
            {
                Console.WriteLine("Nota de R$1: " + n1);

            }




        }






            // exercio do triangulo

            //int a, b, c;
            //String tipoTriangulo;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());

            //if((a < b+c) && (b < a+c) && (c < b + a)) {
            //    if (a == b && b == c) {
            //        tipoTriangulo = "Equilátero";
            //    }
            //    else if (a==b || b==c || a==c) {
            //        tipoTriangulo = "Isósceles";

            //    } 
            //    else
            //    {
            //        tipoTriangulo = "Escaleno";
            //    }
            //    Console.WriteLine(tipoTriangulo);
            //}















        }
    }
