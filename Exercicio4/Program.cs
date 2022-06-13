// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-----------\nEXERCÍCIO 4\n-----------");
double n1, n2, n3;

Console.Write("Insira a primeira nota: ");
n1 = double.Parse(Console.ReadLine());
Console.Write("Insira a segunda nota: ");
n2 = double.Parse(Console.ReadLine());
Console.Write("Insira a terceira nota: ");
n3 = double.Parse(Console.ReadLine());
double med = (n1 + n2 + n3) / 3;
Console.WriteLine($"A média das notas é: {med.ToString("F1")}");

string notafinal = (med < 6.0) ? "O aluno tirou F." : (med >= 6 && med < 7.0) ? "O aluno tirou D." : (med >= 7.0 && med < 8.0) ? "O aluno tirou C." : (med >= 8.0 && med < 9.0) ? "O aluno tirou B." : (med >= 9.0 && med < 10.0) ? "O aluno tirou A." : "A média não pode ultrapassar 10.0. Digite apenas notas de 0.0 a 10.0.";
Console.WriteLine(notafinal);