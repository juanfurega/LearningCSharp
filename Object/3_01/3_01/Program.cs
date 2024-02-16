using System.Reflection.Emit;

namespace SistemaBancario
{
  public class Program
    {
        static void Main(string[] args) 
        {
            Cuenta usuario1 = new Cuenta();

            //  parametros iniciales
            usuario1.titular = "Juan";
            usuario1.cantidad = 10000;

            //  muestro parametros iniciales
            string infoUsuario = usuario1.getTitular();
            Console.WriteLine(infoUsuario);

            float saldoUsuario = usuario1.getCantidad();
            Console.WriteLine(saldoUsuario);

            //  modifico
            usuario1.Ingresar(10000);
            usuario1.Retirar(30000);
            
            //  output esperado: -10000
            usuario1.Mostrar();
        }
    }
    public class Cuenta
    {
        public string titular;
        public float cantidad;

        public Cuenta() //  constructor
        {
            titular = "";
            cantidad = 0;
        }

        public string getTitular()  //  getter titular
        {
            return titular;
        }

        public float getCantidad()  //  getter cantidad
        {
            return cantidad;
        }

        public void Mostrar()   //  muestro datos
        {
            Console.WriteLine("Usuario: {0}\nDinero: {1}", titular, cantidad);
        }

        public void Ingresar(float monto)   //  ingreso
        {
            if(monto > 0) 
            {
                cantidad += monto;
            }
        }

        public void Retirar(float monto)    //  retiro
        {
            cantidad -= monto;
        }
    }
}