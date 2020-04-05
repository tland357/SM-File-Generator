using System;
using System.Collections.Generic;
using System.Linq;
namespace SimFileMapperModel
{
	public static class Extentions
	{
		public static bool IsAnyOf<T>(this T item, params T[] arr)
		{
			foreach (T el in arr)
			{
				if (el.Equals(item)) return true;
			}
			return false;
		}
		public static IEnumerable<float> Diff(this IList<float> data)
		{
			for (int i = 1; i < data.Count; i += 1)
			{
				yield return data[i] - data[i - 1];
			}
		}
		static Random random = new Random();
		public static T GetRandom<T>(this IList<T> data)
		{
			return data[random.Next(data.Count)];
		}
		public static T GetRandom<T>(this IEnumerable<T> data)
		{
			return data.ToList().GetRandom();
		}

		public static float AverageNoOutliers(this IList<float> data)
		{
			data = data.OrderBy(x => x).ToList();
			float average = data.Average();
			float lowerQuartile = new float[] { data[(int)Math.Ceiling(data.Count / 4.0)], data[(int)Math.Floor(data.Count / 4.0)] }.Average();
			float higherQuartile = new float[] { data[(int)Math.Ceiling(data.Count * 3.0 / 4.0)], data[(int)Math.Floor(data.Count * 3.0 / 4.0)] }.Average();
			float IQR = higherQuartile - lowerQuartile;
			return data.Where(x => x > lowerQuartile - 1.5 * IQR || x < higherQuartile + 1.5 * IQR).Average();
		}
	}
}
