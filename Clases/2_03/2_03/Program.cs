using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
static string ConvertirDecimalABinario(int numeroEntero) 
{
    int unidades = 0;
    int decenas = 0;
    int centenas = 0;
    int unMil = 0;
    int deMil = 0;
    int ceMil = 0;
    int unMillon = 0;
    int deMillon = 0;

    if(numeroEntero < 0 || numeroEntero > 255)
    {
        Console.WriteLine("¡ERROR! El número ingresado no es válido (MAX 255)");
        return "0";
    }

    for(int i = 0; i < numeroEntero; i++)
    {
        unidades++;

        if(unidades > 1)
        {
            unidades = 0;
            decenas++;

            if(decenas > 1)
            {
                decenas = 0;
                centenas++;

                if(centenas > 1)
                {
                    centenas = 0;
                    unMil++;

                    if(unMil > 1)
                    {
                        unMil = 0;
                        deMil++;

                        if(deMil > 1)
                        {
                            deMil = 0;
                            ceMil++;

                            if(ceMil > 1)
                            {
                                ceMil = 0;
                                unMillon++;

                                if(unMillon > 1)
                                {
                                    unMillon = 0;
                                    deMillon++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    string s_unidades = unidades.ToString();
    string s_decenas = decenas.ToString();
    string s_centenas = centenas.ToString();
    string s_unMil = unMil.ToString();
    string s_deMil = deMil.ToString();
    string s_ceMil = ceMil.ToString();
    string s_unMillon = unMillon.ToString();
    string s_deMillon = deMillon.ToString();

    string retorno = (s_deMillon + s_unMillon + s_ceMil + s_deMil + s_unMil + s_centenas + s_decenas + s_unidades);

    return retorno;
}