namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a temperature in F degrees to be converted to C degrees:");
            double fTemp = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(TempConverter.FahrenheitToCelsius(fTemp), 1));
            Console.WriteLine();




            Console.WriteLine("Give a temperature in C degrees to be converted to F degrees:");
            double cTemp = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(TempConverter.CelsiusToFahrenheit(cTemp), 1));


        }
    }
}
