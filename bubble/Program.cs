// See https://aka.ms/new-console-template for more information
using bubble;

Console.WriteLine("Ordenção com Bobble");
int[] arrNumber = new int[] { 99, 50, -24, 0, 1 };
string[] arrString = new string[] { "gustavo", "daniel", "bruno", "igor" };

foreach (var number in arrNumber)
{
    Console.Write($"[{number}]");
}

var arOrdered = BubbleSortOrder.Sort<int>(arrNumber);

var arrStringordered = BubbleSortOrder.Sort<string>(arrString);
Console.WriteLine("vetor ordenado");

foreach (var number in arOrdered)
{
    Console.Write($"[{number}]");
}

foreach (var str in arrStringordered)
{
    Console.Write($"[{str}]");
}