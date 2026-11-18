namespace MyFamily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DateTime time = DateTime.Now;
            time.AddHours(5);
            Mother mother = new Mother("Hayriye");
            Father father = new Father("Hayri");
            Sister sister = new Sister("Elif");
            Cat cat = new Cat("Tekir");
            FamilyMember[] fm = {mother, father, sister,cat};
            Console.WriteLine($"Abuzer sessizce kapıyı açıyor saat: {time.AddHours(1)}");
            foreach (var item in fm)
            {
                item.React(time);               
            } 
            GrandFather.GrandFaReact();
        }
    }
}
