namespace FlooringCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Header section
            Console.WriteLine("\t\t\tWELCOME");
            Console.WriteLine("\t\t  Flooring Calculator");
            Console.WriteLine("==========================================================\n");

            //User input of section
            Console.WriteLine("Enter the following details to calculate the flooring costs... \n(whole numbers only please)");
            Console.Write("\t - Width: ");
            string floorWidth = Console.ReadLine();
            Console.Write("\t - Length: ");
            string floorLength = Console.ReadLine();
            Console.Write("\t - Unit Cost:  ");
            string tileUnitCost = Console.ReadLine();

            // Write user input 
            Console.WriteLine("\n\tYou entered the following values...");
            Console.WriteLine($"\tW: {floorWidth} / L: {floorLength} / UC: {tileUnitCost}");

            //Convert text to numbers (assuming correct input for now)
            int convertedFloorWidth = Int32.Parse(floorWidth);
            int convertedFloorLength = Int32.Parse(floorLength);
            int convertedUnitCost = Int32.Parse(tileUnitCost);

            //Calculate totals
            int totalCost = convertedFloorWidth * convertedFloorLength * convertedUnitCost;
            Console.WriteLine($"\n\tTotal Cost for flooring is {totalCost}");
            Console.WriteLine("\n==========================================================\n");
        }
    }
}