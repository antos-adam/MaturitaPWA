using System;
namespace Singleton.Model
{
	public class Osoba
	{
        private Osoba(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public static Osoba NovaInstance(Prepravka prepravka)
        {
            if(Instance == null)
            {
                Instance = new Osoba(prepravka.Jmeno, prepravka.Prijmeni);
            }

            return Instance;
        }

        private string Jmeno { get; set; }
		private string Prijmeni { get; set; }

        private static Osoba? Instance { get; set; }

        public override string ToString()
        {
            return "Jméno: " + Jmeno + " Příjmení: " + Prijmeni;
        }
    }
}

