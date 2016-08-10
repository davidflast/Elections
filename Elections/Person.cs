using System;
using System.Collections.Generic;

namespace Elections
{
	public class Person
	{
		//Fields
		//Identity Fields
		public string ethnicity;
		public string party;
		// Opinion position and importance
		// imm = immigration
		// abort = abortion
		public int imm;
		public int immImport;
		public int trade;
		public int tradeImport;
		// Perception of Democrat Candidate
		public List<int> immD;
		public int immDImport;
		public List<int> tradeD;
		public int tradeDImport;
		//Perception of Republican Candidate
		public List<int> immR;
		public int immRImport;
		public List<int> tradeR;
		public int tradeRImport;
		// Personality Desire
		public int care;
		public int careD;
		public int careR;
		// scores
		public int politicsImport;
		public int scoreD;
		public int scoreR;
		public int contactCount;
		public string vote;


		public Person ()
		{
			ethnicity = IdentityGenerator.generateEthnicity ();
			party = IdentityGenerator.generateParty (ethnicity);
			imm = OpinionGenerator.generateImm (party, ethnicity);
			trade = OpinionGenerator.generateTrade (party, ethnicity);
			contactCount = 0;
			tradeImport = MathHelper.sampleNormalOne ();
			immImport = MathHelper.sampleNormalOne ();
			politicsImport = MathHelper.sampleNormalOne ();
			care = MathHelper.sampleNormalOne ();
			immD = new List<int>();
			immDImport = null;
			tradeD = new List<int>();
			tradeDImport = null;
			immR = new List<int>();
			immRImport = null;
			tradeR = new List<int>();
			tradeRImport = null;
			care = null;
			careD = null;
			careR = null;
			scoreDif = null;
			scoreD = null;
			scoreR = null;	
		}

		public void ad (String topic, String party, int strength, int import, int careChange)
		{
			switch (topic) {
			case "imm": 
				if (party == "democrat") {
					immD.Add (strength);
					immDImport = immDImport + import;
					careD = careD + careChange;
				} else {
					immR.Add (strength);
					immRImport = immRImport + import;
					careR = careR + careChange;
				}
			case "trade":
				if (party == "democrat") {
					tradeD.Add (strength);
					tradeDImport = tradeDImport + import;
					careD = careD + careChange;
				} else {
					tradeR.Add (strength);
					tradeRImport = tradeRImport + import;
					careD = careD + careChange;
				}
			}
		}

		public void decide(){
			int immDScore = (100 - 2 * Math.Abs(imm - MathHelper.averageList(immD))) * immImport;
			int tradeDScore = (100 - 2 * Math.Abs(trade - MathHelper.averageList(tradeD))) * tradeImport;
			int immRScore = (100 - 2 * Math.Abs(imm - MathHelper.averageList(immR))) * immImport;
			int tradeRScore = (100 - 2 * Math.Abs(trade - MathHelper.averageList(tradeR))) * tradeImport;
			scoreD = immDScore + tradeDScore;
			scoreR = immRScore + tradeRScore;
			if (scoreD > scoreR + 20 && scoreD - scoreR > 100 - politicsImport) {
				vote = "democrat";
			} else if (scoreR > scoreD + 20 && scoreR - scoreD > 100 - politicsImport){
				vote = "republican";
			} else {
				vote = "undecided";
			}
		}

	}
}

