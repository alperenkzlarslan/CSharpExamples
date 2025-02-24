////Text examples 
//Console.WriteLine("Hello, World!"); //string 
//Console.Write("Alperen Kızılarslan");
//Console.WriteLine(" Hoş Geldin");

////Number examples 
//Console.WriteLine(5 + 5);
//Console.WriteLine(10 / 2);

////Comments examples
////This is a comment line / satırın başında yada satırın sonunda kullanılabilir 
//Console.WriteLine("Merhaba Dünya"); //Çift slash den sonrası yorum satırı 

///* Bu kod ekrana "Merhaba C#" 
//yazdırılmasını Sağlar */
//Console.WriteLine("Merhaba C#");

///* Variable Examples 
//int - stores integers (whole numbers), without decimals, such as 123 or -123
//double - stores floating point numbers, with decimals, such as 19.99 or -19.99
//char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
//string - stores text, such as "Hello World". String values are surrounded by double quotes
//bool - stores values with two states: true or false */

//string name = "Merve";
//Console.WriteLine(name);

//int myNum = 23;
//Console.WriteLine(myNum);

//int myNewNum;
//myNewNum = 44;
//Console.WriteLine(myNewNum);

//int myNumber = 2344;
//myNumber = 4423;
//Console.WriteLine(myNumber);

//// Other Types 
//int sayi1 = 10;
//double myDouble = 10.15D;
//char myChar = 'A';
//bool myBool = true;
//string myString = "Aktaş";

//// Constant Examples 
//const int myInt = 20;
////myInt = 25; // error vericektir. Çünkü değişken sabit olarak tanımlanmış 
////Değer atanmamış bir sabit değişken tanımlanamaz 

////Display Variables 
//string name1 = "Alperen";
//Console.WriteLine("Hello " + name1);

//string firstName = "Süslü";
//string lastNeme = " Kızılarslan";
//string fullName = firstName + lastNeme;
//Console.WriteLine(fullName);

//int x = 10;
//int y = 12;
//Console.WriteLine(x + y);

////Declare Many Variables 
//int a = 10, b = 5, c = 7;
//Console.WriteLine(a + b + c);


//#region  toplama
//int k, l, m;
//k = l = m = 100;
//Console.WriteLine(k + l + m);
//#endregion


//// Değişkenler açıklayıcı olmalıdır 
//double piNumber = 3.14;
//Console.WriteLine(piNumber);

/*

#region Float example 
// Sonda F kullanılmalı 
float myFloat = 40.55F;
Console.WriteLine(myFloat);
#endregion


#region Double example 
// Sonunda D kullanılmalı 
double myNewDouble = 23.958D;
Console.WriteLine(myNewDouble);
#endregion



////Bilimsel Sayılar / e den sonraki sayı 10 üzeri demek 
//float f1 = 35e3F; // 35 x 10 üzeri 3 
//double d1 = 12E4D; // 12 x 10 üzeri 4 
//Console.WriteLine(f1);
//Console.WriteLine(d1);

//// Bool Exmaples 
//bool winner = true;
//bool loser = false;
//Console.WriteLine(winner);
//Console.WriteLine(loser);

////Char Examples 
//char singleLetter = 'a'; //char veri tipi tek tırnak içine yazılır tek bir harf tutabilir 
//Console.WriteLine(singleLetter);

////String Examples 
//string nickname = "hyperbird";
//Console.WriteLine(nickname);

////Type Casting - veri tipi dönüşümü 
////Implicit - otomatik dönüşüm - küçük sayıdan büyük sayıya 
//int number2 = 9;
//double number3 = number2;
//Console.WriteLine(number2);
//Console.WriteLine(number3);

////exclipt - manuel dönüşüm - büyük tipten küçük tipe 
//double number4 = 15.65;
//int number5 = (int)number4;
//Console.WriteLine(number4);
//Console.WriteLine(number5);

//// Açık veri tipi dönüşümü 
//Console.WriteLine(Convert.ToString(number2));
//Console.WriteLine(Convert.ToInt32(number4));

//// İnput Alma Kullanıcıdan 
//Console.WriteLine("Enter Username: ");
//string userName = Console.ReadLine();
//Console.WriteLine("Username is: " + userName);

//Console.WriteLine("Lütfen Yaşınızı Giriniz: ");
//int userAge = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Kullanıcı Yaşı: " + userAge);

////Operators Examples 
//// + toplama, - çıkarma, * çarpma, / bölme, % mod alma, ++ 1 arttırma, -- 1 eksiltme. 
//int number6 = 100 + 60;
//int number7 = 40 + number6;
//int number8 = number6 + number7;
//int number9 = number8 * 5 - 10;
//Console.WriteLine(number6);
//Console.WriteLine(number7);
//Console.WriteLine(number8);
//Console.WriteLine(number9);

////Assignment Operators 
//int number10 = 410; // = atama operatörü 
//number10 += 10; // sayıya verilen değeri ekleyip değişkene atar, -= eksiltip atar, *= çarpıp atama yapar, /= bölüp atar
//// %= modunu alıp atar  

//// Karşılaştırma Operatörleri 
//// ==,!=, >, <, >=, <=

//// Math methods 
//Console.WriteLine(Math.Max(10, 15));
///* Math.Max(x,y) = En büyük sayıyı alır 
//Math.Min(x,y) = En küçük sayıyı alır 
//Math.Sqrt(x) = Sayının karesini alır 
//Math.Abs(x) = Sayının Mutlak değerini alır 
//Math.Round() = Sayıyı en yakın sayıya yuvarlar 



// */



#region çıktı sorusu 
var xyz = "5";
var uip = 45;
Console.WriteLine(xyz + uip);
#endregion


#region string örnekleri 
string ornek1 = "Hello";
string ornek2 = "Merhabalar! Adınız Nedir ?";

Console.WriteLine("ornek2 stringinin uzunluğu: " + ornek2.Length);
Console.WriteLine(ornek1.ToUpper());
Console.WriteLine(ornek1.ToLower());

string firstName = "Alperen";
string lastName = " Kızılarslan";
string fullName = firstName + lastName;
Console.WriteLine(fullName);

string name = "Merve ";
string lastname = "Aktaş";
string allName = string.Concat(name, lastname);
Console.WriteLine(allName);

int x = 10; //İnt ler birbirlerine eklenir 
int y = 20;
int z = x + y;
Console.WriteLine(z);

string x1 = "10"; //stringler birbirleri ile birleştirilir 
string y1 = "20";
string z1 = x1 + y1;
Console.WriteLine(z1);

string myString = "Merhaba";
Console.WriteLine("Kelimenin ilk harfi: " + myString[0]);
Console.WriteLine("a harfinin indeksi: " + myString.IndexOf("a"));
string ad = "Alperen Kızılarslan";
int charPos = ad.IndexOf("K");
string soyad = ad.Substring(charPos);
Console.WriteLine(soyad);

//Escape Character - Backslash \
string txt = "Alperen 'in \"maviş\" adında bir kedisi vardı.";
Console.WriteLine(txt);

string parca = "Bu parçanın 1. satırı \nBu parçanın 2. satırı"; // \n yeni satıra geçer 
Console.WriteLine(parca);
string paragraf = "Paragrafın 1. satırı \n\tParagrafın 2. satırı"; // \t bir tab boşluk bırakır 
Console.WriteLine(paragraf);
string myNewString = "Merhaba C\b#"; // \b backspace yapar 
Console.WriteLine(myNewString);
#endregion


#region Boolean Örnekleri
bool evet = true;
bool hayır = false;
Console.WriteLine(evet);
Console.WriteLine(hayır);

int sayi1 = 10;
int sayi2 = 5;
Console.WriteLine(sayi1 > sayi2);

Console.WriteLine(sayi1 == 10);
Console.WriteLine(sayi2 == 15);

int myAge = 22;
int myVotingAge = 18;
Console.WriteLine(myAge >= myVotingAge);

if (myAge >= myVotingAge)
{
    Console.WriteLine("Yaşı yeterli oy kullanabilir.");
}
else
{
    Console.WriteLine("Yaşı 18'den küçük oy kullanamaz.");
}


#endregion


#region if else örnekleri

if (44 > 23)
{
    Console.WriteLine("44 sayısı 23 sayısından büyüktür");
}

int a = 15;
int b = 20; 
if (b > a)
{
    Console.WriteLine("B sayısı A dan daha büyüktür");
}

int saat = 16;
if (saat <= 12)
{
    Console.WriteLine("Günaydın");
}
else
{
    Console.WriteLine("Tünaydın");
}

int puan = 65; 
if (puan > 70)
{
    Console.WriteLine("Dersten başarıyla geçtiniz");
}
else if (puan >= 50)
{
    Console.WriteLine("Dersten sorumlu geçtiniz");
}
else
{
    Console.WriteLine("Dersten kaldınız");
}

int zaman = 20;
string result = (zaman < 18) ? "İyi Günler" : "İyi Akşamlar";
Console.WriteLine(result);
    #endregion











    Console.ReadKey();

