namespace FlooringCalculator
{
    internal class Program
    {
        const int LABOUR_COST_PER_HOUR = 86;
        const int FLOORING_PRE_HOUR = 20;
        const double PI = Math.PI;

        static void Main(string[] args)
        {
            string floorShape = "";
            string floorWidth = "";
            string floorLength = "";
            string floorRadius = "";
            string tileUnitCost = "";
            int convertedFloorWidth = 0;
            int convertedFloorLength = 0;
            int convertedFloorRadius = 0;
            double convertedUnitCost = 0;
            double floorSize = 0;

            // Header section
            Console.WriteLine("\t\t\tWELCOME");
            Console.WriteLine("\t\t  Flooring Calculator");
            Console.WriteLine("==========================================================\n");

            // User input of section
            Console.WriteLine("Enter details about your room and tile cost:");
            Console.Write("\t - Room Shape (Rect or Circ):\t");
            floorShape = Console.ReadLine();

            if (floorShape == "Rect")
            {
                Console.Write("\t - Width:\t");
                floorWidth = Console.ReadLine();
                Console.Write("\t - Length:\t");
                floorLength = Console.ReadLine();
            }
            else
            {
                Console.Write("\t - Radius:\t");
                floorRadius = Console.ReadLine();
            }
            Console.Write("\t - Unit Cost:\t");
            tileUnitCost = Console.ReadLine();


            // Write user input 
            Console.WriteLine("\nYou entered the following values...");
            if (floorShape == "Rect")
            {
                Console.WriteLine($"\tRectangular room / W: {floorWidth} / L: {floorLength} / UC: {tileUnitCost}\n");
            }
            else
            {
                Console.WriteLine($"\tCircular room / R: {floorRadius} / UC: {tileUnitCost}\n");
            }

            // Convert text to numbers (assuming correct input for now)
            if (floorShape == "Rect")
            {
                convertedFloorWidth = Int32.Parse(floorWidth);
                convertedFloorLength = Int32.Parse(floorLength);
            }
            else
            {
                convertedFloorRadius = Int32.Parse(floorRadius);
            }
            convertedUnitCost = Convert.ToDouble(tileUnitCost);

            // Calculate floring totals
            if (floorShape == "Rect")
            {
                floorSize = convertedFloorWidth * convertedFloorLength;
            }
            else
            {
                floorSize = PI * (convertedFloorRadius * convertedFloorRadius);
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