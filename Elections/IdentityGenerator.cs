using System;

namespace Elections
{
	public static class IdentityGenerator
	{	
		//generates ethnicity
		public static Ethnicity generateEthnicity (Random r)
		{
			string ethnicity;
			int e = r.Next (1,100);
			if (e <= 17) {
				return Ethnicity.Black;
			} else if (e <= 42) {
				return Ethnicity.Hispanic;
			}
			return Ethnicity.White;
		}

		//generates party
		public static Party generateParty (Random r, Ethnicity e)
		{
			string party;
			int p = r.Next (1, 100);
			switch (e) {
			case Ethnicity.Black:
				if (p <= 82) {
					return Party.Democrat;
				} else if (p <= 86) {
					return Party.Republican;
				} 
				return Party.Indepdendent;
			
			case Ethnicity.Hispanic:
				if (p <= 39) {
					return Party.Democrat;
				} else if(p <= 69){
					return Party.Republican;
				} 	
				return Party.Indepdendent;

			case Ethnicity.White:
				if (p <= 33) {
					return Party.Democrat;
				} else if(p <= 77){
					return Party.Republican;
				}
				return Party.Indepdendent;
			}
		}

	}
}

