// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-----------\nEXERCÍCIO 3\n-----------");
double nota1, nota2, nota3;

Console.Write("Insira a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.Write("Insira a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());
Console.Write("Insira a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());
double media = (nota1 + nota2 + nota3) / 3;


/*if (media < 7.0)
{
    Console.WriteLine($"A média é {media.ToString("F1")} e o aluno foi reprovado.");
}
else if (media >= 7.0)
{
    Console.WriteLine($"A média é {media.ToString("F1")} e o aluno foi aprovado.");
}*/

string resultado = (media < 7.0) ? $"A média é {media.ToString("F1")} e o aluno foi reprovado." : (media >= 7.0 && media <= 10.0) ? $"A média é {media.ToString("F1")} e o aluno foi aprovado." : "A média não pode ultrapassar 10.0. Digite apenas notas de 0.0 a 10.0.";
Console.WriteLine(resultado);