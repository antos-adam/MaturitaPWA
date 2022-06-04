using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Model
{
	internal class HighendPocitacStavitel : PocitacStavitel // po napsani : PocitacStavitel lze vyscaffoldovat pretezene metody PridejDesku() apod.
	{
		public override void PridejDesku() //deti implementuji abstraktni tridy rodice vlastnim zpusobem
		{
			Deska = "klasicka";
		}
		public override void PridejProcesor()
		{
			Procesor = "Pentium";
		}

		public override void PridejPamet()
		{
			Pamet = 4;
		}		
	}
}
