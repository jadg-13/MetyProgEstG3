using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1.modelos
{
    internal class Operacion
    {
        public int ObtenerMayor(int num1 , int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }else if(num2 > num1)
            {
                return num2;
            }
            else
            {
                Console.WriteLine("Ambos numeros son iguales");
                return 0;
            }
        }
    }
}
