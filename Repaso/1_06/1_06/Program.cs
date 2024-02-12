using System.Security.AccessControl;

string inputUsuario;
int numero;
int acumuladorAscendente = 0;
int acumuladorDescendente = 0;
int i;
int j;

Console.WriteLine("Ingresá un número que te tiro un centro, maestro");
inputUsuario = Console.ReadLine();

while(!int.TryParse(inputUsuario, out numero))
{
    Console.WriteLine("¡Te equivocaste master! Volver a intentarlo. \nIngresa un número que te tiro un centro: ");
    inputUsuario = Console.ReadLine();
}

for (i = 1; i < numero; i++)
{
    acumuladorAscendente += i;

    for(j = numero; j > i + 1 ; j--)
    {
        acumuladorDescendente += j;
    }

    if(acumuladorAscendente == acumuladorDescendente)
    {
        Console.WriteLine("Te tiro el centro desde el " + acumuladorAscendente);
        break;
    }

    if(i == numero - 1 && j == i + 1)
    {
        Console.WriteLine("No hay centro, loco");
    }

    acumuladorDescendente = 0;
}