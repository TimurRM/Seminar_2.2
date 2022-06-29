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


// void randomNumber(){
//     int num1 = new Random().Next(100);
//     int num2 = new Random().Next(101, 100000);
//     int number = new Random().Next(num1, num2);
//     Console.Write(number + " -> " );
//     if (number / 10 > number % 10){
//         Console.WriteLine(number / 10); 
//     }
//     else{
//         Console.WriteLine(number % 10);
//     }
// }    
//     for (int i = 0; i < 4; i++)
// {
// randomNumber();
// }


// void randomNumber(int min, int max){
//     int number = new Random().Next(min, max+1);
//     Console.Write(number + " -> " );
//     if (number / 10 > number % 10){
//         Console.WriteLine(number / 10); 
//     }
//     else{
//         Console.WriteLine(number % 10);
//     }
// }
// Console.WriteLine("Input min number: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max number: ");
// int end = Convert.ToInt32(Console.ReadLine());
// randomNumber(start, end);


// int SumTwoNumbers(int a, int b){
//     int sum = a + b;
//     return sum;
//     }

// Console.Write("Input first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of numbers: " + SumTwoNumbers(number1, number2));


int SumTwoNumbers()
{
    Console.Write("Input first number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int sum = number1 - number2;
    return sum;
}
    Console.WriteLine("Dif of numbers: " + SumTwoNumbers()); 
