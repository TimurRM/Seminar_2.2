void randomNumber(){
    int number = new Random().Next(10, 1000000);
    // Console.Write("Input number: "); // For check
    // int number = Convert.ToInt32(Console.ReadLine()); // For check
    Console.Write(number + " " + "->");
        if (number >= 100000){
            Console.WriteLine(" " + number / 1000 % 10);
        }
        else if (number >= 10000 & number < 100000){
            Console.WriteLine(" " + number / 100 % 10);
        }
        else if (number >= 1000 & number < 10000){
            Console.WriteLine(" " + number / 10 % 10);
        }    
        else if (number >= 100 & number < 1000){
            Console.WriteLine(" " + number % 10);   
        }
        else{
            Console.WriteLine("  3-d number exist");
        }
}
    for (int i = 0; i < 10000; i++)
{
      
    randomNumber();
    }