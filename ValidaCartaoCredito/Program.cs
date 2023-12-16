public class solution
{
    public bool validate(string n)
    {
        // check whether input string is null or empty
        if (string.IsNullOrEmpty(n))
        {
            return false;
        }

        int sumOfDigits = n.Where((e) => e >= '0' && e <= '9')
                            .Reverse()
                            .Select((e, i) => ((int)e - 48) * (i % 2 == 0 ? 1 : 2))
                            .Sum((e) => e / 10 + e % 10);


        return sumOfDigits % 10 == 0;

    }
}