// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

char c ;

Console.WriteLine("enter a alphabet");
c = Convert.ToChar(Console.ReadLine()); 

if  (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
{
    Console.WriteLine("it is a vowel");
}
else
{
    Console.WriteLine("its not a vowel");
}