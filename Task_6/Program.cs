void randomNumber(){
    int number = new Random().Next(99, 999);
    int num1 = number / 10 % 10;
    
    Console.WriteLine(number + " -> " + num1);
    }
    for (int i = 0; i < 3; i++)

    {   
    randomNumber();
    }

// void randomNumber(){

//     int number = new Random().Next(99, 1000);
//     Console.WriteLine(number + " -> " + number / 10 % 10 );
    
// }    
//     for (int i = 0; i < 3; i++)
// {
// randomNumber();
// }