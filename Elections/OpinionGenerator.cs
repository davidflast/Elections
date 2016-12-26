using System;

namespace Elections
{
	public abstract class OpinionGenerator
	{
		public abstract Opinion generate (Party party, Ethnicity ethnicity);
	
		//		public static int generateImm(Random r, string party, Ethnicity ethnicity)
		//		{
		//			switch (ethnicity) {
		//			case "black":
		//				if (party == Party.Democrat) {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 23, 63, 100 });
		//				} else if (party == "indepedent") {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 38, 69, 100 });
		//				} else {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 29, 62, 100 });
		//				}
		//			case "hispanic":
		//				if (party == Party.Democrat) {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 43, 81, 100 });
		//				} else if (party == "indepedent") {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 43, 67, 100 });
		//				} else {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 35, 75, 100 });
		//				}
		//			case "white":
		//				if (party == Party.Democrat) {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 29, 76, 100 });
		//				} else if (party == "indepedent") {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 19, 61, 100 });
		//				} else {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 20, 60, 100 });
		//				}
		//			}
		//			return 50;
		//		}
		//
		//		public static int generateTrade(Random r, string party, string ethnicity)
		//		{
		//			switch (ethnicity) {
		//			case "black":
		//				if (party == Party.Democrat) {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 41, 69, 100 });
		//				} else if (party == "indepedent") {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 33, 60, 100 });
		//				} else {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 40, 85, 100 });
		//				}
		//			case "hispanic":
		//				if (party == Party.Democrat) {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 38, 75, 100 });
		//				} else if (party == "indepedent") {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 42, 79, 100 });
		//				} else {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 30, 55, 100 });
		//				}
		//			case "white":
		//				if (party == Party.Democrat) {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 38, 67, 100 });
		//				} else if (party == "indepedent") {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 33, 54, 100 });
		//				} else {
		//					return MathHelper.cumulativeProbability (r, new int[]{ 34, 59, 100 });
		//				}
		//			}
		//			return 50;
		//		}
	}

	public sealed class ImmigrationOpinionGenerator : OpinionGenerator
	{
		const Random random = new Random ();

		public override Opinion generate (Party party, Ethnicity ethnicity)
		{
			switch (ethnicity) {
			case Ethnicity.Black:
				if (party == Party.Democrat) {
					return MathHelper.cumulativeProbability (r, new int[]{ 23, 63, 100 });
				} else if (party == Party.Indepdendent) {
					return MathHelper.cumulativeProbability (r, new int[]{ 38, 69, 100 });
				} else {
					return MathHelper.cumulativeProbability (r, new int[]{ 29, 62, 100 });
				}
			case Ethnicity.Hispanic:
				if (party == Party.Democrat) {
					return MathHelper.cumulativeProbability (r, new int[]{ 43, 81, 100 });
				} else if (party == Party.Indepdendent) {
					return MathHelper.cumulativeProbability (r, new int[]{ 43, 67, 100 });
				} else {
					return MathHelper.cumulativeProbability (r, new int[]{ 35, 75, 100 });
				}
			case Ethnicity.White:
				if (party == Party.Democrat) {
					return MathHelper.cumulativeProbability (r, new int[]{ 29, 76, 100 });
				} else if (party == Party.Indepdendent) {
					return MathHelper.cumulativeProbability (r, new int[]{ 19, 61, 100 });
				} else {
					return MathHelper.cumulativeProbability (r, new int[]{ 20, 60, 100 });
				}
			}
			return 50;
		}
	}
}

