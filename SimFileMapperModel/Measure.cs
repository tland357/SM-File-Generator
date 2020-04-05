using System;
using System.Collections.Generic;
using System.Text;

namespace SimFileMapperModel.Model
{
	public class Measure
	{
		public static int Resolution = 48;
		public Step[] Steps;
		public Measure()
		{
			Steps = new Step[Resolution];
		}
	}
}
