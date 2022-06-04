using System;
namespace Original.Model
{
	public class OriginalniVec
	{
		public string Nazev { get; set; }

		private OriginalniVec(string nazev)
        {
			Nazev = nazev;
        }

		public static List<OriginalniVec> Instance = new List<OriginalniVec>();

		public static OriginalniVec NovaInstance(string nazev)
        {
			OriginalniVec inst = Instance.FirstOrDefault(i => i.Nazev == nazev);
			if (inst == null)
            {
				inst = new OriginalniVec(nazev);
				Instance.Add(inst);
            }

			return inst;
        }

        public override string ToString()
        {
			return Nazev;
        }
    }
}

