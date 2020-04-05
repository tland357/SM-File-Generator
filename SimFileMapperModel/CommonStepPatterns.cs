using System;
using System.Collections.Generic;
using System.Text;
using SimFileMapperModel.Model;
using System.Linq;
using System.Linq.Expressions;

namespace SimFileMapperModel
{
	public class StepPattern 
	{
		const int LEFT = (int)DIRECTION.LEFT;
		const int DOWN = (int)DIRECTION.DOWN;
		const int UP = (int)DIRECTION.UP;
		const int RIGHT = (int)DIRECTION.RIGHT;
		const int BOTH = (int)DIRECTION.BOTH;
		const int EITHER = (int)DIRECTION.EITHER;
		const int LEFTSIDE = (int)DIRECTION.LEFTSIDE;
		const int RIGHTSIDE = (int)DIRECTION.RIGHTSIDE;
		static int[] RIGHTSIDE_LIST = new int[] { RIGHT, UP, DOWN };
		static int[] ALL_LIST = new int[] { RIGHT, UP, DOWN, LEFT };
		static int[] LEFTSIDE_LIST = new int[] { LEFT, UP, DOWN };
		public List<Step> Steps;
		public static List<StepPattern> StartsOnRight = new List<StepPattern>();
		public static List<StepPattern> StartsOnLeft = new List<StepPattern>();
		public static List<StepPattern> StartsOnEither = new List<StepPattern>();
		public static Dictionary<int, List<StepPattern>> StartsWithPos = new Dictionary<int, List<StepPattern>>();
		int StartFoot, StartPosition, EndFoot, EndPosition, SuggestedNextFoot;
		IList<int> SuggestedNextPositions;
		public StepPattern(IList<Step> steps, int startFoot, int endFoot, int suggestedNextFoot, IList<int> suggestedNextPositions)
		{
			StartFoot = startFoot;
			EndFoot = endFoot;
			SuggestedNextFoot = suggestedNextFoot;
			SuggestedNextPositions = suggestedNextPositions;
			StartPosition = steps[0].GetPositioning();
			EndPosition = steps[steps.Count() - 1].GetPositioning();
			Steps = steps.ToList();
			if (startFoot == RIGHT)
			{
				StartsOnRight.Add(this);
			}
			else if (startFoot == LEFT)
			{
				StartsOnLeft.Add(this);
			}
			StartsOnEither.Add(this);
			if (!StartsWithPos.ContainsKey(startFoot))
			{
				List<StepPattern> v = new List<StepPattern>();
				v.Add(this);
				StartsWithPos.Add(startFoot, v);
			}
			else
			{
				StartsWithPos[startFoot].Add(this);
			}
		}
		public StepPattern(IList<int> steps, int startFoot, int endFoot, int suggestedNextFoot, IList<int> SuggestedNextPositions) : this(steps.Select(x => new Step(x)).ToList(), startFoot, endFoot, suggestedNextFoot, SuggestedNextPositions) { }
		public static DIFFICULTY Diff;
		public StepPattern GetNextViablePattern()
		{
			Func<StepPattern, bool> validPosition = x => this.SuggestedNextPositions.Contains(x.StartPosition);
			switch (this.SuggestedNextFoot)
			{
				case RIGHT:
					return StartsOnRight.Where(validPosition).GetRandom();
					break;
				case LEFT:
					return StartsOnLeft.Where(validPosition).GetRandom();
					break;
				default:
					return StartsOnEither.Where(validPosition).GetRandom();
					break;
			}
			switch (Diff)
			{
				case DIFFICULTY.EXTREME:

					goto case DIFFICULTY.EXPERT;
				case DIFFICULTY.EXPERT:

					goto case DIFFICULTY.HARD;
				case DIFFICULTY.HARD:

					goto case DIFFICULTY.MEDIUM;
				case DIFFICULTY.MEDIUM:

					goto default;
				default: //EASY

					break;
			}
			return null;
		}
		public static void CreateStepPatterns()
		{
			//new StepPattern(new Step[] { new Step(RIGHT), new Step(UP), new Step(DOWN), new Step(LEFT) }, RIGHT, LEFT, RIGHT, RIGHTSIDE_LIST);
			//new StepPattern(new Step[] { new Step(RIGHT), new Step(DOWN), new Step(UP), new Step(LEFT) }, RIGHT, LEFT, RIGHT, RIGHTSIDE_LIST);
			//new StepPattern(new Step[] { new Step(RIGHT | UP), new Step(DOWN | RIGHT), new Step(DOWN | LEFT), new Step(UP | LEFT) }, BOTH, BOTH, EITHER, ALL_LIST);
			//new StepPattern(new Step[] { new Step(RIGHT | UP), new Step(LEFT | DOWN) }, BOTH, BOTH, EITHER, ALL_LIST);
			//new StepPattern(new Step[] { new Step(LEFT | UP), new Step(RIGHT | DOWN) }, BOTH, BOTH, EITHER, ALL_LIST);
			//new StepPattern(new Step[] { new Step(LEFT), new Step(RIGHT) }, LEFT, RIGHT, LEFT, LEFTSIDE_LIST);
			//new StepPattern(new Step[] { new Step(LEFT), new Step(UP), new Step(DOWN) }, LEFT, LEFT, RIGHT, new int[] { UP, RIGHT });
			//new StepPattern(new Step[] { new Step(RIGHT) }, RIGHT, RIGHT, LEFT, LEFTSIDE_LIST);
			//new StepPattern(new Step[] { new Step(UP), new Step(DOWN), new Step(RIGHT), new Step(UP), new Step(DOWN), new Step(LEFT) }, RIGHT, LEFT, RIGHT, new int[] { UP, RIGHT });
			//new StepPattern(new Step[] { new Step(UP), new Step(DOWN), new Step(LEFT), new Step(UP), new Step(DOWN), new Step(RIGHT) }, LEFT, RIGHT, LEFT, new int[] { UP, LEFT });
			//new StepPattern(new Step[] { new Step(LEFT), new Step(UP)}, LEFT, RIGHT, LEFT, new int[] { DOWN, LEFT });
			//new StepPattern(new int[] { RIGHT, LEFT, RIGHT, RIGHT }, RIGHT, RIGHT, LEFT, LEFTSIDE_LIST);
			//new StepPattern(new int[] { RIGHT, LEFT, UP, DOWN }, RIGHT, LEFT, RIGHT, new int[] { UP, RIGHT });
			//new StepPattern(new int[] { LEFT, RIGHT, UP, DOWN }, LEFT, RIGHT, LEFT, new int[] { UP, LEFT });
			//new StepPattern(new int[] { RIGHT, LEFT, DOWN, UP }, RIGHT, LEFT, RIGHT, new int[] { DOWN, RIGHT });
			//new StepPattern(new int[] { LEFT, RIGHT, DOWN, UP }, LEFT, RIGHT, LEFT, new int[] { DOWN, LEFT });
			new StepPattern(new int[] { UP }, RIGHT, RIGHT, LEFT, new int[] { LEFT, DOWN });
			new StepPattern(new int[] { UP }, LEFT, LEFT, RIGHT, new int[] { RIGHT, DOWN });
			new StepPattern(new int[] { DOWN }, RIGHT, RIGHT, LEFT, new int[] { LEFT, UP });
			new StepPattern(new int[] { DOWN }, LEFT, LEFT, RIGHT, new int[] { RIGHT, UP });
			new StepPattern(new int[] { RIGHT }, RIGHT, RIGHT, LEFT, LEFTSIDE_LIST);
			new StepPattern(new int[] { LEFT }, LEFT, LEFT, RIGHT, RIGHTSIDE_LIST);
		}
	}
}
