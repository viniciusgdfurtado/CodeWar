namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      return (number%2 == 0) ? "Par(Even)": "Ímpar(Odd)";      
    }

    static void Main(string[] args){
        Console.Write("Digite um número para saber se ele é Par(Even) ou Ímpar(Odd): ");
        int.TryParse(Console.ReadLine(), out int numero);
        Console.WriteLine($"O número informado é: {EvenOrOdd(numero)}");
    }

  }
}