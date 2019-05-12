using System;
using System.Linq;

namespace WorkTimeCalculator
{
	public class Utils
	{
		public static decimal FindLcm(decimal[] tempArr)
		{
			decimal lcm = 1;
			var divisor = 2;
			while (true)
			{
				var cnt = 0;
				var divisible = false;
				for (var i = 0; i < tempArr.Length; i++)
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

					if (tempArr[i] % divisor != 0) continue;
					divisible = true;
					tempArr[i] = tempArr[i] / divisor;
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
		public static decimal MinutesCalculation(decimal[] totalNoOfMinutesWorkedByPeople)
		{
			var tempArray = new decimal[totalNoOfMinutesWorkedByPeople.Length];
			var lcmArray = new decimal[totalNoOfMinutesWorkedByPeople.Length];

			Array.Copy(totalNoOfMinutesWorkedByPeople, lcmArray, totalNoOfMinutesWorkedByPeople.Length);
			var lcm = FindLcm(lcmArray);

			for (var i = 0; i <= totalNoOfMinutesWorkedByPeople.Length - 1; i++)
			{
				tempArray[i] = lcm / totalNoOfMinutesWorkedByPeople[i];
			}

			return decimal.Divide(lcm, tempArray.Sum());
		}
	}
}
