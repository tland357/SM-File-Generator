using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SimFileMapperModel;
using System.Windows.Input;

namespace SimFileMapperView
{
	public partial class BpmCalculator : Form
	{
		Form1 formreference;
		readonly string fileDirectory;
		struct Vec2
		{
			public float x;
			public float y;
			public Vec2(float a, float b)
			{
				x = a;
				y = b;
			}
		}
		Thread mover;
		public BpmCalculator(Form1 form)
		{
			InitializeComponent();
			formreference = form;
			fileDirectory = formreference.mp3Selector.FileName;
			int i = 0;
			foreach (var flux in form.song.Fluxes) {
				chart1.Series[0].Points.AddXY(++i, flux);
			}
			chart1.Width = form.song.Fluxes.Length;
			mover = new Thread(new ThreadStart(() =>
			{
				while (true)
				{
					this.ThreadSafeCall(con =>
					{
						BpmCalculator g = con as BpmCalculator;
						bool r = g.RightKey;
						bool l = g.LeftKey;
						if (l && !r)
						{
							g.chart1.Location = new Point(chart1.Location.X + 10, chart1.Location.Y);
						}
						if (r && !l)
						{
							g.chart1.Location = new Point(chart1.Location.X - 10, chart1.Location.Y);
						}
					});
					Thread.Sleep(17);
				}
			}));
			mover.Start();
		}
		public float BPM
		{
			get;
			protected set;
		}
		public float OFFSET
		{
			get;
			protected set;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
		bool LeftKey
		{
			get {
				try
				{
					return Keyboard.IsKeyDown(Key.Left);
				} catch (InvalidOperationException)
				{
					return false;
				}
			}
		}
		bool RightKey
		{
			get {
				try
				{
					return Keyboard.IsKeyDown(Key.Right);
				}
				catch (InvalidOperationException)
				{
					return false;
				}
			}
		}

		private void BpmCalculator_FormClosing(object sender, FormClosingEventArgs e)
		{
			mover.Abort();
		}
	}
}
