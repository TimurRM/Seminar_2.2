internal class Task_2
{
    private static void Main(string[] args)
    {
        Console.Write("Input first number: ");
        int number_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input second number: ");
        int number_2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input third number: ");
        int number_3 = Convert.ToInt32(Console.ReadLine());

        int max = 0;
    
        if (number_1 >= number_2 && number_1 >= number_3)
        max = number_1;
        
        else if (number_2 >= number_1 && number_2 >= number_3)
        max = number_2;
        
        else if (number_3 >= number_2 && number_3 >= number_1)
        max = number_3;
        
        Console.WriteLine(+ number_1 + "," + number_2 + "," + number_3 + " --> " + max);
    }
}