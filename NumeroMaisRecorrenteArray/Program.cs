public class Kata
{
  public static int HighestRank(int[] arr)
  {
    Dictionary<int, int> counts = new Dictionary<int, int>();

    if (arr == null)
    {
      return 0;
    }

    foreach (int number in arr)
    {
      {
        if (counts.ContainsKey(number))
          counts[number]++;
        else
          counts[number] = 1;
      }
    }

    return counts.Where(pair => pair.Value == counts.Values.Max())
                  .Select(pair => pair.Key)
                  .ToList()
                  .Max();

  }

  static void Main(string[] args)
  {
    var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
    Console.WriteLine($"O número que mais se repete é: {HighestRank(arr)}");
  }

}