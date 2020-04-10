using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
		static HashSet<int> simple48To4 = new  HashSet<int> { 0, 12, 24, 36 };
		static HashSet<int> simple48To8 = new  HashSet<int> { 0, 6, 12, 18, 24, 30, 36, 42 };
		static HashSet<int> simple48To12 = new HashSet<int> { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44 };
		static HashSet<int> simple48To16 = new HashSet<int> { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45 };
		static HashSet<int> simple16To4 = new  HashSet<int> { 0, 4, 8, 12 };
		static HashSet<int> simple16To8 = new  HashSet<int> { 0, 2, 4, 6, 8, 10, 12, 14 };
		static HashSet<int> simple12To4 = new  HashSet<int> { 0, 3, 6, 9 };
		static HashSet<int> simple8To4 = new   HashSet<int> { 0, 2, 4, 6 };
		public bool Filter(ICollection<int> indices)
		{
			return Steps.SkipIndices(indices).All(x => x == null);
		}
		public string ToArrow()
		{
			Step[] steps = Steps;
			StringBuilder builder = new StringBuilder("");
			switch (steps.Length)
			{
				case 48:
					if (Filter(simple48To4))
					{
						steps = steps.PickIndices(simple48To4).ToArray();
					}
					else if (Filter(simple48To8))
					{
						steps = steps.PickIndices(simple48To8).ToArray();
					}
					else if (Filter(simple48To12))
					{
						steps = steps.PickIndices(simple48To12).ToArray();
					}
					else if (Filter(simple48To16))
					{
						steps = steps.PickIndices(simple48To16).ToArray();
					}
					break;
				case 16:
					if (Filter(simple16To4))
					{
						steps = steps.PickIndices(simple16To4).ToArray();
					}
					else if (Filter(simple16To8))
					{
						steps = steps.PickIndices(simple16To8).ToArray();
					}
					break;
				case 12:
					if (Filter(simple12To4))
					{
						steps = steps.PickIndices(simple12To4).ToArray();
					}
					break;
				case 8:
					if (Filter(simple8To4))
					{
						steps = steps.PickIndices(simple8To4).ToArray();
					}
					break;
			}
			foreach (Step step in steps)
			{
				if (step == null)
				{
					builder.AppendLine("    ");
				}
				else
				{
					builder.AppendLine(step.ToArrows());
				}
			}
			return builder.ToString();
		}
		public override string ToString()
		{
			Step[] steps = Steps;
			StringBuilder builder = new StringBuilder("");
			switch (steps.Length)
			{
				case 48:
					if (Filter(simple48To4))
					{
						steps = steps.PickIndices(simple48To4).ToArray();
					}
					else if (Filter(simple48To8))
					{
						steps = steps.PickIndices(simple48To8).ToArray();
					}
					else if (Filter(simple48To12))
					{
						steps = steps.PickIndices(simple48To12).ToArray();
					}
					else if (Filter(simple48To16))
					{
						steps = steps.PickIndices(simple48To16).ToArray();
					}
					break;
				case 16:
					if (Filter(simple16To4))
					{
						steps = steps.PickIndices(simple16To4).ToArray();
					}
					else if (Filter(simple16To8))
					{
						steps = steps.PickIndices(simple16To8).ToArray();
					}
					break;
				case 12:
					if (Filter(simple12To4))
					{
						steps = steps.PickIndices(simple12To4).ToArray();
					}
					break;
				case 8:
					if (Filter(simple8To4))
					{
						steps = steps.PickIndices(simple8To4).ToArray();
					}
					break;
			}
			foreach (Step step in steps)
			{
				if (step == null)
				{
					builder.AppendLine("0000");
				} else
				{
					builder.AppendLine(step.ToString());
				}
			}
			return builder.ToString();
		}
	}
}
