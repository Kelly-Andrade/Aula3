// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-----------\nEXERCÍCIO 1\n-----------");

int notaCem, notaCinq, notaVinte, notaDez, notaCinco, notaDois;

Console.Write("Insira um valor monetário: ");
double valor = float.Parse(Console.ReadLine());
notaCem = (int)valor / 100;
valor %= 100;
notaCinq = (int)valor / 50;
valor %= 50;
notaVinte = (int)valor / 20;
valor %= 20;
notaDez = (int)valor / 10;
valor %= 10;
notaCinco = (int)valor / 5;
valor %= 5;
notaDois = (int)valor / 2;

Console.WriteLine($"\nNOTAS:\n{notaCem} nota(s) de R$ 100,00 \n{notaCinq} nota(s) de R$ 50,00 \n{notaVinte} nota(s) de R$ 20,00 \n{notaDez} nota(s) de R$ 10,00 \n{notaCinco} nota(s) de R$ 5,00 \n{notaDois} nota(s) de R$ 2,00 \n");
