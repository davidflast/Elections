using System;
using System.Collections.Generic;
using System.Linq;

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
		public string vote;
		Random random;


		public Person ()
		{	
			random = new Random ();
			ethnicity = IdentityGenerator.generateEthnicity (random);
			party = IdentityGenerator.generateParty (random, ethnicity);
			imm = OpinionGenerator.generateImm (random, party, ethnicity);
			trade = OpinionGenerator.generateTrade (random, party, ethnicity);
			tradeImport = MathHelper.sampleNormalOne (random);
			immImport = MathHelper.sampleNormalOne (random);
			politicsImport = MathHelper.sampleNormalOne (random);
			care = MathHelper.sampleNormalOne (random);
			immD = new List<int>();
			immDImport = 0;
			tradeD = new List<int>();
			tradeDImport = 0;
			immR = new List<int>();
			immRImport = 0;
			tradeR = new List<int>();
			tradeRImport = 0;
			careD = 0;
			careR = 0;
			scoreD = 0;
			scoreR = 0;	
		}

		internal Person(Ethnicity ethnicity, Party party, Opinion immigration) {
			this.ethnicity = ethnicity;
			this.party = party;
			this.immigration = immigration;
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
				break;
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
				break;
			}
		}

		public void decide(){
			int immDScore = (100 - 2 * Math.Abs(imm - immD.Average())) * immImport;
			int tradeDScore = (100 - 2 * Math.Abs(trade - tradeD.Average())) * tradeImport;
			int immRScore = (100 - 2 * Math.Abs(imm - immR.Average())) * immImport;
			int tradeRScore = (100 - 2 * Math.Abs(trade - tradeR.Average())) * tradeImport;
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

