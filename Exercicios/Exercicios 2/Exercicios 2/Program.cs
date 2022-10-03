using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random randNum = new Random();

            //1 - Faça um programa para Calcular e Mostrar a Área de Um Triângulo a Partir dos Valores da Base e da  altura a partir do  Teclado:
            //    Área do triângulo = (base * altura) / 2;
            //    Teste se a base ou a altura digitada não foi igual a zero.

            //int altura, baseTriangulo, area;

            //Console.WriteLine("Qual é a altura do triângulo: ");
            //altura = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual é a base: ");
            //baseTriangulo = int.Parse(Console.ReadLine());

            //if (altura != 0 && baseTriangulo != 0) { 
            //    area = (baseTriangulo * altura) / 2;
            //    Console.WriteLine(" A área do triângulo é: " + area);
            //} 

            // 2 - Faça um programa para ler um número e se ele é par ou ímpar.

            //int numero;

            //Console.WriteLine("Digite o numero? ");
            //numero = int.Parse(Console.ReadLine());
            //Console.WriteLine("É par ou impar? ");

            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine(numero + " é par");
            //} else {
            //    Console.WriteLine(numero + " é impar");
            // }

            // 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            // Mostrar na tela qual dos professores tem o maior salário total.

            //int horas1, horas2;
            //double valorHora, salarioTotal1, salarioTotal2;

            //Console.WriteLine("Digite a quantidade de horas do professor 1: ");
            //horas1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de horas do professor 2: ");
            //horas2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor hora:");
            //valorHora = double.Parse(Console.ReadLine());

            //salarioTotal1 = horas1 * valorHora;
            //salarioTotal2 = horas2 * valorHora;

            //if (salarioTotal1 > salarioTotal2)
            //{
            //    Console.WriteLine("Professor um recebeu o maior salário! No valor de R$" + salarioTotal1);
            //}
            //else
            //{
            //    Console.WriteLine("Professor dois recebeu o maior salário! No valor de R$" + salarioTotal2);
            //}

            //5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            //    se a média das duas notas for maior ou igual a 7, 0.
            //Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            //é a média entre a nota do exame e a média das 2 notas.
            //Se esta média final for maior ou igual a 5, 0, o programa deve escrever “Aprovado”, caso contrário deve
            //escrever “Reprovado”.

            //int nota1, nota2, media, mediaFinal, exame;

            //Console.WriteLine("Escreva a nota 1");
            //nota1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva a nota 2");
            //nota2 = int.Parse(Console.ReadLine());

            //media = (nota1 + nota2) / 2;

            //if (media >= 7)
            //{
            //    Console.WriteLine("Aprovado");
            //}
            //else
            //{
            //    Console.WriteLine("Nota do exame:");
            //    exame = int.Parse(Console.ReadLine());
            //    mediaFinal= (media + exame) / 2;

            //    if (mediaFinal >=5)
            //    {
            //        Console.WriteLine("Aprovado");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Reprovado");
            //    }
            //}


            //6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
            //    O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
            //    O cálculo do imc = peso / (altura * altura)

            //    IMC
            //    menor que 18->baixo peso
            //    maior que 18 e menor que 25->peso normal
            //    maior que 25 e menor que 30->sobrepeso
            //    maior que 30 e menor que 35->obesidade
            //    maior que 35->obesidade grau sério

            //String nome;
            //float altura, peso, imc;

            //Console.WriteLine("Digite o seu nome:");
            //nome = Console.ReadLine();  
            //Console.WriteLine("Digite a sua altura:");
            //altura = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o seu peso:");
            //peso = float.Parse(Console.ReadLine());

            //imc =  peso / (altura * altura);


            //if (imc <= 18)
            //{
            //    Console.WriteLine( imc + ", você está abaixo do peso" );
            //}
            //else if (imc > 18 && imc <= 25)
            //{
            //    Console.WriteLine(nome +  ", seu peso está normal");
            //}
            //else if (imc > 25 && imc <= 30)
            //{
            //    Console.WriteLine(nome + ", você está com sobrepeso");
            //}
            //else if (imc > 30 && imc <= 35)
            //{
            //    Console.WriteLine(nome + ", Obesidade grau sério");
            //}
            //else
            //{
            //    Console.WriteLine(nome + ", ");
            //}


            //7 - Faça um programa em C# e no VS para uma frase qualquer e uma palavra de pesquisa.
            //    O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            //    exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.

            //String frase, palavra;

            //Console.WriteLine("Escreva a frase");
            //frase = Console.ReadLine();
            //Console.WriteLine("Escreva a palavra");
            //palavra = Console.ReadLine();

            //if (frase.Contains(palavra))
            //{
            //    Console.WriteLine("A palavra está na frase");
            //}
            //else
            //{
            //    Console.WriteLine("A palavra não está na frase");

            //}

            //8 - Faça um programa no VS que inclua o código, nome, salário base e o total de vendas de um funcionário.
            //    Caso o total de vendas seja acima de R$ 500,00, adicione ao seu salário final 5 % do total de vendas.
            //    Caso o total de vendas seja mais que R$ 1000,00, adicione ao seu salário final 7 % do total de vendas.
            //    por fim, se o total de vendas seja maior que R$ 5000,00, adicione ao seu salário E final 10 % do
            //                    total de vendas.

            //int codigo;
            //String nome;
            //Double salarioBase, salarioFinal = 0, totalDeVendas;

            //Console.WriteLine("Nome do funcionário:");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite o código:");  
            //codigo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o salário base");
            //salarioBase = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o total de vendas");
            //totalDeVendas = double.Parse(Console.ReadLine());

            //if (totalDeVendas >500 && totalDeVendas <= 1000)
            //{
            //    salarioFinal = salarioBase + (totalDeVendas * 0.05);
            //}
            //else if (totalDeVendas > 1000 && totalDeVendas <= 5000)
            //{
            //    salarioFinal = salarioBase + (totalDeVendas * 0.07);


            //}
            //else if (totalDeVendas > 5000)
            //{
            //    salarioFinal = salarioBase + (totalDeVendas * 0.10);


            //}
            //else
            //{
            //    salarioFinal = salarioBase;
            //}

            //Console.WriteLine("Salario final do vendedor " + codigo + " é R$" + salarioFinal);

            //9 - Faça um programa no VS que incluirá no usuário 3 valores de glicemia em reflexo, representando uma representação de glicemia
            //    diária de um paciente diabético. Para cada valor recebido analisado e informar ao paciente o seguinte:
            //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            ////Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.
            //Além disso, o programa deve fazer a média dos 3 valores de glicemia avaliados. E se a média para
            //menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média para maior que
            //150, avisá - lo que será necessário adicionar 2 unidades de insulina.

            //int glicemia1, glicemia2, glicemia3, media;


            //Console.WriteLine("Digite o valor do primeiro teste");
            //glicemia1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do segundo teste");
            //glicemia2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do terceiro teste");
            //glicemia3 = int.Parse(Console.ReadLine());


            //media = (glicemia1 + glicemia2 + glicemia3) / 3;


            //if (glicemia1 < 65 || glicemia2 <65 || glicemia3 <65)
            //{
            //    Console.WriteLine("Corre risco de hipoglicemia");
            //}
            // if (glicemia1 > 250 || glicemia2 > 250 || glicemia3 >250)
            //{
            //    Console.WriteLine(" Corre risco de hiperglicemia");
            //}

            //if (media <80)
            //{
            //    Console.WriteLine(" Sua média é: " + media + ", dimunua 2 unidades de insulina");
            //}
            //else if (media > 150)
            //{
            //    Console.WriteLine(" Sua média é: " +media+  ", aumente 2 unidades de insulina");
            //}


            //10 - Faça um programa no VS que recebeu dados de duas atletas (nome, idade e altura).
            //O programa deve mostrar os dados do atleta mais novo e mais alto.

            //String nome1, nome2;
            //int idade1, idade2;
            //double altura1, altura2;

            //Console.WriteLine("Nome do atleta 1:");
            //nome1 = Console.ReadLine();
            //Console.WriteLine("Idade");
            //idade1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Altura");
            //altura1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Nome do atleta 2:");
            //nome2 = Console.ReadLine();
            //Console.WriteLine("Idade");
            //idade2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Altura");
            //altura2 = double.Parse(Console.ReadLine());

            //if (idade1 < idade2 && altura1 > altura2)
            //{
            //    Console.WriteLine("O(a) atleta " + nome1 + " Tem " + idade1 + " anos. e " + altura1 + " de altura ");
            //}
            //else if (idade2 < idade1 && altura2 > altura1)
            //{
            //    Console.WriteLine("O(a) atleta " + nome2 + " Tem " + idade2 + " anos. e " + altura2 + " de altura ");
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum dos atletas é mais novo e mais alto ao mesmo tempo!");
            //}

            //11 - Faça um programa VS que recebe uma hora, uma hora e outra variável em 2 minutos.
            //    O programa deve exibir se a hora digitada está ou não é válido.
            //    Lembre - se de usar o padrão de hora com 24h, de 0 a 23.

            //int hora, minuto;

            //Console.WriteLine("Digite a hora");
            //hora = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite os minutos");
            //minuto = int.Parse(Console.ReadLine());

            //if ((hora > 0 && hora < 24) && (minuto >= 0 && minuto <= 59))
            //{
            //    Console.WriteLine("Hora valida");
            //}
            //else
            //{
            //    Console.WriteLine("Hora invalida");
            //}

            //12 - Elabore um programa em VS que leia as variáveis ​​"codigo" e "numeroHoras", respectivamente, código e
            //        número de horas trabalhadas de um operador.Na sequência, calcule o conhecimento-se que ele ganha
            //        R$ 10,00 por hora. Quando o número de horas exceder a 50 cálcule ou excesso de pagamento
            //        armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
            //        final do processamento, exibir o salário total e o salário do operador.

            //int codigo, numeroHoras, excedente;
            //double extra, salarioTotal, salarioOperador;

            //Console.WriteLine("Digite o código");
            //codigo =int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o número de horas trabalhadas");
            //numeroHoras = int.Parse(Console.ReadLine());

            //if (numeroHoras > 50)
            //{
            //    excedente = numeroHoras - 50;
            //    extra = excedente  * 20;
            //    salarioOperador = 50 * 10;
            //    salarioTotal = extra + salarioOperador;
            //    Console.WriteLine("O salário total é: R$" + salarioTotal + " e o salário do operador é: R$" + salarioOperador);
            //}
            //else
            //{
            //    salarioOperador = numeroHoras * 10;
            //    Console.WriteLine("O salário do operador é: R$" + salarioOperador);
            //}

            //13 - Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule
            //    seu peso ideal, usando as seguintes fórmulas:
            //    Para homens: (72, 7 * h) - 58
            //    Para mulheres: (62, 1 * h) - 44,7

            //int  genero;
            //double pesoIdeal, altura;

            //Console.WriteLine("Digite 1 se for Homem ou 2 se for mulher:");
            //genero = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a sua altura:");
            //altura = double.Parse(Console.ReadLine());

            //if (genero == 1 )
            //{
            //    pesoIdeal = 52 + (0.75 * (altura - 152.4));
            //}
            //else
            //{
            //    pesoIdeal = 52 + (0.67 * (altura - 152.4));
            //}
            //Console.WriteLine("O seu peso ideal é: " + pesoIdeal);


            //14 - Faça um programa que peça o tamanho de um arquivo para download(em MB) ea velocidade de um
            //    link de Internet(em Mbps).Em seguida, calcule e informe o tempo aproximado de download
            //    do arquivo usando este link(em minutos).

            //double mb, internet, tempo;

            //Console.WriteLine("Digete o tamanho do arquivo:");
            //mb = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digete a velocida da sua internet:");
            //internet = double.Parse(Console.ReadLine());

            //tempo = (mb / internet)/60;

            //Console.WriteLine("A velecidade do download é de:" + tempo);

            //15 - Faça um programa para uma loja de tintas.O programa deve pedir o tamanho em metros quadrados
            //    da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
            //    e que a tinta é vendida em latas de 18 litros, que custa R$ 80,00.
            //    Informe ao usuário a quantidade de latas de tinta compradas e o preço total

            //double metrosQuadrados, qtdLata, preço;

            //Console.WriteLine("Digite o metro quadrado:");
            //metrosQuadrados = double.Parse(Console.ReadLine());

            //qtdLata = metrosQuadrados / (18 * 3);
            //preço = qtdLata *80;

            //Console.WriteLine("Será usado " + qtdLata + " latas. E o valor gasto sera: R$" + preço);

            //16 - Escreva um jogo que leia o placar de um primeiro jogo da copa do Brasil.Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            //    na tela uma mensagem indicando que o time de fora já se classificou para próxima fase.Caso contrário, mostre uma mensagem indicando que os dois times vão se ver
            //    enfrentar novamente em um novo jogo.
            //    ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            //    ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            //    plus: caso ocorra um segundo jogo, leia e diga quem passou de novo jogo.


            //int timeCasa, timeFora;

            //Console.WriteLine("Digite o placar do time casa");
            //timeCasa = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o placar do time fora");
            //timeFora = int.Parse(Console.ReadLine());

            //if (timeFora >= timeCasa + 2)
            //{
            //    Console.WriteLine("O time de fora já se classificou");
            //}
            //else if (timeCasa >= timeFora)
            //{
            //    Console.WriteLine("Teremos um novo jogo");

            //    Console.WriteLine("Digite o placar do time casa");
            //    timeCasa = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o placar do time fora");
            //    timeFora = int.Parse(Console.ReadLine());

            //    if (timeFora > timeCasa)
            //    {
            //        Console.WriteLine("O time de fora ganhou");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("O time da casa ganhou");

            //    }
            //}


            //17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            //    formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos
            //    os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

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

            //18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            //int valor1, valor2, valor3, maior;
            //Console.WriteLine("Digite o primeiro valor:");
            //valor1 = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Digite o segundo valor:");
            //valor2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro valor:");
            //valor3 = int.Parse(Console.ReadLine());   


            //  if (valor1 > valor2 && valor1 > valor3)
            //  {
            //      maior = valor1;
            //  } 
            //  else if (valor2 > valor1 && valor2 > valor3)
            //  {
            //      maior = valor2;
            //  }
            //  else
            //  {
            //      maior = valor3;
            //  }

            //  Console.WriteLine("O numero maior é: " + maior);

            // 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.



            //20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            //plus: você pode gerar o número de forma randomica(função random c#).

            //int numeroSecreto = randNum.Next();

            //Console.WriteLine("Adivinhe qual é o numero secreto: ");
            //int num = int.Parse(Console.ReadLine());
            //if (numeroSecreto > num)
            //{
            //    Console.WriteLine("Maior");
            //}
            //else if (numeroSecreto < num)
            //{
            //    Console.WriteLine("Menor");
            //}
            //else
            //{
            //    Console.WriteLine("Certo");
            //}




        }
    }
}