internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            for (int current = 2; current <= number; current = current + 2)
                Console.WriteLine(current + " ");
        }
        else
        {
            for (int current = -2; current >= number; current = current - 2)
                Console.WriteLine(current + " ");
        }
    }
}