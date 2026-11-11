using BankSystem;


/*
 * Amaç: Kapsülleme, Miras, const, readonly ve static kavramlarını tek bir konsol projesinde uygulamak.
 * GörevlerSabitler (const & readonly):
Tüm hesaplar için ortak olan banka adı için const kullanın.
Hesaba ait IBAN veya hesap açılış tarihi için sonradan değiştirilemeyen readonly kullanın.
Sınıf Üyeleri (static):
Sistemdeki toplam açılan hesap sayısını takip eden bir static sayaç oluşturun.
Bankanın genel bilgilerini yazdıran BankaBilgisiGoster() adında static bir metot yazın.
Kapsülleme (Encapsulation):
bakiye alanını private yapın, Property (get/set) ile dışarı açın.
Kural: Para çekme veya bakiye güncelleme işlemlerinde bakiyenin 0'ın altına düşmesini engelleyin; negatif bakiye atanamasın.
Miras (Inheritance):
Ortak özellikleri barındıran temel bir BankaHesabi sınıfı yazın.
Bu sınıftan türeyen VadesizHesap (Ek olarak EkHesapLimiti) ve YatirimHesabi (Ek olarak KomisyonOrani) alt sınıflarını oluşturun.


Nesneler üretin, para yatırma/çekme işlemleri yapın, hatalı bakiye çekme girişimlerini test edin ve toplam hesap sayısını ekrana yazdırın.
 */

Console.OutputEncoding = System.Text.Encoding.UTF8;
Customer musteri = new Customer("Bilal", "Demir", "11111111111", "1234");
VadeliAccount vadeli = new VadeliAccount(10000, musteri, "7896");
VadeliAccount vadeli2 = new VadeliAccount(10000, musteri, "789");
VadesizAccount vadesiz = new VadesizAccount(50000, musteri, "78");
VadesizAccount vadesiz2 = new VadesizAccount(50000, musteri, "7896");
Console.WriteLine(musteri);
VadeliAccount secim = null;
VadesizAccount secimV = null;

string hesapTuru = Input.stringAl("Vadeli(E) hesaptamı Vadesiz(H) hesapta mı işlem yapmak istiyorsunuz?");
if (hesapTuru.Equals("E"))
{
    int index = Input.sayiAl("İşlem Yapmak İstediğiniz Vadeli Hesap Numarasını Yazınız");
    secim = musteri.AccountsF[index-1];
    while (true)
    {
        int islem = Input.sayiAl("İşlem Seçiniz\n1-Para yatır\n2-Para Çek\n3- Bilgi Al");
        switch (islem)
        {
            case 1:
                {
                    decimal miktar = Input.decimalAl("Yatırmak istediğiniz tutarı giriniz.");
                    secim.ParaYatir(miktar);
                    break;
                }
            case 2:
                {
                    decimal miktar = Input.decimalAl("Çekmek istediğiniz tutarı giriniz.");
                    secim.ParaCek(miktar);
                    break;
                }
            case 3: Console.WriteLine(secim); break;
            default: Console.WriteLine("Böyle bir işlem yok..."); return;
        }
    }

}
else if (hesapTuru.Equals("H"))
{
    int index = Input.sayiAl("İşlem Yapmak İstediğiniz Vadesiz Hesap Numarasını Yazınız");
    secimV = musteri.Accounts[index-1];



}





