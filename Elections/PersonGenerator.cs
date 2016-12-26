using System;

namespace Elections
{
	public class PersonGenerator
	{
		public static Person GeneratePerson() 
		{
			Ethnicity ethnicity = IdentityGenerator.generateEthnicity (random);
			Party party = IdentityGenerator.generateParty (random, ethnicity);
			Opinion immigration = new ImmigrationOpinionGenerator ().generate (party, ethnicity);

			return new Person (ethnicity, party, immigration);
		}
	}
}

