
//Text examples 
Console.WriteLine("Hello, World!"); //string 
Console.Write("Alperen Kızılarslan");
Console.WriteLine(" Hoş Geldin");

//Number examples 
Console.WriteLine(5 + 5);
Console.WriteLine(10 / 2);

//Comments examples
//This is a comment line / satırın başında yada satırın sonunda kullanılabilir 
Console.WriteLine("Merhaba Dünya"); //Çift slash den sonrası yorum satırı 

/* Bu kod ekrana "Merhaba C#" 
yazdırılmasını Sağlar */
Console.WriteLine("Merhaba C#");

/* Variable Examples 
int - stores integers (whole numbers), without decimals, such as 123 or -123
double - stores floating point numbers, with decimals, such as 19.99 or -19.99
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false */

string name = "Merve";
Console.WriteLine(name);

int myNum = 23;
Console.WriteLine(myNum);

int myNewNum;
myNewNum = 44;
Console.WriteLine(myNewNum);

int myNumber = 2344;
myNumber = 4423;
Console.WriteLine(myNumber);

// Other Types 
int sayi1 = 10;
double myDouble = 10.15D;
char myChar = 'A';
bool myBool = true;
string myString = "Aktaş";

// Constant Examples 
const int myInt = 20;
//myInt = 25; // error vericektir. Çünkü değişken sabit olarak tanımlanmış 
//Değer atanmamış bir sabit değişken tanımlanamaz 

//Display Variables 
string name1 = "Alperen";
Console.WriteLine("Hello " + name1);

string firstName = "Süslü";
string lastNeme = " Kızılarslan";
string fullName = firstName + lastNeme;
Console.WriteLine(fullName);

int x = 10;
int y = 12;
Console.WriteLine(x + y);

//Declare Many Variables 
int a = 10, b = 5, c = 7;
Console.WriteLine(a + b + c);

int k, l, m;
k = l = m = 100;
Console.WriteLine(k + l + m);



Console.ReadKey();

