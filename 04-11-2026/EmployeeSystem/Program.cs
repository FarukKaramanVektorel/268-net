using EmployeeSystem;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Gorev mudur = new Gorev("Personel Müdürü", 2.5);
Gorev muhasebeMudur = new Gorev("Muhasebe Müdürü", 3);
Gorev personel = new Gorev("Personel", 1.5);


Employee pers1 = new Employee("Elif", "Eylül", "PER001", 48,mudur);
Employee pers2 = new Employee("Polat", "Alemdar", "PER002", 40,muhasebeMudur);
Employee pers3 = new Employee("Ali", "Candan",  "PER003", 50,personel);

pers1.Info();
pers2.Info();
pers3.Info();