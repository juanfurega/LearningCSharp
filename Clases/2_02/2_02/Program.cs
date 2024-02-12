int valor;
int acumulador = 0;
char opcion;
bool continuar;

Console.WriteLine("¡Bienvenido! El siguiente script se encarga de sumar enteros hasta que el usuario lo desee");

do
{
    Console.WriteLine("Introduce un número entero:");
    valor = int.Parse(Console.ReadLine());

    acumulador += valor;

    Console.WriteLine("El valor actual es de: " + acumulador + "\n¿Desea continuar? (S/N)");
    opcion = char.Parse(Console.ReadLine());
    continuar = ValidarRespuesta(opcion);

}while (continuar);

Console.WriteLine("El script ha finalizado.");

//  Funcion

static bool ValidarRespuesta(char opcion)
{   
    if(Char.ToLower(opcion) == 's')
    {
        return true;
    }
    else
    {
        return false;
    }
}