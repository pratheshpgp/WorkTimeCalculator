using System;
using System.Linq;

namespace WorkTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of images to be work : ");
            int NoOfImages = Convert.ToInt32(Console.ReadLine());

	  
            Console.WriteLine("Enter the Number People working : ");
            int NoOfPeople = Convert.ToInt32(Console.ReadLine());


            int[] TotalNoOfMinutesWorkedByPeople = new int[NoOfPeople];

            for (int i = 0; i <= NoOfPeople - 1; i++)
            {
                Console.WriteLine($"Enter the Number of minutes need by Person { i + 1 } per image : ");
                TotalNoOfMinutesWorkedByPeople[i] = Convert.ToInt32(Console.ReadLine()) * NoOfImages;

            }

            double minutes = MinutesCalculation(TotalNoOfMinutesWorkedByPeople);


            Console.WriteLine("Total Required Minutes : " + minutes);

            Console.ReadLine();
        }

		private static double MinutesCalculation(int[] totalNoOfMinutesWorkedByPeople)
		{
			long[] tempArray = new long[totalNoOfMinutesWorkedByPeople.Length];
			int[] lcmArray = new int[totalNoOfMinutesWorkedByPeople.Length];

			Array.Copy(totalNoOfMinutesWorkedByPeople, lcmArray, totalNoOfMinutesWorkedByPeople.Length);
			long LCM = findLCM(lcmArray);

			for (int i = 0; i <= totalNoOfMinutesWorkedByPeople.Length - 1; i++)
			{
				tempArray[i] = LCM / totalNoOfMinutesWorkedByPeople[i];
			}

			return LCM / tempArray.Sum();
		}

		private static long findLCM(int[] tempArr)
		{
			long lcm = 1;
			int divisor = 2;
			while (true)
			{
				int cnt = 0;
				bool divisible = false;
				for (int i = 0; i < tempArr.Length; i++)
				{				
					if (tempArr[i] == 0)
					{
						return 0;
					}
					else if (tempArr[i] < 0)
					{
						tempArr[i] = tempArr[i] * (-1);
					}
					if (tempArr[i] == 1)
					{
						cnt++;
					}

					if (tempArr[i] % divisor == 0)
					{
						divisible = true;
						tempArr[i] = tempArr[i] / divisor;
					}
				}
				if (divisible)
				{
					lcm = lcm * divisor;
				}
				else
				{
					divisor++;
				}
		
				if (cnt == tempArr.Length)
				{
					return lcm;
				}
			}
		}

    }
}
