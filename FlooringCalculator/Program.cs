﻿namespace FlooringCalculator
{
    internal class Program
    {
        const int LABOUR_COST_PER_HOUR = 86;
        const int FLOORING_PRE_HOUR = 20;
        
        static void Main(string[] args)
        {
            //Header section
            Console.WriteLine("\t\t\tWELCOME");
            Console.WriteLine("\t\t  Flooring Calculator");
            Console.WriteLine("==========================================================\n");

            //User input of section
            Console.WriteLine("Enter the following details to calculate the flooring costs... \n(whole numbers only please)");
            Console.Write("\t - Width:\t");
            string floorWidth = Console.ReadLine();
            Console.Write("\t - Length:\t");
            string floorLength = Console.ReadLine();
            Console.Write("\t - Unit Cost:\t");
            string tileUnitCost = Console.ReadLine();

            // Write user input 
            Console.WriteLine("\nYou entered the following values...");
            Console.WriteLine($"\tW: {floorWidth} / L: {floorLength} / UC: {tileUnitCost}\n");

            //Convert text to numbers (assuming correct input for now)
            int convertedFloorWidth = Int32.Parse(floorWidth);
            int convertedFloorLength = Int32.Parse(floorLength);
            int convertedUnitCost = Int32.Parse(tileUnitCost);

            //Calculate totals
            int roomSize = convertedFloorWidth * convertedFloorLength;
            int flooringCost = roomSize * convertedUnitCost;
            Console.WriteLine($"Costs breakdown...");
            Console.WriteLine($"\tCost for flooring:\t{flooringCost}");

            //Bonus stage: caclulation for non rectangular rooms


            //Bonus stage: calculate total cost including cost per hour
            decimal workUnits = (decimal)roomSize / FLOORING_PRE_HOUR;
            decimal labourCost = (decimal)workUnits * LABOUR_COST_PER_HOUR;
            
            Console.WriteLine($"\tCost for Labour:\t{labourCost}");


            Console.WriteLine($"\n\tTotal Cost:\t\t{flooringCost + labourCost}");
            Console.WriteLine("\n==========================================================\n");
        }
    }
}