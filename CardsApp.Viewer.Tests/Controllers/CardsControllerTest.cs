using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardsApp.Viewer;
using CardsApp.Viewer.Controllers;

namespace CardsApp.Viewer.Tests.Controllers
{
	[TestClass]
	public class CardsControllerTest
	{
		[TestMethod]
		public void Get()
		{
			// Arrange
			CardsController controller = new CardsController();

			// Act
			IEnumerable<string> result = controller.Get();

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(2, result.Count());
			Assert.AreEqual("value1", result.ElementAt(0));
			Assert.AreEqual("value2", result.ElementAt(1));
		}

		[TestMethod]
		public void GetById()
		{
			// Arrange
			CardsController controller = new CardsController();

			// Act
			string result = controller.Get(5);

			// Assert
			Assert.AreEqual("value", result);
		}
	}
}
