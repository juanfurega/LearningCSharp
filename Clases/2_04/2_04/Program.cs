namespace Calculadora
{
    class Script
    {
        static void Main(String[] args)
        {
            char input;
            string s_operando1;
            string s_operando2;
            float operando1;
            float operando2;
            float resultado;

            Console.WriteLine("CALCULADORA");

            do
            {
                Console.WriteLine("Posee las siguientes operaciones (oprima el símbolo correcto)\n" +
                    "'+' Suma\n'-' Resta\n'*' Multiplicación\n'/' División");
                ConsoleKeyInfo keyInfo = Console.ReadKey(); //  lee un caracter sin que se presione enter
                input = keyInfo.KeyChar;
                Console.Write("\n");

            } while (input != '+' && input != '-' && input != '*' && input != '/');

            switch (input)
            {
                case '+':
                    Console.WriteLine("Seleccionaste la opción SUMA");
                    break;

                case '-':
                    Console.WriteLine("Seleccionaste la opción RESTA");
                    break;

                case '*':
                    Console.WriteLine("Seleccionaste la opción MULTIPLICACIÓN");
                    break;

                case '/':
                    Console.WriteLine("Seleccionaste la opción DIVISIÓN");
                    break;
            }

            do
            {
                Console.WriteLine("Inserte el primer número");
                s_operando1 = Console.ReadLine();
            } while (!float.TryParse(s_operando1, out operando1));

            do
            {
                Console.WriteLine("Inserte el segundo número");
                s_operando2 = Console.ReadLine();
            } while (!float.TryParse(s_operando2, out operando2));

            if (input == '/' && operando2 == 0)
            {
                Console.WriteLine("No es posible dividir por cero");
            }
            else
            {
                resultado = Calculadora.Calcular(operando1, operando2, input);
                Console.WriteLine("La operación es: " + operando1 + input + operando2 + " = " + resultado);
            }
        }

        public class Calculadora
        {
            public static float Calcular(float operando_1, float operando_2, char type)
            {
                float resultado = 0;
   
                switch(type)
                {
                    case '+':   //SUMA
                        resultado = operando_1 + operando_2;
                        break;

                    case '-':   //RESTA
                        resultado = operando_1 - operando_2;
                        break;

                    case '*':   //MULTIPLICACION
                        resultado = operando_1 * operando_2;
                        break;

                    case '/':   //DIVISION
                        bool validacion = Validar(operando_2);

                        if(validacion) 
                        {
                            resultado = operando_1 / operando_2;
                        }
                        break;
                }

                return resultado;
            }

            private static bool Validar(float operando_2)
            {
                if(operando_2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }
    }
}

