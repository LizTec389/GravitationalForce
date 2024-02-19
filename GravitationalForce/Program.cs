namespace FormulaFisica
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double mass1 = 10.0;
            double mass2 = 5.0; 
            double distance = 3.0;
           
            double G = 6.67430e-11;

            //Gravitational Force Formula : F = G * (m1 * m2) / r^2
            double fuerza = G * (mass1 * mass2) / Math.Pow(distance, 2);

         
            Console.WriteLine($"La fuerza gravitacional entre los objetos es {fuerza} newtons.");
        }
    }
}