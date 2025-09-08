// See https://aka.ms/new-console-template for more information
using Exercise02;
using MathLibrary;


Console.WriteLine("Hello, World!");

Person person = new()
{
    Name = "Peter"
    , Age = 32
};


Console.WriteLine($"The name of the person is {person.Name}");

Console.WriteLine($"The age of the person is {person.Age}");