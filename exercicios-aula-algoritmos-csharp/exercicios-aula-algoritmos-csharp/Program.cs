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
