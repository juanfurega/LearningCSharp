int anioInicio;
int anioFin;
int anioViciesto;
string input;

Console.WriteLine("Introduce el año a partir de cual iterar: ");    //  valido año de inicio
input = Console.ReadLine();

while(!int.TryParse(input, out anioInicio) || anioInicio < 0)
{
    Console.WriteLine("¡ERROR! Vuelve a introducir un año válido");
    input = Console.ReadLine();
}

Console.WriteLine("Introduce el año hasta cual iterar: ");  //  valido año fin
input = Console.ReadLine();

while (!int.TryParse(input, out anioFin) || anioFin < 0 || anioInicio >= anioFin)
{
    Console.WriteLine("¡ERROR! Vuelve a introducir un año válido");

    if(anioInicio >= anioFin)
    {
        Console.WriteLine("(recordá que el año hasta el cual se itera no debe ser menor o igual al desde cual se inicia)");
    }
    input = Console.ReadLine();
}

for(int i = anioInicio; i <= anioFin; i++)
{
    anioViciesto = i % 100; //  si es divisible por 100 puede NO ser biciesto

    if(anioViciesto == .0)
    {
        anioViciesto = i % 400; //  si es divisible por 400 es biciesto

        if(anioViciesto == .0)
        {
            Console.WriteLine(i + " es un año viciesto");
        }
    }
    else
    {
        anioViciesto = i % 4;   //  si no es divisible por 100 pero si por 4 es biciesto

        if(anioViciesto == .0)
        {
            Console.WriteLine(i + " es un año viciesto");
        }
    }
}