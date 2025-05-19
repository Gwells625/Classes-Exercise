namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Toyota";
            carOne.Model = "Tacoma";
            carOne.Year = 2018;
            
            Console.WriteLine($"This is a {carOne.Make} {carOne.Model}, made in the year {carOne.Year}.");
        }
    }
}
