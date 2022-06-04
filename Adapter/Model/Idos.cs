using System;
namespace Adapter.Model
{
	public class Idos //řekněme že vzdálená komponenta je IDOS, který eviduje seznam spojů a vrací spoj
	{
        private static List<SpojeniIdos> spojeni = new List<SpojeniIdos>();
        public Idos()
        {
            //výchozí data IDOSu
            spojeni.Add(new SpojeniIdos() { ZastavkaZ = "Turnov", ZastavkaDo = "Liberec", Cena = 45, Vzdalenost = 30 });
            spojeni.Add(new SpojeniIdos() { ZastavkaZ = "Liberec", ZastavkaDo = "Chata Hrádek n. Nisou", Cena = 30, Vzdalenost = 15 });
            spojeni.Add(new SpojeniIdos() { ZastavkaZ = "Pěnčín, Jistebsko", ZastavkaDo = "Jablonec n. Nisou", Vzdalenost = 10, Cena = 20 });
        }

        public SpojeniIdos ZiskejSpojeni(string zastavkaZ, string zastavkaDo)
        {
            return spojeni.FirstOrDefault(s => s.ZastavkaZ == zastavkaZ && s.ZastavkaDo == zastavkaDo);
        }
	}
}

