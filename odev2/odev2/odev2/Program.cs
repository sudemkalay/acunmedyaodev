using acunmedyaodev.Abstract;
using odev2._2.classes;
using odev2.classes;

Console.WriteLine("Hello, World!");

Araba a = new Araba();
Audi au = new Audi();
Mercedes me = new Mercedes();
Bmw b = new Bmw();

b.Marka = "Bmw";
me.Marka = "Mercedes";
au.Marka = "Audi";

Console.WriteLine("Bmw'nin hareketleri:");
b.Drive();
b.FloatOnWater();
b.Fly();

Console.WriteLine("Mercedes'in hareketleri:");
me.Drive();
me.FloatOnWater();
me.Fly();

Console.WriteLine("Audi'nin hareketleri:");
au.Drive();
au.FloatOnWater();
au.Fly();


Console.WriteLine("------------------");

// Çalışan nesneleri oluşturuluyor
GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programcı pr = new Programcı();
Stajyer st = new Stajyer();

// Çalışan maaşları hesaplanıyor
double toplamMaas = gm.MaasinizNedir() + mu.MaasinizNedir() + pr.MaasinizNedir() + st.MaasinizNedir();

// Çalışan maaşları ekrana yazdırılıyor
Console.WriteLine("Çalışan maaşları:");
Console.WriteLine("Genel Müdür: " + gm.MaasinizNedir());
Console.WriteLine("Müdür: " + mu.MaasinizNedir());
Console.WriteLine("Programcı: " + pr.MaasinizNedir());
Console.WriteLine("Stajyer: " + st.MaasinizNedir());

// Toplam maaş ekrana yazdırılıyor
Console.WriteLine("Toplam Maaş: " + toplamMaas);

Console.WriteLine("------------------");

BMW2 bm2 = new BMW2();
Mercedes2 me2 = new Mercedes2();
Porsche2 po2 = new Porsche2();

double toplamYakıt = 0.0;

toplamYakıt += bm2.yakıtTuketım();
toplamYakıt += me2.yakıtTuketım();
toplamYakıt += po2.yakıtTuketım();

Console.WriteLine("Toplam:" + toplamYakıt + "L benzin harcıyorlar.");


//Array nedir?
//C#'ta aynı türdeki verileri tek bir değişken içinde saklamamızı sağlayan bir yapıdır.
//Mesela, birden fazla öğrencinin notlarını ayrı ayrı değişkenlerde tutmak yerine, hepsini bir dizi içinde saklayabiliriz.
//Diziler sıfırdan başlayarak numaralandırılan (indekslenen) kutular gibi çalışır.


