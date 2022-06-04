using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Model
{
	internal class LowendPocitacStavitel : PocitacStavitel // po napsani : PocitacStavitel lze vyscaffoldovat pretezene metody PridejDesku() apod.
	{
		public override void PridejDesku()
		{
			Deska = "herni";
		}

		public override void PridejProcesor()
		{
			Procesor = "Core i9";
		}

		public override void PridejPamet()
		{
			Pamet = 32;
		}
	}
}
