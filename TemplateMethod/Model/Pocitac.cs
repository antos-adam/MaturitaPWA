using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Model
{
	internal class Pocitac
	{
		public string Deska { get; set; }
		public string Procesor { get; set; }
		public int Pamet { get; set; }

		public Pocitac(string deska, string procesor, int pamet)
		{
			Deska = deska;
			Procesor = procesor;
			Pamet = pamet;
		}

		public override string ToString()
		{
			return $"Deska: {Deska}\n" +
				$"Procesor: {Procesor}\n" +
				$"Pamet: {Pamet} GB";
		}
	}
}
