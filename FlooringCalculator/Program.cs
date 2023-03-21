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
            Console.WriteLine("Please enter the following details to calculate the flooring costs... (whole numbers only please)");
            Console.Write("\t - Width: ");
            string floorWidth = Console.ReadLine();
            Console.Write("\t - Length: ");
            string floorLength = Console.ReadLine();
            Console.Write("\t - Unit Cost:  ");
            string tileUnitCost = Console.ReadLine();

            // Write user input 
            Console.WriteLine("\n\tYou entered the following values...");
            Console.WriteLine($"\tW: {floorWidth} / L: {floorLength} / UC: {tileUnitCost}");

            //Convert text to numbers
            int convertedFloorWidth = Int32.Parse(floorWidth);
            int convertedFloorLength = Int32.Parse(floorLength);
            int convertedUnitCost = Int32.Parse(tileUnitCost);

            Console.WriteLine($"\n\tTotal Cost for flooring is {convertedFloorWidth * convertedFloorLength * convertedUnitCost}");

        }
    }
}