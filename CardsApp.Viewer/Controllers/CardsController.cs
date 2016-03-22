using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CardsApp.Viewer.Controllers
{
	public class CardsController : ApiController
	{
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		public string Get(int id)
		{
			return "value";
		}
	}
}
