using WarCharacter;

Nation nomad = new Nation("Türk", 10);
Nation rush = new Nation("Rus", 10);

Warior turk = new Warior("Malkoçoğlu", nomad);
Archer iskender = new Archer("Tozkoparan İskender", nomad);
Warior rus = new Warior("İvanoviç", rush);

Console.WriteLine(rus);
Console.WriteLine(turk.Attack());
Console.WriteLine(iskender.Attack());
rus.TakeDamage(iskender.Attack());
Console.WriteLine(rus);


