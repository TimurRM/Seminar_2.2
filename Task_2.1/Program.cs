// // internal class Program
// // {
//     private static void Main(string[] args)
//     {
        void randomNumber()
        {
            int number = new Random().Next(100, 1000);
            Console.WriteLine(number + " -> " + number / 10 % 10);
        }
        for (int i = 0; i < 10; i++)
        {
            randomNumber();
        }
//     }
// }