// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-----------\nEXERCÍCIO 2\n-----------");

int[] valores = new int[3];
int maior = 0;
Console.Write("Insira o primeiro valor: ");
valores[0] = int.Parse(Console.ReadLine());
Console.Write("Insira o primeiro valor: ");
valores[1] = int.Parse(Console.ReadLine());
Console.Write("Insira o primeiro valor: ");
valores[2] = int.Parse(Console.ReadLine());

for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] > maior)
    {
        maior = valores[i];
    }
}
Console.WriteLine($"\nO maior valor é: {maior}.");