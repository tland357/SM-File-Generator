using System;
using System.Collections.Generic;
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
		
		public static void ThreadSafeCall(this Control c, Action<Control> Callback)
		{
			if (c.InvokeRequired)
			{
				c.Invoke(Callback, c);
			} else
			{
				Callback(c);
			}
		}
	}
}
