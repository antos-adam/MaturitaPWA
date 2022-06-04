using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SpojoveStruktury.Model
{
	class SpojovySeznam<T> where T : IComparable
	{
		Uzel zacatek;
		class Uzel
		{
			public T data;
			public Uzel dalsi;

			public Uzel(T data, SpojovySeznam<T>.Uzel dalsi, SpojovySeznam<T>.Uzel predchozi)
			{
				this.data = data;
				this.dalsi = dalsi;
			}
		}
		public void VlozNaZacatek(T vstup)
		{
			Uzel novy = new Uzel(vstup, zacatek, null);
			zacatek = novy; // reference dalsiho prvku noveho uzlu je predchozi prvni uzel - O(1)
		}
		public void VlozNaKonec(T vstup)
		{
			Uzel docasny = zacatek;
			if (zacatek == null)
			{
				VlozNaZacatek(vstup);
			}
			while (docasny.dalsi != null)
			{
				docasny = docasny.dalsi; // projede se cely list tak, ze se docasny uzel nastavi na referenci dalsiho uzlu, pokud jiz neni zadny naslednik, cyklus konci - O(n)
			}
			docasny.dalsi = new Uzel(vstup, null, docasny); // novy uzel se vytvori s referenci na predchozi (posledni) prvek
		}
		public bool VlozNaIndex(int index, T vstup)
		{
			if (index == 0)
				zacatek = new Uzel(vstup, zacatek, null);
			Uzel docasny = zacatek;
			for (int i = 0; i < index - 1; i++)
			{
				docasny = docasny.dalsi; // projede se list do urciteho indexu
			};
			docasny.dalsi = new Uzel(vstup, docasny.dalsi, null);
			return true;
		}
		public void VypisPrvky()
		{
			Uzel docasny = zacatek;
			while (docasny != null)
			{
				Console.WriteLine(docasny.data);
				if
					(docasny.dalsi != null) docasny = docasny.dalsi;
				else
					return;
			}
		}
		public bool OdeberPrvni()
		{
			if (zacatek == null)
				return false;
			zacatek = zacatek.dalsi; // reference na dalsi uzel prvniho uzlu se nastavi na druhy uzel - O(1)
			return true;
			
		}
		public bool Odeber(T vstup)
		{
			Uzel docasny = zacatek, predchozi = null;
			while (docasny.data.CompareTo(vstup) != 0) // projede se cely seznam, jestli se hodnota neshoduje - O(n)
			{
				if (docasny.dalsi != null) // pokud jsou dalsi prvky, cyklus se posune o jeden uzel dal
				{
					predchozi = docasny;
					docasny = docasny.dalsi;
				}
				else return false; // pokud cyklus dojede na konec, vrati se false, protoze uzel s hodnotou vstup se nenasel
			}
			predchozi.dalsi = docasny.dalsi; // reference uzlu n s hodnotou vstup budou vymazany; reference na dalsi uzel (n-1)teho prvku se nastavi na (n+1)ty prvek
			return true;
		}
		public int ZiskejIndex(T vstup)
		{
			int counter = 0;
			Uzel docasny = zacatek;
			while (docasny.data != null) // projede se cely seznam
			{
				if (docasny.data.Equals(vstup))
					return counter; // pokud se data shoduji, vrati se aktualni hodnota counteru
				else
				{
					docasny = docasny.dalsi;
					counter++;
					if (docasny == null) break;
				}
			}
			return -1;
		}
		public bool Obsahuje(T vstup)
		{
			return ZiskejIndex(vstup) > 0; // pokud je hodnota z counteru indexace vetsi nez 1;
		}
	}
}
