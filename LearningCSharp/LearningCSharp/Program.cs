// Learning C#
// ------------------------------------------- //

//Declarando variáveis

//int num1 = 0;
//string nome = "Andressa";
//double salario, imposto, icms;
//float grafico = 1.65f;
//decimal pizza = 1.9563m;
//bool verdadeiro = true;
//bool falso = false;

//primeira operação

//int num2 = 5;
//int num3 = 8;
//int soma = num3 + num2;
//Console.WriteLine(soma);

// Segunda operação

//Console.WriteLine("DIgite o primeiro valor");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("DIgite o segundo valor");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"A soma dos valores é: {num1 + num2}");

// estruturas de repetição
//int = 0;

//while (int < 9)
//{
//    Console.WriteLine(i);
//    int++;
//}
//for 
//for (int i = 0; i < 9; i++)
//{ Console.WriteLine(i); }

//faça enquanto (DO WHILE)
//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while(i < 9);

// ------------------------------------//

//string[] nomes = new string[] { "Walace", "Andressa", "Aislan", "Diego", "João" };
//foreach (string nome in nomes) 
//{  
//    Console.WriteLine(nomes); 
//}

//EStruturas condicionais 

//string situacao = "Aprovado";
//if (situacao == "Aprovado")
//{
//    Console.WriteLine("Recebe o certificado");
//}else
//{
//    Console.WriteLine("Não recebe");
//}


// Switch
//Console.WriteLine("Escolha um valor de 1 a 4");
//int opcao = Convert.ToInt32(Console.ReadLine());

//switch (opcao)
//{
//    case 1: 
//        Console.WriteLine("Entrada no sistema");
//        break;
//    case 2: 
//        Console.WriteLine("Senha Errada");
//        break;
//    case 3: 
//        Console.WriteLine("Usuário Inexistente");
//        break;
//        default: Console.WriteLine("Tente novamente");
//        break;
//}

double valor1 = 0, valor2 = 0, resultado, numero;
string operador, valorDigitado;
bool numeroInteiro;

Console.WriteLine("Digite o primeiro valor: ");
valorDigitado = Console.ReadLine();
numeroInteiro = double.TryParse(valorDigitado, out numero);
if (numeroInteiro)
{
    valor1 = Math.Round(double.Parse(valorDigitado), 4);
}else
{
    Console.WriteLine("Digite um número valido!");
}
Console.WriteLine("Digite a operação ('/ | + | * | - | %(RESTO)'): ");
    operador  = Console.ReadLine();

Console.WriteLine("Digite o segundo valor: ");
valorDigitado = Console.ReadLine();
if (numeroInteiro)
{
    valor2 = Math.Round(double.Parse(valorDigitado), 4);
}
else
{
    Console.WriteLine("Digite um número valido!");
}

switch (operador) 
{
    case "+":
        resultado = Math.Round(valor1 + valor2, 4);
        Console.WriteLine($"{valor1} {"+"} {valor2} = {resultado}");
        break;
    case "-":
        resultado = Math.Round(valor1 - valor2, 4);
        Console.WriteLine($"{valor1} {"-"} {valor2} = {resultado}");
        break;
    case "*":
        resultado = Math.Round(valor1 * valor2, 4);
        Console.WriteLine($"{valor1} {"*"} {valor2} = {resultado}");
        break;
    case "/":
        resultado = Math.Round(valor1 / valor2, 4);
        Console.WriteLine($"{valor1} {"/"} {valor2} = {resultado}");
        break;
    case "%":
        resultado = Math.Round(valor1 % valor2, 4);
        Console.WriteLine($"{valor1} {"%"} {valor2} = {resultado}");
        break;
    default:
        Console.WriteLine("Digite uma operação válida!");
        break;
}