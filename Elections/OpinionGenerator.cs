using System;

namespace Elections
{
	public static class OpinionGenerator
	{
		public static float generateImm(string party, string ethnicity)
		{
			switch (ethnicity) {
			case "black":
				if (party == "democrat") {
					return MathHelper.cumulativeProbability (new int[]{ 23, 63, 100 });
				} else if (party == "indepedent") {
					return MathHelper.cumulativeProbability (new int[]{ 38, 69, 100 });
				} else {
					return MathHelper.cumulativeProbability (new int[]{ 29, 62, 100 });
				}
			case "hispanic":
				if (party == "democrat") {
					return MathHelper.cumulativeProbability (new int[]{ 43, 81, 100 });
				} else if (party == "indepedent") {
					return MathHelper.cumulativeProbability (new int[]{ 43, 67, 100 });
				} else {
					return MathHelper.cumulativeProbability (new int[]{ 35, 75, 100 });
				}
			case "white":
				if (party == "democrat") {
					return MathHelper.cumulativeProbability (new int[]{ 29, 76, 100 });
				} else if (party == "indepedent") {
					return MathHelper.cumulativeProbability (new int[]{ 19, 61, 100 });
				} else {
					return MathHelper.cumulativeProbability (new int[]{ 20, 60, 100 });
				}
			}
		}

		public static int generateTrade(string party, string ethnicity)
		{
			switch (ethnicity) {
			case "black":
				if (party == "democrat") {
					return MathHelper.cumulativeProbability (new int[]{ 41, 69, 100 });
				} else if (party == "indepedent") {
					return MathHelper.cumulativeProbability (new int[]{ 33, 60, 100 });
				} else {
					return MathHelper.cumulativeProbability (new int[]{ 40, 85, 100 });
				}
			case "hispanic":
				if (party == "democrat") {
					return MathHelper.cumulativeProbability (new int[]{ 38, 75, 100 });
				} else if (party == "indepedent") {
					return MathHelper.cumulativeProbability (new int[]{ 42, 79, 100 });
				} else {
					return MathHelper.cumulativeProbability (new int[]{ 30, 55, 100 });
				}
			case "white":
				if (party == "democrat") {
					return MathHelper.cumulativeProbability (new int[]{ 38, 67, 100 });
				} else if (party == "indepedent") {
					return MathHelper.cumulativeProbability (new int[]{ 33, 54, 100 });
				} else {
					return MathHelper.cumulativeProbability (new int[]{ 34, 59, 100 });
				}
			}
		}
	}
}

