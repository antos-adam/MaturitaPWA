using System;
namespace Singleton.Model
{
	public class Prepravka
	{
		public string Jmeno { get; private set; }
		public string Prijmeni { get; private set; }

        public Prepravka(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
    }
}

