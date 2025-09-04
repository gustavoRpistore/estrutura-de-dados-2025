using System.Collections.Generic;
Console.WriteLine("digite uma palavra");
string palavra = Console.ReadLine();

Stack<char> chars = new Stack<char>();
foreach (var c in  palavra )

    chars.Push(c);

string palavra_invertida = string.Empty;
while (chars.Count > 0)
{
    char c = chars.Pop();
    palavra_invertida += c;
}

if (palavra == palavra_invertida)
    Console.WriteLine("a palavra e um polindromo");
else
    Console.WriteLine("a palavra nao e um poindromo");


