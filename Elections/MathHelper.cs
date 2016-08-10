using System;
using System.Collections.Generic;

namespace Elections
{
	public static class MathHelper
	{
		// Generate a number (0.0, 1.0) from the normal distribution
		public static float sampleNormal (double mean, double stddev)
		{
			Random random = new Random();
			float r1 = 1 - random.NextDouble ();
			float r2 = 1 - random.NextDouble ();

			float std = Math.Sqrt (-2.0 * Math.Log (r1)) * Math.Cos (2.0 * Math.PI * r2);

			return mean + stddev * std;
		}

		public static float sampleNormalOne ()
		{
			float sample = sampleNormal (.5, .25);
				if (sample > 1) {
					sample = 1;
				} else if (sample < 0) {
					sample = 0;
				} 
			return sample;
				
		}


		public static string cumulativeProbability (int[] probability){
			float [] mean = {25, 50, 75};
			Random random = new Random();
			int r = random.Next (1, 100);
			int count = 0;
			foreach (int num in probability) {
				if (r <= probability [num]) {
					return sampleNormalOne (mean [count],12);
					count = count + 1;
				} 
			}
			return 50;
		}

		public static int averageList (List<int> list){
			int total = 0;
			foreach (int item in list) {
				total = total + item;
			}
			return total / list.Count;
		}
	}
}

