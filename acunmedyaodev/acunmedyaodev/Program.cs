// See https://aka.ms/new-console-template for more information
using acunmedyaodev.classes;

Console.WriteLine("Hello, World!");


Araba a = new Araba();

BMW bm = new BMW();

Mercedes me = new Mercedes();

Porsche p = new Porsche();

Audi au = new Audi();

Togg t = new Togg();

Toyota to = new Toyota();



//bmw kısmı
bm.marka = "BMW";
bm.vites = "Düz";
bm.Print();


//mercedes kısmı
me.marka = "Mercedes";
me.vites = "Otomatik";
me.Print();

p.marka = "Porsche";
p.vites = "Otomatik";
p.Print();

au.marka = "Audi";
au.vites = "Otomatik";
au.Print();

t.marka = "Togg";
t.vites = "Düz";
t.Print();

to.marka = "Toyota";
to.vites = "Düz";
to.Print();



//diğerlerine marka adı atadık ama yukarıdaki şekilde devam ettirerek istersek yazdırabiliriz.
me.marka = "Mercedes";
p.marka = "Porsche";
au.marka = "Audi";
t.marka = "Togg";
to.marka = "Toyota";




// Abstract Class (Soyut Sınıf)

// Bir sınıfın içeriğini tam olarak belirlemeden. sadece bir şablon oluşturmak için kullanılır. 
//  Abstract class’lar, doğrudan bir nesne oluşturamaz. Onları miras alarak (inheritance) kullanırız.

//Abstraction (Soyutlama)

// Abstraction, gereksiz detayları gizleyerek sadece önemli kısımları göstermeye denir. Abstract class veya interface kullanarak yapılır.

//Polymorphism (Çok Biçimlilik)

// Polymorphism, aynı metodu farklı şekillerde kullanabilmeyi sağlar.
// Bu sayede aynı kodu yazıp farklı sonuçlar alabiliriz.