using System;
using System.Collections.Generic;
using System.Text;

namespace SimFileMapperModel.Model
{

	public class Step
	{
		
		string Buttons;
		int Holding = 0;
		public Step(string btns)
		{
			
			Buttons = btns.ToSteps();
		}
		public Step(int pattern)
		{
			Buttons = "";
			if ((pattern & (int)DIRECTION.LEFT) != 0) Buttons += '1';
			else Buttons += '0';
			if ((pattern & (int)DIRECTION.DOWN) != 0) Buttons += '1';
			else Buttons += '0';
			if ((pattern & (int)DIRECTION.UP) != 0) Buttons += '1';
			else Buttons += '0';
			if ((pattern & (int)DIRECTION.RIGHT) != 0) Buttons += '1';
			else Buttons += '0';
		}
		public int GetPositioning()
		{
			int positioning = 0;
			if (Utilities.IsPress(Buttons[0]))
			{
				positioning |= (int)DIRECTION.LEFT;
			}
			if (Utilities.IsPress(Buttons[1]))
			{
				positioning |= (int)DIRECTION.DOWN;
			}
			if (Utilities.IsPress(Buttons[2]))
			{
				positioning |= (int)DIRECTION.UP;
			}
			if (Utilities.IsPress(Buttons[3]))
			{
				positioning |= (int)DIRECTION.RIGHT;
			}
			return positioning;
		}
		public override string ToString()
		{
			return this.Buttons;
		}
		public string ToArrows()
		{
			string arrow = "";
			arrow += Buttons[0] == '1' ? '←' : ' ';
			arrow += Buttons[1] == '1' ? '↓' : ' ';
			arrow += Buttons[2] == '1' ? '↑' : ' ';
			arrow += Buttons[3] == '1' ? '→' : ' ';
			return arrow;
		}
	}
}
