using Spedizioni;

var Corriere1 = new Corriere("DHL");
var corriere2 = new Corriere("Matras");
var corriere3 = new Corriere("gls");

var cartolina = new Plico("carlo","giovanna",2,0.2,0.3);

var paccoAmazon = new Pacco("Amazon", "mario rossi", 50, 1.5, 2,1);

Corriere1.addSpedizione(cartolina);
corriere3.addSpedizione(paccoAmazon);

Console.WriteLine($"lista spedizioni {Corriere1.Nome}");
Console.WriteLine("\n");
Console.WriteLine(Corriere1.listaSpedizioni());
Console.WriteLine($"quantita di ingombro totale: {Corriere1.TotaleIngombro()}");
Console.ReadLine();



