// Exercicio Situação de Aprendizagem
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

// Exercicio Situação de Aprendizagem
// 1 questão
//solução 2

        Console.Write("Digite o comprimento do terreno em metros: ");
        double comprimento = double.Parse(Console.ReadLine());

        Console.Write("Digite a largura do terreno em metros: ");
        double largura = double.Parse(Console.ReadLine());

        double area = largura * comprimento;

        Console.WriteLine("A área do terreno é " + area + " metros quadrados.");



// 2 - questão

        Console.Write("Digite o número de cavalos comprados para o haras: ");
        int cavalos = int.Parse(Console.ReadLine());

        int ferraduras = 4 * cavalos;

        Console.WriteLine("São necessárias " + ferraduras + " ferraduras para equipar todos os cavalos.");


// 3 - questão

        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a sua idade em anos completos: ");
        int idade = int.Parse(Console.ReadLine());

        int dias = 365 * idade;

        Console.WriteLine(nome.ToUpper() + ", VOCÊ JÁ VIVEU " + dias + " DIAS.");


// 4 - questão

        Console.Write("Digite o preço do litro da gasolina em reais: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do pagamento em reais: ");
        double pagamento = double.Parse(Console.ReadLine());

        double litros = pagamento / preco;

        Console.WriteLine("Você conseguiu colocar " + litros + " litros de gasolina no tanque.");

// 5 - questão

        Console.Write("Digite a quantidade de camisetas pequenas vendidas: ");
        int pequenas = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de camisetas médias vendidas: ");
        int medias = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de camisetas grandes vendidas: ");
        int grandes = int.Parse(Console.ReadLine());

        int valor = 10 * pequenas + 12 * medias + 15 * grandes;

        Console.WriteLine("O valor arrecadado com a venda das camisetas é " + valor + " reais.");

// 6 - questão

        Console.Write("Digite o salário do funcionário em reais: ");
        double salario = double.Parse(Console.ReadLine());

        double aumento = salario * 1.15;

        double final = aumento * 0.92;

        Console.WriteLine("O salário inicial do funcionário é " + salario + " reais.");
        Console.WriteLine("O salário com o aumento de 15% é " + aumento + " reais.");
        Console.WriteLine("O salário final com o desconto de 8% de impostos é " + final + " reais.");

// 7 - questão

        Console.Write("Digite o raio da base da caixa d'água em metros: ");
        double raio = double.Parse(Console.ReadLine());
        Console.Write("Digite a altura da caixa d'água em metros: ");
        double altura = double.Parse(Console.ReadLine());

        // Calcula o volume da caixa d'água usando a fórmula V = pi * r^2 * h
        double volume = 3.14 * raio * raio * altura;

        Console.WriteLine("O volume da caixa d'água é " + volume + " metros cúbicos.");

// 8 - questão

        Console.Write("Digite o preço normal de etiqueta do produto em reais: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Digite o código da condição de pagamento escolhida (1, 2, 3 ou 4): ");
        int codigo = int.Parse(Console.ReadLine());

        double valor, parcela;

        if (codigo == 1)
        {
            // Calcula o valor a ser pago usando a fórmula V = P * 0.9
            valor = preco * 0.9;

            Console.WriteLine("O valor a ser pago pelo produto é " + valor + " reais.");
        }
        else if (codigo == 2)
        {

            valor = preco * 0.85;

            Console.WriteLine("O valor a ser pago pelo produto é " + valor + " reais.");
        }
        else if (codigo == 3)
        {
            valor = preco;

            // Calcula o valor de cada parcela usando a fórmula P1 = P2 = V / 2
            parcela = valor / 2;

            
            Console.WriteLine("O valor a ser pago pelo produto é " + valor + " reais.");
            Console.WriteLine("O valor de cada parcela é " + parcela + " reais.");
        }
        else if (codigo == 4) 
        {
            // Calcula o valor a ser pago usando a fórmula V = P * 1.1
            valor = preco * 1.1;

            parcela = valor / 2;

            Console.WriteLine("O valor a ser pago pelo produto é " + valor + " reais.");
            Console.WriteLine("O valor de cada parcela é " + parcela + " reais.");
        }
        else // Código inválido
        {
            
            Console.WriteLine("Código inválido. Por favor, digite um código válido (1, 2, 3 ou 4).");
        }

// 9 - questão

        Console.Write("Digite o valor em metros que queremos converter: ");
        double metros = double.Parse(Console.ReadLine());

        double centimetros = metros * 100;

        double milimetros = metros * 1000;

        double quilometros = metros / 1000;
        
        Console.WriteLine("O valor em centímetros é " + centimetros + " cm.");
        Console.WriteLine("O valor em milímetros é " + milimetros + " mm.");
        Console.WriteLine("O valor em quilômetros é " + quilometros + " km.");

// 10 - questão

        
        Console.Write("Digite a quantidade de latas de 350 ml compradas: ");
        int latas = int.Parse(Console.ReadLine());

        
        Console.Write("Digite a quantidade de garrafas de 600 ml compradas: ");
        int garrafas600 = int.Parse(Console.ReadLine());

        
        Console.Write("Digite a quantidade de garrafas de 2 litros compradas: ");
        int garrafas2000 = int.Parse(Console.ReadLine());

        
        double volume = 0.35 * latas + 0.6 * garrafas600 + 2 * garrafas2000;

        
        Console.WriteLine("O volume de refrigerante comprado é " + volume + " litros.");

//Proximo exercicio - Aplicando Lógica em C# (C)
//questão 1

        int soma = 0;

        int[] numeros = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o {0}º número: ", i + 1);
            numeros[i] = int.Parse(Console.ReadLine());
        }
        foreach (int numero in numeros)
        {
            soma += numero;
        }

        Console.WriteLine("A soma de todos os números lidos é: {0}", soma);
    }
}


//questão 2

        // Cria um objeto da classe Aluno
        Aluno aluno = new Aluno();
        aluno.Nome = "Wallace Oliveira";
        aluno.Nota1 = 10;
        aluno.Nota2 = 8;

        aluno.CalcularMedia();


//questão 3

Console.Write("Digite o valor do seu salário: ");
double salario = double.Parse(Console.ReadLine());
if (salario < 1500.00 )
        {
            salario = salario * 1.5;
        }
        else if (salario >= 1500.00 && salario < 4300.00)
        {
            salario = salario * 1.4;
        }
        else
        {
            salario = salario * 1.3;
        }
}

Console.WriteLine("Valor do salário: ", salario);


//questão 4

Console.Write("Digite a idade do nadador: ");
double idade = int.Parse(Console.ReadLine());
if (idade >= 5 && idade <= 7)
        {
           Console.WriteLine("Categoria Infantil A");
        }
        else if (idade >= 8 && idade <= 10)
        {
            Console.WriteLine("Categoria Infantil B");
        }
        else if (idade >= 11 && idade <= 13)
        {
            Console.WriteLine("Categoria Juvenil A");
        }
        else if (idade >= 14 && idade <= 17)
        {
            Console.WriteLine("Categoria Juvenil B");
        }
        else if (idade > 18)
        {
            Console.WriteLine("Adulto");
        }

        else 
        {
            Console.WriteLine("Categoria Inexistente");
        }

//questão 5

using System;

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


//questão 6

using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê as duas notas do aluno em uma escala de 0 a 10
        Console.Write("Digite a primeira nota do aluno: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota do aluno: ");
        double nota2 = double.Parse(Console.ReadLine());

        // Calcula a média das duas notas usando a fórmula M = (N1 + N2) / 2
        double media = (nota1 + nota2) / 2;

        // Exibe a média do aluno no console
        Console.WriteLine("A média do aluno é " + media + ".");

        // Verifica se a média é maior ou igual a 7 e exibe uma mensagem de acordo com o resultado
        if (media >= 7) // Aprovado
        {
            Console.WriteLine("Aprovado.");
            Console.WriteLine("Recebe Certificado.");
        }
        else // Reprovado
        {
            Console.WriteLine("Reprovado.");
            Console.WriteLine("Não recebe Certificado.");
        }
    }
}


//questão 7

        Console.Write("Digite o valor de a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor de b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor de c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a); 
            Console.WriteLine("As raízes da equação são " + x1 + " e " + x2 + ".");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("A raiz da equação é " + x + ".");
        }
        else
        {
            Console.WriteLine("A equação não possui raízes reais.");
        }
    }
}


//questão 8

        Console.Write("Digite o seu peso em quilogramas: ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Digite a sua altura em metros: ");
        double altura = double.Parse(Console.ReadLine());
        Console.Write("Digite o seu gênero (M para masculino, F para feminino): ");
        char genero = char.Parse(Console.ReadLine());
        Console.Write("Digite a sua idade em anos: ");
        int idade = int.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("O seu IMC é " + imc + ".");
        if (genero == 'M')
        {
            if (idade >= 20 && idade <= 24)
            {
                if (imc >= 20 && imc <= 25)
                {
                    Console.WriteLine("O seu IMC está ideal para a sua idade e gênero.");
                }
                else if (imc < 20)
                {
                    Console.WriteLine("O seu IMC está abaixo do ideal para a sua idade e gênero.");
                }
                else
                {
                    Console.WriteLine("O seu IMC está acima do ideal para a sua idade e gênero.");
                }
            }

        }
        else if (genero == 'F')
        {
            if (idade >= 20 && idade <= 24)
            {
                if (imc >= 19 && imc <= 24) 
                {
                    Console.WriteLine("O seu IMC está ideal para a sua idade e gênero.");
                }
                else if (imc < 19) 
                {
                    Console.WriteLine("O seu IMC está abaixo do ideal para a sua idade e gênero.");
                }
                else 
                {
                    Console.WriteLine("O seu IMC está acima do ideal para a sua idade e gênero.");
                }
            }

        }
        else // Usuário digitou um gênero inválido
        {
            Console.WriteLine("O gênero digitado é inválido. Por favor, digite M para masculino ou F para feminino.");
        }
    }
}


// Atividade - Aplicando lógica com C# (A)
// Questão 1

        Console.Write("Digite o seu ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        int anoAtual = DateTime.Now.Year;

        int idade = anoAtual - anoNascimento;

        Console.WriteLine("Você tem " + idade + " anos.");
    }
}


// Questão 2

    static double VolumeEsfera(double raio)
    {

        const double pi = 3.14;

        double volume = 4.0 / 3.0 * pi * Math.Pow(raio, 3);

        return volume;
    }

        Console.Write("Digite o raio da esfera: ");
        double raio = double.Parse(Console.ReadLine());

        double volume = VolumeEsfera(raio);

        Console.WriteLine("O volume da esfera é " + volume + ".");


// Questão 3

        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double soma = num1 + num2;
        Console.WriteLine("A soma dos números é: " + soma);

        double subtracao = num1 - num2;
        Console.WriteLine("A subtração dos números é: " + subtracao);

        double multiplicacao = num1 * num2;
        Console.WriteLine("A multiplicação dos números é: " + multiplicacao);

        double divisao = num1 / num2;
        Console.WriteLine("A divisão dos números é: " + divisao);


// Questão 4

        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0) 
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");
        }

// Questão 5

        Console.Write("Digite o valor que possui em dólar (US$): ");
        double valorDolar = double.Parse(Console.ReadLine());

        Console.Write("Digite a cotação do dólar atual (R$): ");
        double cotacaoDolar = double.Parse(Console.ReadLine());
        double valorReal = valorDolar * cotacaoDolar;

        Console.WriteLine("O valor que possui em reais é: R$ " + valorReal);

// Questão 6 - Já existe



