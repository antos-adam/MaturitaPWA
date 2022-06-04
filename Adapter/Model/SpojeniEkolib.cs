using System;
namespace Adapter.Model
{
	public class SpojeniEkolib
	{
		public string VychoziZastavka { get; set; }
		public string CilovaZastavka { get; set; }
		public int CenaSpojeni { get; set; }
		public float Vzdalenost { get; set; }

        public override string ToString()
        {
			return "Spojení " + VychoziZastavka + " - " + CilovaZastavka + " Cena: " + CenaSpojeni.ToString() + " Vzdálenost: " + Vzdalenost.ToString();
        }
    }
}

