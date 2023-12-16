public static class Kata
{
  public static int Solution(int value)
  {
    int soma = 0;

    if (value < 0)
    {
      return soma;
    }

    for (int i = 0; i < value; i++)
    {
      if ((i % 3 == 0) || (i % 5 == 0))
      {
        soma += i;
      }
    }

    return soma;

  }

  static void Main(string[] args)
  {
    Console.Write("Digite um número limite para o intervalo da soma: ");
    int.TryParse(Console.ReadLine(), out int numero);
    Console.WriteLine($"A Soma dos multiplos é: {Solution(numero)}");
  }

}