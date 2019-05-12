using System;
using static System.Console;

namespace WorkTimeCalculator
{
	public class Program
    {
        static void Main()
        {
            WriteLine("Enter the Number of images to be work(Must be greater than Zero) : ");
            var noOfImages = Convert.ToInt32(ReadLine());
	       	  
            WriteLine("Enter the Number People working : ");
            var noOfPeople = Convert.ToInt32(ReadLine());
	      
			var totalNoOfMinutesWorkedByPeople = new decimal[noOfPeople];

	        for (var i = 0; i <= noOfPeople - 1; i++)
            {
                WriteLine($"Enter the Number of minutes need by Person { i + 1 } per image (Must be greater than Zero)  : ");
				totalNoOfMinutesWorkedByPeople[i] = Convert.ToDecimal(ReadLine()) * noOfImages;

            }

	        var minutes = noOfPeople > 0 ? Utils.MinutesCalculation(totalNoOfMinutesWorkedByPeople) : 0;


	        if (minutes > 0)
		        WriteLine($"Total Required Minutes :  {minutes}");
	        else
		        WriteLine("Total Required Minutes :" + double.PositiveInfinity);

	        ReadLine();
        }
		
    }
}
