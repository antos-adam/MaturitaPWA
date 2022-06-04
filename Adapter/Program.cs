/*Adaptér
Většina z vás jistě při vývoji používá komponentovou architekturu a využívá tedy hotových řešení třetích stran (nebo vlastních komponent z předešlých projektů). 
Představme si, že chceme (nebo dokonce musíme)používat komponentu, které její autoři stále mění rozhraní. My tuto komponentu
používáme na 100 místech v programu a při každé nové verzi musíme kód na mnoha místech přepisovat. Podobný problém nastane v
případě, když máme v aplikaci již připravené nějaké rozhraní a chceme do něj komponentu zasadit. Ta jednoduše řečeno nepasuje.
*/
using Adapter.Model;

AdapterProEkolib adapterProEkolib = new AdapterProEkolib();

SpojeniEkolib spojeni1 = adapterProEkolib.ZiskejSpojeni("Turnov", "Liberec");
SpojeniEkolib spojeni2 = adapterProEkolib.ZiskejSpojeni("Liberec", "Chata Hrádek n. Nisou");

Console.WriteLine(spojeni1);
Console.WriteLine(spojeni2);