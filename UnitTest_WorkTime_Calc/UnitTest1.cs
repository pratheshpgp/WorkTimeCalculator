using System;
using WorkTimeCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_WorkTime_Calc
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestLcm()
		{
			//Arrange
			var testArray = new Decimal[] {2, 3, 4};

			//Act
			var output = Utils.FindLcm(testArray);

			//Assert
			Assert.AreEqual(output, 12);
		}

		[TestMethod]
		public void TestWorkTime()
		{
			//Arrange
			var noOfImg = 6;
			var noOfple = 3;
			var p1TimekeeperImage = 1;
			var p2TimekeeperImage = 1;
			var p3TimekeeperImage = 1;
			var testArray = new Decimal[] { p1TimekeeperImage * noOfImg, p2TimekeeperImage * noOfImg, p3TimekeeperImage * noOfImg };
            
			//Act
			var output = Utils.MinutesCalculation(testArray);

			//Assert
			Assert.AreEqual(output, 2);
		}
	}
}
