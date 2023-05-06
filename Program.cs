int AdultosAlcool, AdultosRefri, Fetos, Adultos, Total; 
double Meat, Side, Beer, Soda, Water;
Console.Clear();


Console.WriteLine("--- Churrasco ---\n");

Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
AdultosAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
AdultosRefri = Convert.ToInt32(Console.ReadLine());

Console.Write("Crianças........................................: ");
Fetos = Convert.ToInt32(Console.ReadLine());


//Soma do total de pessoas
Adultos = AdultosAlcool + AdultosRefri;
Total = Adultos + Fetos;

//Calculos para a quantidade de itens
Meat = 0.4 * Adultos + 0.2 * Fetos;
Side = 0.2 * Total;
Beer = 2 * AdultosAlcool;
Soda = 0.5 * (AdultosRefri + Fetos);
Water = 0.4 * Total;



Console.WriteLine();
Console.WriteLine($"Carne.............: {Meat:N1}kg");
Console.WriteLine($"Acompanhamentos...: {Side:N1}kg");
Console.WriteLine($"Cerveja...........: {Beer:N1}l");
Console.WriteLine($"Refrigerante......: {Soda:N1}l");
Console.WriteLine($"Água..............: {Water:N1}l");
