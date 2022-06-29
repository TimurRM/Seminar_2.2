// internal class Program
// {
//     private static void Main(string[] args)
//     {
        void weekDay()
        {
            Console.Write("Input number: "); 
            int number = Convert.ToInt32(Console.ReadLine()); 
            Console.Write(number + " " + "->");
            if (number == 1){
                Console.WriteLine(" It is Monday");
            }
            else if (number == 2){
                Console.WriteLine(" It is Tuesday");
            }
            else if (number == 3){
                Console.WriteLine(" It is Wednesday");
            }
            else if (number == 4){
                Console.WriteLine(" It is Thursday");
            }
            else if (number == 5){
                Console.WriteLine(" It is Friday");
            }
            else if (number == 6){
                Console.WriteLine(" It is Saturday");
            }
            else if (number == 7){
                Console.WriteLine(" It is Sunday");
            }
            else {
                Console.WriteLine(" Input numbers from 1 to 7");
            }
        }
           for (int i = 0; i < 8; i++)
        {

            weekDay();
        }
//     }
// }