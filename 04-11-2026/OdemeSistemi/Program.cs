namespace OdemeSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int count = 1;
            Yemek[] yemekler = SahteYemekleriOlustur();
            while (count<10)
            {
                Kasa.Start(ref yemekler);
                count++;
            }

            Console.WriteLine($"Kredi Kartı ile ödeme: {KrediKartiOdeme.KrediKartiOdemeSayisi}, Havale/EFT ile ödeme: {HavaleOdeme.HavaleOdemeSayisi}, Toplam: {OdemeYontemi.ToplamIslemSayisi}");
        }

        public static Yemek[] SahteYemekleriOlustur()
        {
            return new Yemek[]
        {
            new Yemek("Mercimek Çorbası", 95.0, 100),
            new Yemek("Ezogelin Çorbası", 100.0, 100),
            //new Yemek("Yayla Çorbası", 95.0, 10),
            //new Yemek("İşkembe Çorbası", 160.0, 10),
            //new Yemek("Domates Çorbası", 105.0, 10),
            //new Yemek("Adana Kebap", 380.0, 100),
            //new Yemek("Urfa Kebap", 370.0, 50),
            //new Yemek("İskender Kebap", 440.0, 100),
            //new Yemek("Beyti Sarma", 420.0, 10),
            //new Yemek("Ali Nazik", 390.0, 10)
        };
        }
    }
}
