using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SpojoveStruktury.Model
{
	class BinarniStrom<T> where T : IComparable<T>
	{
		Uzel koren;
		class Uzel
		{
			public T data;
			public Uzel levy, pravy;
			public Uzel(T vstup)
			{
				data = vstup;
			}
		}
		public int ZiskejVysku()
		{
			if (koren == null)
			{
				return 0;
			}
			return ZiskejVyskuRekurzivne(koren);
		}
		private int ZiskejVyskuRekurzivne(Uzel koren)
		{
			if (koren == null) return 0;
			int levy = ZiskejVyskuRekurzivne(koren.levy) + 1;
			int pravy = ZiskejVyskuRekurzivne(koren.pravy) + 1;
			return levy > pravy ? levy : pravy;
		}
		public void Pridej(T vstup)
		{
			if (koren == null)
			{
				koren = new Uzel(vstup);
				return;
			}
			PridejRekurzivne(koren, vstup);
		}
		private void PridejRekurzivne(Uzel koren, T vstup) // O(log n)-O(n)
		{
			if (vstup.CompareTo(koren.data) <= 0) // pro CompareTo je potreba IComparable
			{
				if (koren.levy != null)
				{
					PridejRekurzivne(koren.levy, vstup);
				}
				else
				{
					koren.levy = new Uzel(vstup);
				}
			}
			else
			{
				if (koren.pravy != null)
				{
					PridejRekurzivne(koren.pravy, vstup);
				}
				else
				{
					koren.pravy = new Uzel(vstup);
				}
			}
		}
		public void VypisPrvky()
		{
			if (koren != null)
			{
				VypisObsahRekurzivne(koren);
			}
		}
		private void VypisObsahRekurzivne(Uzel koren) // pre-order - uzel, levy podstrom, pravy podstrom
		{
			Console.WriteLine(koren.data);
			if (koren.levy != null)
			{
				VypisObsahRekurzivne(koren.levy);
			}
			if (koren.pravy != null)
			{
				VypisObsahRekurzivne(koren.pravy);
			}
		}
		public void SmazPrvek(T vstup)
		{
			Uzel uzel = new Uzel(vstup);
			SmazPrvekRekurzivne(koren, uzel);
		}
		private Uzel SmazPrvekRekurzivne(Uzel koren, Uzel node)
		{
			if (koren == null)
			{
				return koren;
			}

			if (node.data.CompareTo(koren.data) < 0)
			{
				koren.levy = SmazPrvekRekurzivne(koren.levy, node);
			}
			else if (node.data.CompareTo(koren.data) > 0)
			{
				koren.pravy = SmazPrvekRekurzivne(koren.pravy, node);
			}

			else
			{
				if (koren.levy == null)
				{
					return koren.pravy;
				}
				else if (koren.pravy == null)
				{
					return koren.levy;
				}
				koren.data = NejmensiPrvek(koren.pravy);

				Uzel docasny = new Uzel(koren.data);
				koren.pravy = SmazPrvekRekurzivne(koren.pravy, docasny);
			}
			return koren;
		}
		private T NejmensiPrvek(Uzel koren)
		{
			T min = koren.data;
			while (koren.levy != null)
			{
				min = koren.levy.data;
				koren = koren.levy;
			}
			return min;
		}
	}
}
