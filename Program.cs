// See https://aka.ms/new-console-template for more information
Console.WriteLine("    A");
Console.WriteLine("   BCD");
Console.WriteLine("  EFGHI");
Console.WriteLine(" JKLMNOP");
Console.WriteLine("QRSTUVWXYZ");

Console.WriteLine("    A" + "\n" + "   BCD" + "\n" + "  EFGHI" + "\n" + " JKLMNOP" + "\n" + "QRSTUVWXYZ");
Console.WriteLine(" ");

Console.Write("Enter first integer: "); 
int firstInt = int.Parse(Console.ReadLine());

Console.Write("Enter second integer: "); 
int secondInt = int.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine($"Sum is............{firstInt + secondInt}");
Console.WriteLine($"Difference is ....{firstInt - secondInt}");
Console.WriteLine($"Product is........{firstInt * secondInt}");
Console.WriteLine($"Quotient is ......{firstInt / secondInt}");