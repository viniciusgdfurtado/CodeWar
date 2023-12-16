using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira números separados por vírgula
        Console.WriteLine("Digite números separados por vírgula:");
        string entradaUsuario = Console.ReadLine();

        // Converte a entrada do usuário em um array de números inteiros
        int[] numeros = entradaUsuario.Split(',').Select(int.Parse).ToArray();

        // Dicionário para armazenar o mapeamento entre números e nomes
        Dictionary<int, string> mapeamento = new Dictionary<int, string>();

        // Preenche o dicionário com base nos números fornecidos pelo usuário
        foreach (var numero in numeros)
        {
            // Gera um nome automaticamente com base no número
            string nome = GerarNome(numero);
            mapeamento[numero] = nome;
        }

        // Converte os números para nomes usando o dicionário
        var nomes = numeros.Select(numero => mapeamento[numero]);

        // Ordena os nomes em ordem alfabética
        var nomesOrdenados = nomes.OrderBy(nome => nome);

        // Imprime os resultados
        Console.WriteLine("Números originais: " + string.Join(", ", numeros));
        Console.WriteLine("Nomes correspondentes: " + string.Join(", ", nomes));
        Console.WriteLine("Nomes ordenados: " + string.OrderByDescending().Join(", ", nomesOrdenados));
    }

    // Função para gerar um nome com base no número
    static string GerarNome(int numero)
    {
        if (numero < 0 || numero > 999)
        {
            throw new ArgumentException("Número fora do intervalo permitido (0-999)");
        }

        if (numero == 0)
        {
            return "zero";
        }

        string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        string result = "";

        if (numero >= 100)
        {
            result += units[numero / 100] + " hundred";
            numero %= 100;
            if (numero > 0)
            {
                result += " and";
            }
        }

        if (numero >= 20)
        {
            result += " " + tens[numero / 10];
            numero %= 10;
        }

        if (numero > 0)
        {
            if (numero >= 11 && numero <= 19)
            {
                result += " " + teens[numero - 10];
            }
            else
            {
                result += " " + units[numero];
            }
        }

        return result.Trim();
    }
}