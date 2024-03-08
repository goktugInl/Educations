// See https://aka.ms/new-console-template for more information


//Degiskenler();
using Business.Concrete;
using Entities.Concrete;

Computer pc = new();

Console.WriteLine("Hello, World!");
Console.ReadLine();
SelamVer(isim: "Bahattin"); // Sadece işlemi yapar
int sonuc = Topla(3,5); // Geriye dönen değeri değişkene atama

static void Degiskenler()
{// Blok
    string mesaj = "Merhaba";
    double tutar = 100000; //db'den gelir
    int sayi = 100;
    bool checkAuth = false;
}

// Examp: Diziler(Array)
string ogrenci1 = "Goktug";
string ogrenci2 = "Kerem";
string ogrenci3 = "Mahmut";
Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Goktug";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Mahmut";

ogrenciler = new string[4];
ogrenciler[3] = "Orhan";
for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

// ***** DEĞER TİPLER ve REFERANS TİPLER
// Daha sonra ekleme. Ancak daha sonra program çalıştığında Array sonuncuyu gösterir.
// Ram bellekde 2 adet yer vardır. Stack ve Heap. "C" dilindeki Pointer'lar gibi.
// Eğer ogrenciler arry'ini new demeden [0],[1],[2]... alanlarına değer atanırsa "NullReferanceException" hatası alınır.
// string[] ogrenciler bu sekilde sadece belleğin "Stack" bölümünde durur.
// string[] ogrenciler = new string[3] bu şekilde "Heap" bölümünde 3 adet elemanlı array açılır.
// Heap her değer için bir adres tanımlar. 101.. gibi.
// Heap alanında her new yapılınca yeni alan açar ve hep en son oluşan alanı okur.
// Bu yüzden 3 değerli array sonradan 4 değerli olunca geriye kalan 3 değer new yapılınca boş gelir.
// Bellekdeki eski new'lenenleri GarbageCollector daha sonra siler.
///////////////////////////////
// int, double, float, bool gibi değer tipler belleğin Stack bölümünde tutulur.
// Array gibi dize elemanları sahip referans tipler belleğin Heap bölümnde tutulur ve Stack bu değerleri Heap'den okur.
// stirng - bir referans tiptir. Yani "Char Array".

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
//sayi2 kaçtır ? Cvp: 10 olur. Çünkü referans tiplerde ne atanırsa onu taşır. 

string[] sehiler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehiler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

foreach (string sehir in sehiler1)
{
    Console.WriteLine(sehir); // Buradaki "sehir" değişkeni array içindeki her elemanı gezen takma isimdir diğer adı ile "Alias".
}

//.Net Framework 2'den sonra gelen Generic Collection yapısı. Array yerine en çok tercih edilen.
// Generic Collection'lar tip güvenli yapılardır.
List<string> yeniSehiler = new List<string> { "Adana", "Diyarbakır", "İstanbul"};
yeniSehiler.Add("İzmir");



/////////////////////////////////////////////////
PersonelComputer personelComputer1 = new PersonelComputer();
personelComputer1.GraphicDrive = "Nvidia RTX 4060";
personelComputer1.CPU = "Amd Ryzen 5";
personelComputer1.RAM = 16;
personelComputer1.SSD = 512;
XBilisimAsManager xBilisimManager = new XBilisimAsManager(new PCManager());
xBilisimManager.GivePC(personelComputer1);

//////////////////////////////////////////////////////////////////
static void SelamVer(string isim="NoName") // Parantez içindekine "Parametre" denir. Atanan değer default parametredir.
{// Blok
    Console.WriteLine("Merhaba" + isim);
}

// Geriye Değer Döndüren Fonksiyon
static int Topla(int sayi1, int sayi2)
{// Blok
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Topla : " + sonuc);
    return sonuc;
}

class Computer
{// Blok"""
    /// <summary>
    /// Exap;
    /// get ve set değiştirmek için
    /// get {
    ///  /////
    /// }
    /// set {
    ///  /////
    /// }
    /// </summary>
    public string CPU {  get; set; }
    public string GraphicDrive { get; set; }
    public int Ram { get; set; }
    public int SSD {  get; set; }
}