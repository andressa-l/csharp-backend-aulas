// 1 - questão - solução 1

//using System.Globalization;

//CultureInfo CI = CultureInfo.InvariantCulture;

//double largura, altura, area, perimetro, diagonal;

//Console.WriteLine("Base do retangulo: ");
//largura = double.Parse(Console.ReadLine(), CI);
//Console.WriteLine("Altura do retangulo: ");
//altura = double.Parse(Console.ReadLine(), CI);
//area = largura * altura;
//perimetro = 2 * (largura + altura);
//diagonal = Math.Sqrt(Math.Pow(largura, 2.0) + Math.Pow(altura, 2.0));
//Console.WriteLine("Area = " + area.ToString("F4", CI));
//Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CI));
//Console.WriteLine("Diagonal = " + diagonal.ToString("F4"));

//solução 2

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê o comprimento do terreno
//         Console.Write("Digite o comprimento do terreno em metros: ");
//         double comprimento = double.Parse(Console.ReadLine());

//         // Lê a largura do terreno
//         Console.Write("Digite a largura do terreno em metros: ");
//         double largura = double.Parse(Console.ReadLine());

//         // Calcula a área do terreno usando a fórmula A = L * C
//         double area = largura * comprimento;

//         // Exibe a área do terreno no console
//         Console.WriteLine("A área do terreno é " + area + " metros quadrados.");
//     }
// }


// 2 - questão
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê o número de cavalos comprados para o haras
//         Console.Write("Digite o número de cavalos comprados para o haras: ");
//         int cavalos = int.Parse(Console.ReadLine());

//         // Calcula o número de ferraduras necessárias usando a fórmula F = 4 * C
//         int ferraduras = 4 * cavalos;

//         // Exibe o número de ferraduras no console
//         Console.WriteLine("São necessárias " + ferraduras + " ferraduras para equipar todos os cavalos.");
//     }
// }

// 3 - questão

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê o nome da pessoa
//         Console.Write("Digite o seu nome: ");
//         string nome = Console.ReadLine();

//         // Lê a idade da pessoa em anos completos
//         Console.Write("Digite a sua idade em anos completos: ");
//         int idade = int.Parse(Console.ReadLine());

//         // Calcula o número de dias de vida usando a fórmula D = 365 * I
//         int dias = 365 * idade;

//         // Exibe o número de dias de vida no console
//         Console.WriteLine(nome.ToUpper() + ", VOCÊ JÁ VIVEU " + dias + " DIAS.");
//     }
// }

// 4 - questão

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê o preço do litro da gasolina em reais
//         Console.Write("Digite o preço do litro da gasolina em reais: ");
//         double preco = double.Parse(Console.ReadLine());

//         // Lê o valor do pagamento em reais
//         Console.Write("Digite o valor do pagamento em reais: ");
//         double pagamento = double.Parse(Console.ReadLine());

//         // Calcula o número de litros de gasolina usando a fórmula L = X / P
//         double litros = pagamento / preco;

//         // Exibe o número de litros de gasolina no console
//         Console.WriteLine("Você conseguiu colocar " + litros + " litros de gasolina no tanque.");
//     }
// }

// 5 - questão

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê a quantidade de camisetas pequenas vendidas
//         Console.Write("Digite a quantidade de camisetas pequenas vendidas: ");
//         int pequenas = int.Parse(Console.ReadLine());

//         // Lê a quantidade de camisetas médias vendidas
//         Console.Write("Digite a quantidade de camisetas médias vendidas: ");
//         int medias = int.Parse(Console.ReadLine());

//         // Lê a quantidade de camisetas grandes vendidas
//         Console.Write("Digite a quantidade de camisetas grandes vendidas: ");
//         int grandes = int.Parse(Console.ReadLine());

//         // Calcula o valor arrecadado usando a fórmula V = 10 * P + 12 * M + 15 * G
//         int valor = 10 * pequenas + 12 * medias + 15 * grandes;

//         // Exibe o valor arrecadado no console
//         Console.WriteLine("O valor arrecadado com a venda das camisetas é " + valor + " reais.");
//     }
// }

// 6 - questão
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê o salário do funcionário em reais
//         Console.Write("Digite o salário do funcionário em reais: ");
//         double salario = double.Parse(Console.ReadLine());

//         // Calcula o salário com o aumento usando a fórmula A = S * 1.15
//         double aumento = salario * 1.15;

//         // Calcula o salário final usando a fórmula F = A * 0.92
//         double final = aumento * 0.92;

//         // Exibe o salário inicial, o salário com o aumento e o salário final no console
//         Console.WriteLine("O salário inicial do funcionário é " + salario + " reais.");
//         Console.WriteLine("O salário com o aumento de 15% é " + aumento + " reais.");
//         Console.WriteLine("O salário final com o desconto de 8% de impostos é " + final + " reais.");
//     }
// }

// 7 - questão
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê o raio da base da caixa d'água em metros
//         Console.Write("Digite o raio da base da caixa d'água em metros: ");
//         double raio = double.Parse(Console.ReadLine());

//         // Lê a altura da caixa d'água em metros
//         Console.Write("Digite a altura da caixa d'água em metros: ");
//         double altura = double.Parse(Console.ReadLine());

//         // Calcula o volume da caixa d'água usando a fórmula V = pi * r^2 * h
//         double volume = 3.14 * raio * raio * altura;

//         // Exibe o volume da caixa d'água no console
//         Console.WriteLine("O volume da caixa d'água é " + volume + " metros cúbicos.");
//     }
// }

// 8 - questão

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê o preço normal de etiqueta do produto em reais
//         Console.Write("Digite o preço normal de etiqueta do produto em reais: ");
//         double preco = double.Parse(Console.ReadLine());

//         // Lê o código da condição de pagamento escolhida
//         Console.Write("Digite o código da condição de pagamento escolhida (1, 2, 3 ou 4): ");
//         int codigo = int.Parse(Console.ReadLine());

//         // Declara as variáveis para armazenar o valor a ser pago e o valor de cada parcela
//         double valor, parcela;

//         // Verifica qual é o código da condição de pagamento e aplica a regra correspondente
//         if (codigo == 1) // À vista em dinheiro ou cheque, recebe 10% de desconto
//         {
//             // Calcula o valor a ser pago usando a fórmula V = P * 0.9
//             valor = preco * 0.9;

//             // Exibe o valor a ser pago no console
//             Console.WriteLine("O valor a ser pago pelo produto é " + valor + " reais.");
//         }
//         else if (codigo == 2) // À vista no cartão de crédito, recebe 15% de desconto
//         {
//             // Calcula o valor a ser pago usando a fórmula V = P * 0.85
//             valor = preco * 0.85;

//             // Exibe o valor a ser pago no console
//             Console.WriteLine("O valor a ser pago pelo produto é " + valor + " reais.");
//         }
//         else if (codigo == 3) // Em duas vezes, preço normal de etiqueta sem juros
//         {
//             // O valor a ser pago é igual ao preço normal de etiqueta
//             valor = preco;

//             // Calcula o valor de cada parcela usando a fórmula P1 = P2 = V / 2
//             parcela = valor / 2;

//             // Exibe o valor a ser pago e o valor de cada parcela no console
//             Console.WriteLine("O valor a ser pago pelo produto é " + valor + " reais.");
//             Console.WriteLine("O valor de cada parcela é " + parcela + " reais.");
//         }
//         else if (codigo == 4) // Em duas vezes, preço normal de etiqueta mais juros de 10%
//         {
//             // Calcula o valor a ser pago usando a fórmula V = P * 1.1
//             valor = preco * 1.1;

//             // Calcula o valor de cada parcela usando a fórmula P1 = P2 = V / 2
//             parcela = valor / 2;

//             // Exibe o valor a ser pago e o valor de cada parcela no console
//             Console.WriteLine("O valor a ser pago pelo produto é " + valor + " reais.");
//             Console.WriteLine("O valor de cada parcela é " + parcela + " reais.");
//         }
//         else // Código inválido
//         {
//             // Exibe uma mensagem de erro no console
//             Console.WriteLine("Código inválido. Por favor, digite um código válido (1, 2, 3 ou 4).");
//         }
//     }
// }

// 9 - questão

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê o valor em metros que queremos converter
//         Console.Write("Digite o valor em metros que queremos converter: ");
//         double metros = double.Parse(Console.ReadLine());

//         // Calcula o valor em centímetros usando a fórmula cm = m * 100
//         double centimetros = metros * 100;

//         // Calcula o valor em milímetros usando a fórmula mm = m * 1000
//         double milimetros = metros * 1000;

//         // Calcula o valor em quilômetros usando a fórmula km = m / 1000
//         double quilometros = metros / 1000;

//         // Exibe os valores convertidos no console
//         Console.WriteLine("O valor em centímetros é " + centimetros + " cm.");
//         Console.WriteLine("O valor em milímetros é " + milimetros + " mm.");
//         Console.WriteLine("O valor em quilômetros é " + quilometros + " km.");
//     }
// }


// 10 - questão

// using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê a quantidade de latas de 350 ml compradas
        Console.Write("Digite a quantidade de latas de 350 ml compradas: ");
        int latas = int.Parse(Console.ReadLine());

        // Lê a quantidade de garrafas de 600 ml compradas
        Console.Write("Digite a quantidade de garrafas de 600 ml compradas: ");
        int garrafas600 = int.Parse(Console.ReadLine());

        // Lê a quantidade de garrafas de 2 litros compradas
        Console.Write("Digite a quantidade de garrafas de 2 litros compradas: ");
        int garrafas2000 = int.Parse(Console.ReadLine());

        // Calcula o volume de refrigerante comprado usando a fórmula V = 0.35 * L + 0.6 * G1 + 2 * G2
        double volume = 0.35 * latas + 0.6 * garrafas600 + 2 * garrafas2000;

        // Exibe o volume de refrigerante comprado no console
        Console.WriteLine("O volume de refrigerante comprado é " + volume + " litros.");
    }
}

//Proximo exercicio
//questão 1
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Declara uma variável para armazenar a soma
//         int soma = 0;

//         // Declara um vetor para armazenar os 10 números
//         int[] numeros = new int[10];

//         // Lê os 10 números do usuário usando um laço for
//         for (int i = 0; i < 10; i++)
//         {
//             Console.Write("Digite o {0}º número: ", i + 1);
//             numeros[i] = int.Parse(Console.ReadLine());
//         }

//         // Calcula a soma dos 10 números usando um laço foreach
//         foreach (int numero in numeros)
//         {
//             soma += numero;
//         }

//         // Apresenta a soma na tela
//         Console.WriteLine("A soma de todos os números lidos é: {0}", soma);
//     }
// }


//questão 2

// using System;

// class Aluno
// {
//     // Declara os campos da classe
//     public string Nome { get; set; }
//     public double Nota1 { get; set; }
//     public double Nota2 { get; set; }

//     // Declara o método que calcula a média e a situação do aluno
//     public void CalcularMedia()
//     {
//         // Calcula a média aritmética das notas
//         double media = (Nota1 + Nota2) / 2;

//         // Verifica se a média é maior ou igual a 6
//         if (media >= 6)
//         {
//             // Se for, o aluno está aprovado
//             Console.WriteLine("Aluno: {0}", Nome);
//             Console.WriteLine("Média: {0}", media);
//             Console.WriteLine("Situação: Aprovado");
//         }
//         else
//         {
//             // Se não, o aluno está reprovado
//             Console.WriteLine("Aluno: {0}", Nome);
//             Console.WriteLine("Média: {0}", media);
//             Console.WriteLine("Situação: Reprovado");
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Cria um objeto da classe Aluno
//         Aluno aluno = new Aluno();

//         // Atribui os valores dos campos
//         aluno.Nome = "Wallace Oliveira";
//         aluno.Nota1 = 10;
//         aluno.Nota2 = 8;

//         // Chama o método que calcula a média e a situação do aluno
//         aluno.CalcularMedia();
//     }
// }

//questão 3

// Console.Write("Digite o valor do seu salário: ");
// double salario = double.Parse(Console.ReadLine());
// if (salario < 1500.00 )
//         {
//             salario = salario * 1.5;
//         }
//         else if (salario >= 1500.00 && salario < 4300.00)
//         {
//             salario = salario * 1.4;
//         }
//         else
//         {
//             salario = salario * 1.3;
//         }
// }

// Console.WriteLine("Valor do salário: ", salario);


//questão 4

// Console.Write("Digite a idade do nadador: ");
// double idade = int.Parse(Console.ReadLine());
// if (idade >= 5 && idade <= 7)
//         {
//            Console.WriteLine("Categoria Infantil A");
//         }
//         else if (idade >= 8 && idade <= 10)
//         {
//             Console.WriteLine("Categoria Infantil B");
//         }
//         else if (idade >= 11 && idade <= 13)
//         {
//             Console.WriteLine("Categoria Juvenil A");
//         }
//         else if (idade >= 14 && idade <= 17)
//         {
//             Console.WriteLine("Categoria Juvenil B");
//         }
//         else if (idade > 18)
//         {
//             Console.WriteLine("Adulto");
//         }

//         else 
//         {
//             Console.WriteLine("Categoria Inexistente");
//         }

//questão 5

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê a quantidade de latas de 350 ml compradas
//         Console.Write("Digite a quantidade de latas de 350 ml compradas: ");
//         int latas = int.Parse(Console.ReadLine());

//         // Lê a quantidade de garrafas de 600 ml compradas
//         Console.Write("Digite a quantidade de garrafas de 600 ml compradas: ");
//         int garrafas600 = int.Parse(Console.ReadLine());

//         // Lê a quantidade de garrafas de 2 litros compradas
//         Console.Write("Digite a quantidade de garrafas de 2 litros compradas: ");
//         int garrafas2000 = int.Parse(Console.ReadLine());

//         // Calcula o volume de refrigerante comprado usando a fórmula V = 0.35 * L + 0.6 * G1 + 2 * G2
//         double volume = 0.35 * latas + 0.6 * garrafas600 + 2 * garrafas2000;

//         // Exibe o volume de refrigerante comprado no console
//         Console.WriteLine("O volume de refrigerante comprado é " + volume + " litros.");
//     }
// }


//questão 6

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê as duas notas do aluno em uma escala de 0 a 10
//         Console.Write("Digite a primeira nota do aluno: ");
//         double nota1 = double.Parse(Console.ReadLine());
//         Console.Write("Digite a segunda nota do aluno: ");
//         double nota2 = double.Parse(Console.ReadLine());

//         // Calcula a média das duas notas usando a fórmula M = (N1 + N2) / 2
//         double media = (nota1 + nota2) / 2;

//         // Exibe a média do aluno no console
//         Console.WriteLine("A média do aluno é " + media + ".");

//         // Verifica se a média é maior ou igual a 7 e exibe uma mensagem de acordo com o resultado
//         if (media >= 7) // Aprovado
//         {
//             Console.WriteLine("Aprovado.");
//             Console.WriteLine("Recebe Certificado.");
//         }
//         else // Reprovado
//         {
//             Console.WriteLine("Reprovado.");
//             Console.WriteLine("Não recebe Certificado.");
//         }
//     }
// }


//questão 7

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê os dados a, b e c do usuário
//         Console.Write("Digite o valor de a: ");
//         double a = double.Parse(Console.ReadLine());
//         Console.Write("Digite o valor de b: ");
//         double b = double.Parse(Console.ReadLine());
//         Console.Write("Digite o valor de c: ");
//         double c = double.Parse(Console.ReadLine());

//         // Calcula o discriminante usando a fórmula Delta = b^2 - 4ac
//         double delta = b * b - 4 * a * c;

//         // Verifica se o discriminante é positivo, negativo ou zero e calcula as raízes usando a fórmula x = (-b +- sqrt(Delta)) / 2a
//         if (delta > 0) // Duas raízes reais e distintas
//         {
//             double x1 = (-b + Math.Sqrt(delta)) / (2 * a); // Raiz com o sinal positivo
//             double x2 = (-b - Math.Sqrt(delta)) / (2 * a); // Raiz com o sinal negativo
//             Console.WriteLine("As raízes da equação são " + x1 + " e " + x2 + ".");
//         }
//         else if (delta == 0) // Uma raiz real e dupla
//         {
//             double x = -b / (2 * a); // Raiz única
//             Console.WriteLine("A raiz da equação é " + x + ".");
//         }
//         else // Nenhuma raiz real
//         {
//             Console.WriteLine("A equação não possui raízes reais.");
//         }
//     }
// }


//questão 8

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Lê o peso, a altura, o gênero e a idade do usuário
//         Console.Write("Digite o seu peso em quilogramas: ");
//         double peso = double.Parse(Console.ReadLine());
//         Console.Write("Digite a sua altura em metros: ");
//         double altura = double.Parse(Console.ReadLine());
//         Console.Write("Digite o seu gênero (M para masculino, F para feminino): ");
//         char genero = char.Parse(Console.ReadLine());
//         Console.Write("Digite a sua idade em anos: ");
//         int idade = int.Parse(Console.ReadLine());

//         // Calcula o IMC usando a fórmula IMC = peso / altura^2
//         double imc = peso / (altura * altura);

//         // Exibe o IMC do usuário no console
//         Console.WriteLine("O seu IMC é " + imc + ".");

//         // Verifica o gênero do usuário e compara o IMC com a tabela de IMC ideal
//         if (genero == 'M') // Usuário é do gênero masculino
//         {
//             if (idade >= 20 && idade <= 24) // Usuário tem entre 20 e 24 anos
//             {
//                 if (imc >= 20 && imc <= 25) // IMC está entre 20 e 25
//                 {
//                     Console.WriteLine("O seu IMC está ideal para a sua idade e gênero.");
//                 }
//                 else if (imc < 20) // IMC é menor que 20
//                 {
//                     Console.WriteLine("O seu IMC está abaixo do ideal para a sua idade e gênero.");
//                 }
//                 else // IMC é maior que 25
//                 {
//                     Console.WriteLine("O seu IMC está acima do ideal para a sua idade e gênero.");
//                 }
//             }
//             // Repete o mesmo processo para as outras faixas de idade e IMC
//             // ...
//         }
//         else if (genero == 'F') // Usuário é do gênero feminino
//         {
//             if (idade >= 20 && idade <= 24) // Usuário tem entre 20 e 24 anos
//             {
//                 if (imc >= 19 && imc <= 24) // IMC está entre 19 e 24
//                 {
//                     Console.WriteLine("O seu IMC está ideal para a sua idade e gênero.");
//                 }
//                 else if (imc < 19) // IMC é menor que 19
//                 {
//                     Console.WriteLine("O seu IMC está abaixo do ideal para a sua idade e gênero.");
//                 }
//                 else // IMC é maior que 24
//                 {
//                     Console.WriteLine("O seu IMC está acima do ideal para a sua idade e gênero.");
//                 }
//             }
//             // Repete o mesmo processo para as outras faixas de idade e IMC
//             // ...
//         }
//         else // Usuário digitou um gênero inválido
//         {
//             Console.WriteLine("O gênero digitado é inválido. Por favor, digite M para masculino ou F para feminino.");
//         }
//     }
// }


// Atividade - Aplicando lógica A
// Questão 1


// Questão 2


// Questão 3


// Questão 4


// Questão 5


// Questão 6



