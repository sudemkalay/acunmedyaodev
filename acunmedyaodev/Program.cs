using System;
using acunmedyaodev.Abstract;
using acunmedyaodev.classes; // Araç sınıflarını içe aktarıyoruz
using odev2._2.classes;     // Çalışan sınıflarını içe aktarıyoruz

class Program
{
    static void Main(string[] args)
    {
        // Araç nesneleri oluşturuluyor ve özellikler atılıyor
        Araba a = new Araba();
        BMW bm = new BMW();
        Mercedes me = new Mercedes();
        Porsche p = new Porsche();
        Audi au = new Audi();
        Togg t = new Togg();
        Toyota to = new Toyota();

        // BMW kısmı
        bm.marka = "BMW";
        bm.vites = "Düz";
        bm.Print();

        // Mercedes kısmı
        me.marka = "Mercedes";
        me.vites = "Otomatik";
        me.Print();

        // Porsche kısmı
        p.marka = "Porsche";
        p.vites = "Otomatik";
        p.Print();

        // Audi kısmı
        au.marka = "Audi";
        au.vites = "Otomatik";
        au.Print();

        // Togg kısmı
        t.marka = "Togg";
        t.vites = "Düz";
        t.Print();

        // Toyota kısmı
        to.marka = "Toyota";
        to.vites = "Düz";
        to.Print();

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


    }


}




//Array nedir?
//C#'ta aynı türdeki verileri tek bir değişken içinde saklamamızı sağlayan bir yapıdır.
//Mesela, birden fazla öğrencinin notlarını ayrı ayrı değişkenlerde tutmak yerine, hepsini bir dizi içinde saklayabiliriz.
//Diziler sıfırdan başlayarak numaralandırılan (indekslenen) kutular gibi çalışır.
