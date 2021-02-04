using System;

namespace SalariosGenero1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Variables

            int Cantidadhombres = 0;
            int cantidadmujeres = 0;

           
            // proceso 

            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine(" por favor ingrese el numero de folio");
                Console.ReadLine();

                Console.WriteLine(" por favor ingrese el sueldo que gana");
                double sueldo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" por favor ingrese el sexo, 1 para fenenino, 2 para masculino ");
                int genero = Convert.ToInt32(Console.ReadLine());

                if (genero == 2 && sueldo >= 900000)
                {
                    cantidadmujeres += 1;
                }

                else if (genero == 1 && sueldo <= 1000000)
                {
                    Cantidadhombres += 1;
                }
            }

           // salida 
            
            Console.WriteLine("la cantidad de mujeres que ganan mas de 900 mil son :" + cantidadmujeres);
            Console.WriteLine(" la cantidad de hobres que ganan menos de un millon de peos son :" + Cantidadhombres);

        }
    }
}
