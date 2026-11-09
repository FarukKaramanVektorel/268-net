using FotoSipsak;

Batarya sony = new Batarya("Sony", 50);
Batarya duracell = new Batarya("Duracell", 50);

FotoMachine fm = new FotoMachine("EOS 7D", sony);
DigitalMachine dm = new DigitalMachine(true, "Nikkon", sony);
DigitalMachine dm1 = new DigitalMachine(false, "Canon", duracell);
Console.WriteLine(fm);
Console.WriteLine(sony);



for (int i = 0; i < 30; i++)
{
    Console.WriteLine("Gerçekte kullandığı=> " + fm.Batery.Marka);
    if (fm.Batery.IsHeight(1))
        fm.TakeFoto("Kızılay"+i);
    else
    {
        if (fm.ChangeBatery(ref duracell))
        {
             fm.TakeFoto("Kızılay" + i);
        }
        else
        {
            Console.WriteLine("Tüm pilleri tükettik bye bye...");
            break;
        }
       
    }
        
    //Thread.Sleep(500);
}

for (int i = 0; i < 30; i++)
{
    Console.WriteLine("Gerçekte kullandığı=> " + dm1.Batery.Marka);
    if (dm1.Batery.IsHeight(1))
        dm1.TakeFoto("Kızılay" + i);
    else
    {
        if (fm.ChangeBatery(ref duracell))
        {
            fm.TakeFoto("kızılay" + i);

        }
        else
        {
            Console.WriteLine("piller bitti ");
            break;
        }
    }

    //Thread.Sleep(500);
}

for (int i = 0; i < 30; i++)
{
    Console.WriteLine("Gerçekte kullandığı=> "+dm.Batery.Marka);
    if (dm.Batery.IsHeight(3))
        dm.TakeFoto("Kızılay" + i);
    else
    {
        Console.WriteLine(dm.Model+" Batarya değişimi");
        if (dm.ChangeBatery(ref duracell))
        {
            dm.TakeFoto("kızılay" + i);
        }
        else
        {
            Console.WriteLine("piller bitti ");
            break;
        }
    }

   // Thread.Sleep(500);
}

