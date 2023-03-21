namespace FlooringCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Header section
            Console.WriteLine("\t\tWELCOME");
            Console.WriteLine("\t  Flooring Calculator");
            Console.WriteLine("=======================================\n");

            //User input of section
            Console.WriteLine("Please enter the following details to calculate the flooring costs...");
            Console.Write("\t - Width: ");
            string floorWidth = Console.ReadLine();
            Console.Write("\t - Length: ");
            string floorLength = Console.ReadLine();
            Console.Write("\t - Unit Cost:  ");
            string tileUnitCost = Console.ReadLine();

            // Write user input 
            Console.WriteLine($"W: {floorWidth} / L: {floorLength} / UC: {tileUnitCost}");
        }
    }
}