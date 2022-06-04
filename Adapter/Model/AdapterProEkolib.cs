using System;
namespace Adapter.Model
{
	public class AdapterProEkolib
	{
		public AdapterProEkolib()
		{
		}

		Idos idos = new Idos();
		public SpojeniEkolib ZiskejSpojeni(string vychoziZastavka, string cilovaZastavka)
        {
			SpojeniIdos spojeniIdos = idos.ZiskejSpojeni(vychoziZastavka, cilovaZastavka); //Adapter propojuje naší Ekolibku s Idosem, v případě změny na straně idosu stačí upravit adaptér a nic dalšího protože zbytek metod v aplikace je napojen na tento adaptér

			SpojeniEkolib spojeniEkolib = new SpojeniEkolib();
			spojeniEkolib.VychoziZastavka = spojeniIdos.ZastavkaZ; //přes adaptér mohou být jiné názvy vlastností
			spojeniEkolib.CilovaZastavka = spojeniIdos.ZastavkaDo;
			spojeniEkolib.CenaSpojeni = spojeniIdos.Cena;
			spojeniEkolib.Vzdalenost = (float)spojeniIdos.Vzdalenost; //přes adaptér se dá využívat i jiný datový typ

			return spojeniEkolib;
        }
	}
}

