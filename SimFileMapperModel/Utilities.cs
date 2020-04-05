using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NAudio;
using NAudio.Wave;

namespace SimFileMapperModel.Model
{
	[Flags]
	public enum DIFFICULTY
	{
		EASY = 1,
		MEDIUM = 2,
		HARD = 4,
		EXPERT = 8,
		EXTREME = 16
	}
	[Flags]
	public enum DIRECTION
	{
		LEFT = 1,
		DOWN = 2, 
		UP = 4,
		RIGHT = 8,
		BOTH = (LEFT | RIGHT),
		EITHER = 0,
		ALL = (LEFT | RIGHT | DOWN | UP),
		RIGHTSIDE = (RIGHT | DOWN | UP),
		LEFTSIDE = (LEFT | DOWN | UP),
	}
	public static class Utilities
	{
		
		public static char ToStep(this char x)
		{
			switch (x = char.ToUpper(x))
			{
				case '1':
				case '2':
				case '3':
				case '4':
				case 'M':
				case 'K':
				case 'L':
				case 'F':
					return x;
				default:
					return '0';
			}
		}
		public static string ToSteps(this string x)
		{
			return string.Join("", x.Select(c => c.ToStep()));
		}

		public static bool IsNotPress(char x)
		{
			x = char.ToUpper(x);
			return x == '0' || x == 'M' || x == '3';
		}

		public static bool IsPress(char x)
		{
			return !IsNotPress(x);
		}

		public static IEnumerable<float> FloatArrayFromAudio(string FileName)
		{
			using (Mp3FileReader fileReader = new Mp3FileReader(FileName))
			{
				byte[] data = new byte[fileReader.Length];
				fileReader.Read(data, 0, data.Length);
				for (int i = 0; i < data.Length; i += 4)
				{
					yield return BitConverter.ToSingle(data, i);
				}
			}
		}
		public static string EnumerableToCommaSeparatedString<T>(this IEnumerable<T> list)
		{
			StringBuilder builder = new StringBuilder("");
			foreach (T element in list)
			{
				builder.Append(element.ToString() + " ");
			}
			return builder.ToString();
		}
	}
}
