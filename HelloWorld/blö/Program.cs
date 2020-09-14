using System;

namespace Metoder
{
	class Program
	{
		static void Main(string[] args)
        {
			int[] _tal = { 1, 2, 3, 4 };
			string[] _ord = { "Philip", "Vivian", "Filippa", "Niklas" };
			int[] _storTal = { 1, 2, 4, 8, 16 };

			Console.WriteLine(blö(_tal));
			blöö(_ord);
			blööö(_storTal);

		}
		static int blö(int[] tal)
        {
			var sum = 0;

			for(int i = 0; i < tal.Length; i++)
            {
                sum = sum + tal[i];
            }
			return sum;
        }
		static void blöö(string[] ord)
        {
			for(int i = ord.Length -1; i >= 0; i--)
            {
				Console.WriteLine(ord[i]);
            }
        }
		static int[] blööö(int[] storTal)
		{
			int högsta = storTal[0];
			int lägsta = storTal[0];
			int[] svar = {högsta, lägsta};

			for(int i = 1; i < storTal.Length; i++)
            {
                if (storTal[i] > högsta)
                {
					högsta = storTal[i];
                }
                if (storTal[i] < lägsta)
                {
					lägsta = storTal[i];
                }
            }
			Console.WriteLine(högsta);
			Console.WriteLine(lägsta);
			return svar;
        }
	}
}
