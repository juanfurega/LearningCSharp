using System.Security.Cryptography;

int acumulador = 0;
int j;
int i;

for (i = 1; i < 8130; i++)
{
    for (j = 1; j < i; j++)
    {
        if(i % j == .0)
        {
            acumulador += j;
        }
    }

    if(acumulador == i)
    {
        Console.WriteLine(i + " es un número pefecto");
    }
    acumulador = 0;
    j = 1;
}
