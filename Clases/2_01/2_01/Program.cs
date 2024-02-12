using System.Globalization;

float promedio;
int contador = 0;
int acumulador = 0;
int limite = 5;    //  Representa la cantidad de valores a introducir
int[] valoresCargados = new int[limite];
bool flagMinimo = false;
int guardarMinimo = int.MaxValue;
bool flagMaximo = false;
int guardarMaximo = int.MinValue;

Console.WriteLine("¡Hola! Este script se encargará de validar " + limite + " números introducido(s) por el usuario");
do
{
    Console.WriteLine("Introduzca un número entero: ");
    valoresCargados[contador] = int.Parse(Console.ReadLine());

    if (!Validar(valoresCargados[contador], -100, 100))
    {
        if(!flagMaximo) //  para valores maximos
        {
            guardarMaximo = valoresCargados[contador];
            flagMaximo = true;
        }
        else
        {
            guardarMaximo = Evaluar(true, guardarMaximo, valoresCargados[contador]);
        }

        if(!flagMinimo) //  para valores minimos
        {
            guardarMinimo = valoresCargados[contador];
            flagMinimo = true;
        }
        else
        {
            guardarMinimo = Evaluar(false, guardarMinimo, valoresCargados[contador]);
        }
    }

    acumulador += valoresCargados[contador];

    contador++;

} while (contador < limite);

promedio = (float)acumulador / contador;

Console.WriteLine("El valor máximo ingresado es: " + guardarMaximo);
Console.WriteLine("El valor mínimo ingresado es: " + guardarMinimo);
Console.WriteLine("El promedio de valores ingresados es: " + promedio);

//  Funciones
static bool Validar(int valor, int min, int max)
{
    if(valor > min && valor < max)
    {
        return false;
    }
    return true;
}

static int Evaluar(bool modo, int valorAnterior, int valorPosterior)
{
    if(modo == true)    //  si está en TRUE, evalua el mayor
    {
        if(valorPosterior > valorAnterior)
        {
            return valorPosterior;
        }
        else
        {
            return valorAnterior;
        }
    }
    else   //   FALSE evalua el menor
    {
        if(valorPosterior < valorAnterior)
        {
            return valorPosterior;
        }
        else
        {
            return valorAnterior;
        }
    }

}
