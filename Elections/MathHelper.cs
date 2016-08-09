using System;

namespace Elections
{
	public static class MathHelper
	{
		// Generate a number (0.0, 1.0) from the normal distribution
		public static double sampleNormal (double mean, double stddev)
		{
			Random random = new Random();
			double r1 = 1 - random.NextDouble ();
			double r2 = 1 - random.NextDouble ();

			double std = Math.Sqrt (-2.0 * Math.Log (r1)) * Math.Cos (2.0 * Math.PI * r2);

			return mean + stddev * std;
		}

		public static string cumulativeProbability (int[] probability){
			Random random = new Random();
			int r = random.Next (1, 100);
			foreach (int num in probability) {
				if (r <= probability [num]) {
					return num + 1;
				} 
			}
			return 3;
		}


	}
}

