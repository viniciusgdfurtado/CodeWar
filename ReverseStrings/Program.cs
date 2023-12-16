public static class Kata
{
    public static string ReverseWords(string str)
    {
        string fraseinvertida = "";
        string[] palavras = str.Split(' ');
        for (int i = 0; i < palavras.Length; i++)
        {
            fraseinvertida += new string(palavras[i].Reverse().ToArray());
            if (i != palavras.Length - 1)
            {
                fraseinvertida += ' ';
            }
        }

        return fraseinvertida;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite a frase/palavra para ser invertida (Em caso de frases, a ordem das palavras será mantida): ");        
        Console.WriteLine(ReverseWords(Console.ReadLine()));
    }

}