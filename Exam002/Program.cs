int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (numberA > numberB) 
    max = numberA;
else max = numberB;
Console.Write("Наибольшее число: ");
Console.WriteLine(max);