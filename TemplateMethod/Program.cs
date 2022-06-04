using TemplateMethod.Model;

HighendPocitacStavitel highend = new HighendPocitacStavitel();
LowendPocitacStavitel lowend = new LowendPocitacStavitel();

highend.PostavPocitac();
Console.WriteLine("---");
lowend.PostavPocitac();