using OOP_NesneyeYönelikProgramlama_;
using OOP_NesneyeYönelikProgramlama_.Abstract;
using OOP_NesneyeYönelikProgramlama_.Arabalar;
using OOP_NesneyeYönelikProgramlama_.Constructor;
using OOP_NesneyeYönelikProgramlama_.Overrides;
using OOP_NesneyeYönelikProgramlama_.Sirket;
using System.Collections;
//using OOP_NesneyeYönelikProgramlama_.Odev;
//using OOP_NesneyeYönelikProgramlama_.Sirket;
//using OOP_NesneyeYönelikProgramlama_.Abstract;

//Insan i = new Insan();
//i.Ad = "Alperen";
//i.Soyad = "Sener";
//i.Yas = 44;
//i.Maas = 8500;
//i.Cinsiyet = true;
//i.Dogumyılı = 1978;
////i.Uyu(i.Ad, i.Soyad);
////i.YasHesaplama(i.Dogumyılı);
////i.Mesaj(i.Ad, i.Soyad);

//Insan i4 = new Insan("Metin", "Yılmaz", 44, 3.14, true);



//Araba araba = new Araba();
//araba.Marka = "BMW";
//araba.Model = "X5";
//araba.KapiSayisi = 4;
//araba.ModelYili = 2022;
//araba.Git(araba.Marka, araba.Model);

//Matematik m = new Matematik();
//m.Topla(5, 5);
//m.Cikar(4, 5);
//m.Carpma(4, 5);
//m.Bolme(4, 5);


//Anne anne = new Anne();
//anne.Ad = "Hulya";
//anne.Soyad = "Sener";
//anne.Mesaj(anne.Ad, anne.Soyad);

//AkilliCocuk akilli = new AkilliCocuk();
//akilli.Ad = "Hakan";
//akilli.Soyad = "Yılmaz";
//akilli.Sifat = "Akıllıdır";

//akilli.CocukMesaj(akilli.Ad, akilli.Soyad, akilli.Sifat);
//akilli.AskereGit(akilli.Ad);
//akilli.ClubeGit(akilli.Ad);
//akilli.EhliyetAl(akilli.Ad);

//UsluCocuk uslu = new UsluCocuk();
//uslu.Ad = "Mehmet";
//uslu.Soyad = "Yılmaz";
//uslu.Sifat = "Usludur";

//uslu.AskereGit(uslu.Ad);
//uslu.EhliyetAl(uslu.Ad);

//Araba araba = new Araba();
//araba.Marka = "BMW";
//araba.Model = "X5";
//araba.KapiSayisi = 4;
//araba.ModelYili = 2022;
//araba.Git(araba.Marka, araba.Model);

//Bmw bmw = new Bmw();
//bmw.Marka = "Bmw";
//bmw.Model = "X5";
//bmw.Odev(bmw.Marka, bmw.Model);


//Bmw bmw = new Bmw();
//bmw.Marka = "Bmw";
//bmw.Model = "X5";
//bmw.Odev(bmw.Marka, bmw.Model);
//bmw.CokHizli(bmw.Marka);
//bmw.DenizdeYuz(bmw.Marka);
//bmw.CokHizli(bmw.Marka);


//Mercedes mercedes = new Mercedes();
//mercedes.Marka = "Mercedes";
//mercedes.Model = "XL";
//mercedes.Odev(mercedes.Marka, mercedes.Model);
//mercedes.HavadaUc(mercedes.Marka);
//mercedes.CokHizli(mercedes.Marka);

//GenelMudur genelMudur = new GenelMudur();
//genelMudur.Maas = 40000;
//genelMudur.MaasHesapla(genelMudur.Maas);

//Mudur mudur = new Mudur();
//mudur.Maas = 30000;
//mudur.MaasHesapla(mudur.Maas);

//Programci programci = new Programci();
//programci.Maas = 15000;
//programci.MaasHesapla(programci.Maas);

//Stajyer stajyer = new Stajyer();
//stajyer.Maas = 2000;
//stajyer.MaasHesapla(stajyer.Maas);


//Personel personel = new Personel();

//personel.Hesapla(stajyer.Maas + genelMudur.Maas + mudur.Maas + programci.Maas);


//GenelMudur gm = new GenelMudur();
//Mudur mudur = new Mudur();
//Programci programci = new Programci();
//Stajyer stajyer = new Stajyer();

//int sonuc = 0;
//sonuc += gm.MaasinizNedir();
//sonuc += mudur.MaasinizNedir();
//sonuc += programci.MaasinizNedir();
//sonuc += stajyer.MaasinizNedir();

//Calisan[] calisans= { gm, mudur, programci, stajyer};
//int calisanmaastoplam = 0;
//for (int i = 0; i < calisans.Length; i++)
//{
//	calisanmaastoplam += calisans[i].MaasinizNedir();
//}
//Console.WriteLine(calisanmaastoplam);

//Bmw bmw = new Bmw();
//Mercedes mercedes = new Mercedes();
//Porche porche = new Porche();
//double sonuc = 0;
//sonuc += bmw.BenzinKullanimi();
//sonuc += mercedes.BenzinKullanimi();
//sonuc += porche.BenzinKullanimi();
//Console.WriteLine("Benzim Kullanımı: " + sonuc);

//Arabalar[] arabalars = {bmw, mercedes, porche};
//double toplamBenzin = 0;
//for (int i = 0; i < arabalars.Length; i++)
//{
//	toplamBenzin = toplamBenzin + arabalars[i].BenzinKullanimi();
//}
//Console.WriteLine(toplamBenzin);

//Child child= new Child();
//child.Yaz();




//YeniInsan consturctor
//Goz goz = new Goz("Mavi");
//Kulak kulak = new Kulak("Kepçe");
//Burun burun = new Burun("Kemer");
//Kafa kafa = new Kafa(goz, kulak, burun);
//YeniInsan yeniInsan = new YeniInsan(kafa, "Alp", "Şener");
//yeniInsan.Yaz();


//string[] gunler = new string[7];
//gunler[0] = "Pazartesi";
//gunler[1] = "Salı";
//gunler[2] = "Çarşamba";
//gunler[3] = "Perşembe";
//gunler[4] = "Cuma";
//gunler[5] = "Cumartesi";
//gunler[6] = "Pazar";

//for (int i = 0; i < gunler.Length; i++)
//{
//	Console.WriteLine(gunler[i]);
//}


//int[] sayilar = { 2, 4, 5, 7, 11, 22, 33, 44, 55, 66, 77 };

//int sonuc = 0;

//for (int i = 0; i < sayilar.Count(); i++)
//{
//	sonuc = sayilar[i] + sonuc;

//}
//Console.WriteLine(sonuc);


//List<Personel> personel = new() { 
//	new() { Ad = "Alperen", Soyad="Şener", Cinsiyet=true, Dogumyılı=2002, Maas=10,  Pozisyon="bOŞ", Yas=20},
//	new() { Ad = "A1",      Soyad="Ş1",    Cinsiyet=true, Dogumyılı=2002, Maas=10,  Pozisyon="bOŞ", Yas=20},
//	new() { Ad = "A2",      Soyad="Ş2",    Cinsiyet=true, Dogumyılı=2002, Maas=10,  Pozisyon="bOŞ", Yas=20},
//	new() { Ad = "A3",      Soyad="Ş3",    Cinsiyet=true, Dogumyılı=2002, Maas=10,  Pozisyon="bOŞ", Yas=20},
//	new() { Ad = "A4",      Soyad="Ş4",    Cinsiyet=true, Dogumyılı=2002, Maas=10, Pozisyon="bOŞ", Yas=20}
//};

//int toplamMaas=0;

//for (int i = 0; i < personel[4].Maas; i++)
//{
//	toplamMaas = toplamMaas + personel.Count();

//}
//Console.WriteLine(toplamMaas);




//ArrayList liste= new ArrayList();
//liste.Add(1);
//liste.Add("SFSAFSA");
//foreach(object o in liste)
//{
//	Console.WriteLine(o);
//}	

//List<Personel> personelList = new() {
//	new() { Ad = "Alperen", Soyad="Şener", Cinsiyet=true, Dogumyılı=2002, Maas=10,  Pozisyon="bOŞ", Yas=20},
//	new() { Ad = "A1",      Soyad="Ş1",    Cinsiyet=true, Dogumyılı=2002, Maas=10,  Pozisyon="bOŞ", Yas=20},
//	new() { Ad = "A2",      Soyad="Ş2",    Cinsiyet=true, Dogumyılı=2002, Maas=10,  Pozisyon="bOŞ", Yas=20},
//	new() { Ad = "A3",      Soyad="Ş3",    Cinsiyet=true, Dogumyılı=2002, Maas=10,  Pozisyon="bOŞ", Yas=20},
//	new() { Ad = "A4",      Soyad="Ş4",    Cinsiyet=true, Dogumyılı=2002, Maas=10, Pozisyon="bOŞ", Yas=20}
//};

//foreach (Personel personel in personelList)
//{
//	Console.WriteLine(personel.Ad + " " +personel.Soyad + " " + personel.Pozisyon+ " " + personel.Maas + " " + personel.Cinsiyet + " " + personel.Dogumyılı);
//}
