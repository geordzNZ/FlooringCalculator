namespace FlooringCalculator
{
    internal class Program
    {
        const int LABOUR_COST_PER_HOUR = 86;
        const int FLOORING_PRE_HOUR = 20;

        static void Main(string[] args)
        {
            string tileUnitCost = "";
            double convertedUnitCost = 0;
            double floorSize = 0;


            // Header section
            Console.WriteLine("\t\t\tWELCOME");
            Console.WriteLine("\t\t  Flooring Calculator");
            Console.WriteLine("==========================================================\n");

            // User input  - Room shape
            Console.WriteLine("Enter details about your room and tile cost:");
            Console.WriteLine("\tChoose room shape from the following list:");
            Console.WriteLine("\t\tRectangle = R or r");
            Console.WriteLine("\t\tCircle = C or c");
            Console.Write("\t - Room Shape:\t");
            string floorShape = Console.ReadLine();
            floorShape = floorShape.ToUpper();

            if (floorShape == "R")
            {
                // User input  - Room dimensions and costs
                Console.Write("\t - Width:\t");
                string floorWidth = Console.ReadLine();
                Console.Write("\t - Length:\t");
                string floorLength = Console.ReadLine();

                Console.Write("\t - Unit Cost:\t");
                tileUnitCost = Console.ReadLine();

                // Write user input
                Console.WriteLine("\nYou entered the following values...");
                Console.WriteLine($"\tRectangular room / W: {floorWidth} / L: {floorLength} / UC: {tileUnitCost}\n");

                // Convert text to numbers (assuming correct input for now)
                int convertedFloorWidth = Int32.Parse(floorWidth);
                int convertedFloorLength = Int32.Parse(floorLength);
                convertedUnitCost = Convert.ToDouble(tileUnitCost);

                // Calculate floring totals
                floorSize = convertedFloorWidth * convertedFloorLength;

            }
            else
            {
                // User input  - Room dimensions and costs
                Console.Write("\t - Radius:\t");
                string floorRadius = Console.ReadLine();

                Console.Write("\t - Unit Cost:\t");
                tileUnitCost = Console.ReadLine();

                // Write user input 
                Console.WriteLine("\nYou entered the following values...");
                Console.WriteLine($"\tCircular room / R: {floorRadius} / UC: {tileUnitCost}\n");

                // Convert text to numbers (assuming correct input for now)
                int convertedFloorRadius = Int32.Parse(floorRadius);
                convertedUnitCost = Convert.ToDouble(tileUnitCost);

                // Calculate floring totals
                floorSize = Math.PI * (convertedFloorRadius * convertedFloorRadius);
            }

            double flooringCost = floorSize * convertedUnitCost;
            Console.WriteLine($"Costs breakdown...");
            Console.WriteLine($"\tCost for flooring:\t{flooringCost.ToString("0.00")}");

            // Bonus stage: calculate total cost including cost per hour
            double workUnits = (double)floorSize / FLOORING_PRE_HOUR;
            double labourCost = (double)workUnits * LABOUR_COST_PER_HOUR;
            
            Console.WriteLine($"\tCost for Labour:\t{labourCost.ToString("0.00")}");


            Console.WriteLine($"\n\tTotal Cost:\t\t{(flooringCost + labourCost).ToString("0.00")}");
            Console.WriteLine("\n==========================================================\n");
        }
    }
}