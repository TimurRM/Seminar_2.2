internal class Task_1
{
    private static void Main(string[] args)
    {
        Console.Write("Input first number: ");
        int num_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input second number: ");
        int num_2 = Convert.ToInt32(Console.ReadLine());


        if (num_1 > num_2)
            Console.WriteLine("a = " + num_1 + ", b = " + num_2 + "    -->  max =  " + num_1 + "");
        else if (num_1 < num_2)
            Console.WriteLine("a = " + num_1 + ", b = " + num_2 + "    -->  max =  " + num_2 + "");
        else
            Console.WriteLine("a = " + num_1 + ", b = " + num_2 + "    -->  a = b");
    }
}