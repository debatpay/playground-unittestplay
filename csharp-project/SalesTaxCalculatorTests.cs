﻿﻿using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.IO;

namespace TechIo
{
    [TestClass]
    public class SalesTaxCalculatorTests
    {
	private bool shouldShowHint = false;
	[TestMethod]
	public void VerifyTotalPrice() 
	{
		shouldShowHint = true;
		Assert.AreEqual (105.00m,   SalesTaxCalculatorStub.GetTotalAmount(100.00m, 5));
		Assert.AreEqual (2.14m,   SalesTaxCalculatorStub.GetTotalAmount(2.00m, 7));
		Assert.AreEqual (4.26m,   SalesTaxCalculatorStub.GetTotalAmount (4.00m, 6.5m));
		shouldShowHint = false;
	}

	[TestCleanup()]
      	public void Cleanup()
      	{		
		if(shouldShowHint)
		{	
			// On Failure
			PrintMessage("Hint 💡", "Did you properly divide the tax to get a 0.nn format decimal number? 🤔");
		} 
		else
		{
 			
				PrintMessage("My personal Yoda, you are. 🙏", "* ● ¸ .　¸. :° ☾ ° 　¸. ● ¸ .　　¸.　:. • ");
				PrintMessage("My personal Yoda, you are. 🙏", "           　★ °  ☆ ¸. ¸ 　★　 :.　 .   ");
				PrintMessage("My personal Yoda, you are. 🙏", "__.-._     ° . .　　　　.　☾ ° 　. *   ¸ .");
				PrintMessage("My personal Yoda, you are. 🙏", "'-._\\7'      .　　° ☾  ° 　¸.☆  ● .　　　");
				PrintMessage("My personal Yoda, you are. 🙏", " /'.-c    　   * ●  ¸.　　°     ° 　¸.    ");
				PrintMessage("My personal Yoda, you are. 🙏", " |  /T      　　°     ° 　¸.     ¸ .　　  ");
				PrintMessage("My personal Yoda, you are. 🙏", "_)_/LI");
			
		}
      	}


	/****
		TOOLS
	*****/
	// Display a custom message in a custom channel
	private static void PrintMessage(String channel, String message)
	{		
		Console.WriteLine ($"TECHIO> message --channel \"{channel}\" \"{message}\"");
	}
	// You can manually handle the success/failure of a testcase using this function
	private static void Success(Boolean success)
	{
		Console.WriteLine($"TECHIO> success {success}");
	}
	// Check the user code looking for a keyword
	private static Boolean ExistsInFile(String path, String keyword) 
	{
		return File.ReadAllText(path).Contains(keyword);
	}
    }
}
