using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Model
{
	abstract class PocitacStavitel // definovat abstraktni tridu, ze ktere se bude dedit
	{
		protected string Deska { get; set; }
		protected string Procesor { get; set; }
		protected int Pamet { get; set; }

		public Pocitac PostavPocitac() // toto je SABLONOVA METODA - musi byt verejna
		{
			PridejDesku();
			PridejProcesor();
			PridejPamet();
			Pocitac pocitac = new Pocitac(Deska, Procesor, Pamet);
			Console.WriteLine(pocitac.ToString());
			return pocitac;
		}

		public abstract void PridejDesku(); // definovat abstraktni metody , ktere maji implementovat dedici tridy
		public abstract void PridejProcesor();
		public abstract void PridejPamet();
	}
}
