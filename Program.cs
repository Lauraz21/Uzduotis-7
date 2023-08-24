Console.Write("Iveskite skaiciu:");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 3 == 0 && number % 5 == 0)
{
    Console.WriteLine("BazingaPop");
}
else if (number % 3 == 0)
{
    Console.WriteLine("Bazinga");    
}
else if (number % 5 == 0)
{
    Console.WriteLine("Pop");
}
else 
{
    Console.WriteLine(number);
}