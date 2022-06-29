// internal class Program
// {
//     private static void Main(string[] args)
//     {
        void thirdNumber()
        {
            // int number = new Random().Next(10, 1000001);
            Console.Write("Input number: "); 
            int number = Convert.ToInt32(Console.ReadLine()); 
            Console.Write(number + " " + "->");
            if (number >= 1000000){
                Console.WriteLine(" Please, input number less than 1 000 000");
            }
            else if (number >= 100000 && number < 1000000){
                Console.WriteLine(" " + number / 1000 % 10);
            }
            else if (number >= 10000 && number < 100000){
                Console.WriteLine(" " + number / 100 % 10);
            }
            else if (number >= 1000 && number < 10000){
                Console.WriteLine(" " + number / 10 % 10);
            }
            else if (number >= 100 && number < 1000){
                Console.WriteLine(" " + number % 10);
            }
            else {
                Console.WriteLine(" Third number exist");
            }
        }
           for (int i = 0; i < 6; i++)
        {

            thirdNumber();
        }
//     }
// }