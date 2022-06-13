// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-----------\nEXERCÍCIO 5\n-----------");
Console.Write("Insira o salário do funcionário em reais: ");
float salario = float.Parse(Console.ReadLine());
float perc = 0.00f, aumento, salarioNovo;


if (salario > 0 && salario <= 400.00)
{
    perc = 0.15f;
}
else if (salario > 400.00 && salario <= 800.00)
{
    perc = 0.12f;
}
else if (salario > 800.00 && salario <= 1200.00)
{
    perc = 0.10f;
}
else if (salario > 1200.00 && salario <= 2000.00)
{
    perc = 0.07f;
}
else if (salario > 2000.00)
{
    perc = 0.04f;
}

aumento = perc * salario;
salarioNovo = salario + aumento;
Console.WriteLine($"O novo salário será: R$ {salarioNovo:00.00}.");
Console.WriteLine($"O aumento será de: R$ {aumento:00.00}.");
Console.WriteLine($"O percentual será de: {perc * 100}%.");