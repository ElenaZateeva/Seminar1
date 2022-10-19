int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (number1 > number2) 
    max = number1;
else 
max = number2;

if (max < number3) 
    max = number3;

Console.Write("Наибольшее число  из 3х чисел: ");
Console.WriteLine(max);
