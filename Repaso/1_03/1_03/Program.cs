string inputUsuario;
string inputCiclo;
bool operar = true;
float numeroIngresado;
float flagNumeroPrimo;
int j = 1;
int contador = 0;

do
{
    Console.WriteLine("Ingrese un número o la palabra 'salir'");
    inputUsuario = Console.ReadLine();

    //  validación de datos
    if(inputUsuario.ToLower() == "salir")
    {
        operar = false;
        continue; //continue salta al principio del bucle sin ejecutar el codigo restante
    }

    if(!float.TryParse(inputUsuario, out numeroIngresado))
    {
        Console.WriteLine("¡El número ingresado no es valido! Vuelve a intentarlo");
        continue;
    }

    //  operacion con números primos

    if(numeroIngresado < -1 || numeroIngresado > 1)
    {
        Console.WriteLine("El/Los números primos anteriores al ingresado son:");
    }
    else
    {
        Console.WriteLine("No hay números primos");
    }

    if (numeroIngresado > 0)    //  positivos
    {
        for (int i = 1; i <= numeroIngresado; i++)
        {
            for (j = 1; j <= i; j++)
            {
                flagNumeroPrimo = i % j; // busco el resto

                if (flagNumeroPrimo == .0 || flagNumeroPrimo == i)   // si cumple alguna de estas condiciones suma al contador
                {
                    contador++;
                }
            }

            if (contador == 2)   //  si el contador da 2, es un número primo
            {
                Console.WriteLine(i);
            }

            j = 1;  //  termina la iteracion y reinicio los contadores 
            contador = 0;
        }
    }
    else
    {
        for (int i = -1; i >= numeroIngresado; i--)  //  negativos
        {
            for (j = -1; j >= i; j--)
            {
                flagNumeroPrimo = i % j; // busco el resto

                if (flagNumeroPrimo == .0 || flagNumeroPrimo == i)   // si cumple alguna de estas condiciones suma al contador
                {
                    contador++;
                }
            }

            if (contador == 2)   //  si el contador da 2, es un número primo
            {
                Console.WriteLine(i);
            }

            j = -1;  //  termina la iteracion y reinicio los contadores 
            contador = 0;
        }
    }

    Console.WriteLine("¿Desea voler a realizar la operación? (si/no)");
    inputCiclo = Console.ReadLine();
    inputCiclo.ToLower();

    while(inputCiclo != "no" && inputCiclo != "si")
    {
        Console.WriteLine("¡ERROR! ¡Ha introducido un comando inválido\n¿Desea voler a realizar la operación? (si/no)");
        inputCiclo = Console.ReadLine();
        inputCiclo.ToLower();
    }

    if (inputCiclo == "no")
    {
        Console.WriteLine("¡Hasta pronto!");
        operar = false;
    }
    else
    {
        Console.WriteLine("Usted ha elegido la opción (si)\n");
    }

} while (operar);