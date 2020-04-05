using System;
using System.Windows.Forms;

namespace SimFileMapperView
{
	public static class Extensions
	{
		public static void Traverse(this Control c, Action<Control> Callback)
		{
			Callback(c);
			foreach (Control child in c.Controls)
			{
				child.Traverse(Callback);
			}
		}
	}
}
