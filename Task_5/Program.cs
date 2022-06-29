// int number = new Random().Next(10, 100);
// //Console.Write(number);
// int num1 = number / 10;
// int num2 = number % 10;
// Console.WriteLine(number + " " + num1 + " " + num2);

// if (num1 > num2) {
//     Console.WriteLine(num1); 
// }
// else {
//     Console.WriteLine(num2);
// }


void randomNumber(){
    int num1 = new Random().Next(100);
    int num2 = new Random().Next(101, 100000);
    int number = new Random().Next(num1, num2);
    //Console.Write(number);
    Console.Write(number + " -> " );

    if (number / 10 > number % 10) 
    {
        Console.WriteLine(number / 10); 
    }
    else 
    {
        Console.WriteLine(number % 10);
    }
}    
    for (int i = 0; i < 4; i++)
{
randomNumber();
}