using System;
namespace FormMethod.Model
{
	public class Osoba
	{
		public string Jmeno { get; set; }
		public int Vek { get; set; }
        protected Osoba()
        {
        }

        public static Osoba NovaInstance(string jmeno, int vek)
        {
            if (vek >= 18)
            {
                return new Student(jmeno, vek);
            }
            else
            {
                return new Dite(jmeno, vek);
            }
        }
    }
}

