using UseIf.models;

namespace UseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es niño , joven o adulto
            /*
             * Niño: 0 - 12
             * joven: 13 - 25
             * adulto: 26 a mas.
             **/
            int edad = 0;
            Evaluate evaluate = new Evaluate();
            Console.WriteLine("Evaluar edad");
            Console.Write("Ingresa tu edad: ");
            try
            {
                edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(evaluate.EvalAge(edad));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            

        }
    }
}
