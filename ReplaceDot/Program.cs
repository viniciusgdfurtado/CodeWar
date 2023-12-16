public class Kata
{
    public static string ReplaceDots(string str, string replaced, string replacer)
    {        
        return str.Replace(replaced, replacer);        
    }    

    static void Main(){
        Console.Write("Digite o texto que terá o caracter removido: ");
        string str = Console.ReadLine();
        Console.Write("Digite o caracter a ser removido: ");
        string caracterRemovido = Console.ReadLine();
        Console.Write($"Digite o caracter que vai substituir({caracterRemovido}): ");
        string caracterSubstituto = Console.ReadLine();
        Console.WriteLine(ReplaceDots(str, caracterRemovido, caracterSubstituto));
    }

}