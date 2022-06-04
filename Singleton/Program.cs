//Jedináček s využitím přepravky

using Singleton.Model;

Prepravka prepravka1 = new Prepravka("Adam", "Antoš");
Osoba os1 = Osoba.NovaInstance(prepravka1);

Prepravka prepravka2 = new Prepravka("Marek", "Pospichal");
Osoba os2 = Osoba.NovaInstance(prepravka2);

Prepravka prepravka3 = new Prepravka("Lenka", "Lenka");
Osoba os3 = Osoba.NovaInstance(prepravka3);

Console.WriteLine(os1.ToString());
Console.WriteLine(os2.ToString());
Console.WriteLine(os3.ToString());