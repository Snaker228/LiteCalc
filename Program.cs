int x = int.Parse(Console.ReadLine());
string c = Console.ReadLine();
int y = int.Parse(Console.ReadLine());
Console.Write("Итог: ");
switch (c)
{
    case "/":
        Console.WriteLine(x/y); break;
    case "+":
        Console.WriteLine(x + y); break;
    case "-":
        Console.WriteLine(x - y); break;
    case "*":
        Console.WriteLine(x * y); break;
       
}
Console.ReadLine();