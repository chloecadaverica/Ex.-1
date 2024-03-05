double[] sal = new double[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}º salário: ");
    sal[i] = double.Parse(Console.ReadLine());
}

double maiorSal = sal[0];

for (int i = 1; i < 10; i++)
{
    if (sal[i] > maiorSal)
    {
        maiorSal = sal[i];
    }
}
Console.WriteLine($"O maior salário é: {maiorSal}");
