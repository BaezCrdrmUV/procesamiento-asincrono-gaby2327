using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesamientoAsincrono
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numero;
            int numeroUsuario;

            Console.WriteLine("--- NUMEROS PRIMOS ---");
            Console.WriteLine("Ingresa un número: ");
            numero = Console.ReadLine();
            numeroUsuario = int.Parse(numero);
            procesoAsincrono(numeroUsuario);
            Console.WriteLine("Para salir presiona cualquier tecla.");
            Console.ReadKey();
        }

        static async Task procesoAsincrono(int numero)
        {
            int resultado;
            resultado = await cuentaPrimos(numero);
            Console.WriteLine(resultado);
            Console.WriteLine("----------------------");
        }

        public static async Task<int> cuentaPrimos(int numero)
        {
            int resultado;
            resultado = await Task.Run(() =>
            {
                int contador;
                int contadorNumero = 0;
                {
                    for(contador = 0; contador <= numero; contador++)
                    {
                        if(esPrimo(contador))
                        {
                            contadorNumero++;
                        }
                    }
                }
                return contadorNumero;
            });
            return resultado;
        }

        public static bool esPrimo(int numero)
        {
            if(numero < 2)
            {
                return false;
            }

            if(numero == 2)
            {
                return true;
            }

            if(numero % 2 == 0)
            {
                return false;
            }

            int contador = 3;

            while ((contador * contador <= numero))
            {
                if (numero % contador == 0)
                {
                    return false;
                }else
                {
                    contador++;
                }
            }
            return true;
        }
    }
}
