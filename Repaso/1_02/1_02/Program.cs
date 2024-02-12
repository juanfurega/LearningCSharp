double numeroIngresado;
double numeroCuadrado = 0;
double numeroCubo = 0;

do
{
    Console.WriteLine("Ingrese un número: ");
    numeroIngresado = double.Parse(Console.ReadLine());

    if(numeroIngresado < 0)
    {
        Console.WriteLine("ERROR. ¡Reingresar número!.\n");
    }

}while(numeroIngresado < 0);


if(numeroIngresado > 0)
{
    numeroCuadrado = Math.Pow(numeroIngresado, 2);
    numeroCubo = Math.Pow(numeroIngresado, 3);
}
    else
    {

        numeroCuadrado = 1;
        numeroCubo = 1;

    }

Console.WriteLine("El número ingresado es: " + numeroIngresado +
                  "\nsu cuarado es: " + numeroCuadrado + 
                  "\nsu cubo es: " + numeroCubo);