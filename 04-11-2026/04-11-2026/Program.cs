using _04_11_2026;



//Nesne Başlatıcılar

Fighter a = new Fighter
{
    Name = "Kareem Abdul-Jabbar",
    Weight = 100,
    Height = 2.05,
    Healt = 100
};

Fighter b = new Fighter
{
    Name = "Bruce Lee",
    Weight = 100,
    Height = 2.05,
    Healt = 100
};
//Fighter a = new Fighter("Kareem Abdul-Jabbar", 100, 2.05, 100);
//Fighter b = new Fighter("Bruce Lee", 100, 2, 100);
Ring ring = new Ring();
ring.Run(a, b);