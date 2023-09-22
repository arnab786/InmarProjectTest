
internal class Program
{
    public static void Main(string[] args)
    {
        FizzBuzzProgram();
        Console.WriteLine("-----------------------------------------------------");
        StringReverse("abcdef");


        static void FizzBuzzProgram()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i + "number have -->  fizzbuzz");
                    }
                    else
                    {
                        Console.WriteLine(i + "number have -->  fizz");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + "number have -->  buzz");
                }
            }
        }
    }

    static void StringReverse(string inputString)
    {
        string reverseString = string.Empty;
        Console.WriteLine("The Input String is --> " + inputString);
        for(int i= inputString.Length - 1; i >= 0; i--)
        {
            reverseString += inputString[i].ToString();
        }
        Console.WriteLine("The Reverse String is --> " + reverseString);
    }
}