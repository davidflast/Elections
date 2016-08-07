using System;

namespace Elections
{
	public class Person
	{
		//Fields
		//Identity Fields
		public string ethnicity;
		public string party;
		// Opinion position and importance
		public float imm;
		public float immImport;
		public float abort;
		public float abortImport;
		// Perception of Democrat
		public float immD;
		public float immDImport;
		public float abortD;
		public float abortDImport;
		//Perception of Repulican
		public float immR;
		public float immRImport;
		public float abortR;
		public float abortRImport;
		// Personality Desire
		public float care;
		public float careD;
		public float careR;


		public Person ()
		{
			ethnicity = PersonGenerator.generateEthnicity ();
			party = PersonGenerator.generateParty (ethnicity);
			
		}
	}
}

