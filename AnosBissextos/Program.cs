using System;

public static class Kata
{
  public static bool IsLeapYear(int year)
  {    
    return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
  }

  static void Main(string[] args)
  {
    Console.Write("Digite um ano para saber se o mesmo é/será bissexto: ");
    int.TryParse(Console.ReadLine(), out int year);    
    Console.Write($"O ano({year}) informado é/será Bissexto? {IsLeapYear(year)}");
  }
}