using System;

namespace Elections
{
	public class Test
	{
		public static void Main ()
		{

			Person david = new Person ();

			Console.WriteLine ("Ethnicity " + david.ethnicity);
			Console.WriteLine ("Party " + david.party);
			Console.WriteLine ("Immigration " + david.imm);
			Console.WriteLine ("Imm Import " + david.immImport);
			Console.WriteLine ("Trade " + david.trade);
			Console.WriteLine("Trade Import " + david.tradeImport);
			Console.WriteLine ("Care " + david.care);
			Console.WriteLine ("Politics Import " + david.politicsImport);

			david.ad ("imm", "democrat", 25, 10, 10);

			Console.WriteLine ("Imm D" + david.immD[0]);
			Console.WriteLine ("Imm D Import" + david.immDImport);
			Console.WriteLine ("Care D" + david.careD);

			Person [] pop = new Person[10000];

			for (int i = 0; i < 10000; ++i) {
				pop [i] = new Person ();
			}
			Console.WriteLine (pop [100].ethnicity);
			Console.WriteLine (pop [100].party);
		}
	}
}

