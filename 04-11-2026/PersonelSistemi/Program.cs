using PersonelSistemi;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;

Mudur m1 = new Mudur("Süleyman Çakır");
Console.WriteLine(m1.Name+ " Maaşı:"+m1.MudurMaasHesapla());
Mudur m2 = new Mudur("Polat Alemdar");
Console.WriteLine(m2.Name + " Maaşı:" + m2.MudurMaasHesapla());
Mudur m3 = new Mudur("Elif Eylül");
Console.WriteLine(m3.Name + " Maaşı:" + m3.MudurMaasHesapla());
Mudur m4 = new Mudur("Memati Baş");
Console.WriteLine(m4.Name + " Maaşı:" + m4.MudurMaasHesapla());

Hizmetli h1 = new Hizmetli("Mehmet Karahanlı");
Console.WriteLine(h1.Name + " Maaşı:" + h1.MaasHesapla());
Hizmetli h2 = new Hizmetli("Kılıç Ali");
Console.WriteLine(h2.Name + " Maaşı:" + h2.MaasHesapla());

Pazarlama p1 = new Pazarlama(595045, "Abdulhey Çoban");
Console.WriteLine(p1.Name + " Maaşı:" + p1.MaasHesapla());
Pazarlama p2 = new Pazarlama(1595045, "Erhan Ufak");
Console.WriteLine(p2.Name + " Maaşı:" + p2.MaasHesapla());
Pazarlama p3 = new Pazarlama(895045, "Laz Ziya");
Console.WriteLine(p3.Name + " Maaşı:" + p3.MaasHesapla());
Pazarlama p4 = new Pazarlama(-95045, "Hüsrev Ağa");
Console.WriteLine(p4.Name + " Maaşı:" + p4.MaasHesapla());
Pazarlama p5 = new Pazarlama(2595045, "Gıcık Cahit");
Console.WriteLine(p5.Name + " Maaşı:" + p5.MaasHesapla());

Console.WriteLine("Şirket Genel Bilgileri");
Console.WriteLine($"Toplam Maaş Gideri: {PersonelBase.TotalMaas:c2}");
Console.WriteLine($"Toplam Satış Tutarı: {PersonelBase.TotalSatis:c2}");
Console.WriteLine($"Toplam Personel Sayısı: {PersonelBase.Count}");


Console.WriteLine($"Toplam Müdür Sayısı: {Mudur.CountM}");
Console.WriteLine($"Toplam Hizmetli Sayısı: {Hizmetli.CountH}");
Console.WriteLine($"Toplam Pazarlamacı Sayısı: {Pazarlama.CountP}");





