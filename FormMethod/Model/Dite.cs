using System;
namespace FormMethod.Model
{
	public class Dite : Osoba
	{
        public Dite(string jmeno, int vek)
        {
            Jmeno = jmeno;
            Vek = vek;
        }
        public override string ToString()
        {
            return "Dite " + Jmeno + " " + Vek.ToString();
        }
    }
}

