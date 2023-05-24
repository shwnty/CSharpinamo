// program 1
Console.WriteLine("Name: Shawn Tyrone D. Rada");

//program 2
Console.WriteLine("Name: " + "Shawn Tyrone D. Rada");

//program 3
string name = "Shawn Tyrone D. Rada";
Console.WriteLine("Name: " + name);

//program 4
Console.WriteLine($"Name: {name}");

//program 5

string nameko = "Shawn";
string namegf = "Mary";

Console.WriteLine($"Ako si {nameko} at miss ko na si {namegf}.");

//program 6
Console.WriteLine($"The Name {nameko} has {nameko.Length} Letters");
Console.WriteLine($"The Name {namegf} has {namegf.Length} Letters");

Console.WriteLine("supot si aj");

//program 7
String myString = "    Halaman    ";
Console.WriteLine($"[{myString}]");

String putol = myString.TrimStart();
Console.WriteLine($"[{putol}]");

putol = myString.TrimEnd();
Console.WriteLine($"[{putol}]");

putol = myString.Trim();
Console.WriteLine($"[{putol}]");

//program 8
String word = "supot si dominic";
Console.WriteLine($"{word}");

String halaman = word.Replace("dominic", "aj");
Console.WriteLine($"{halaman}");

//program 9
Console.WriteLine($"{name.ToUpper()}");

Console.WriteLine($"{name.ToLower()}");

//program 10

var sentence = "itlog ng manok ay bilog";
Console.WriteLine(sentence.Contains("bilog"));
Console.WriteLine(sentence.Contains("menek"));

//program 11
Console.WriteLine(sentence.StartsWith("itlog"));
Console.WriteLine(sentence.StartsWith("logit"));

//program 12
Console.WriteLine(sentence.EndsWith("bilog"));
Console.WriteLine(sentence.EndsWith("logbi"));

//program 13
int a = 7;
int b = 5;

//addition
int add = a + b;
Console.WriteLine($"{add}");

//subtraction
int sub = a - b;
Console.WriteLine($"{sub}");

//multiplication
int multi = a * b;
Console.WriteLine($"{multi}");

//division
int divA = 72;
int divB = 2;
int div = divA / divB;
Console.WriteLine($"{div}");

// modulus na putangina kung ano ano ren
decimal any = (a + b) * (a - b) + .5m; 
Console.WriteLine($"{any}");

//min max value
int min = int.MinValue;
int max = int.MaxValue;
Console.WriteLine($"{min}");
Console.WriteLine($"{max}");

double minn = double.MinValue;
double maxx = double.MaxValue;
Console.WriteLine($"{minn}");
Console.WriteLine($"{maxx}");

int y = -1;
int x = -2;
int z = 5;
int maxnum = int.MinValue;

if(maxnum < y){
    maxnum = y;
}

if(maxnum < x){
    maxnum = x;
}
if(maxnum < z){
    maxnum = z;
}

Console.WriteLine($"The Maximum Value is {maxnum}");

//program 14, showcase the difference of double and decimal

//Adition
Double ad = 1.012 + 2.23;
Decimal ads = 1.012M + 2.23M;

Console.WriteLine($"{ad}");
Console.WriteLine($"{ads}");

//subtraction
Double subd = 4.02 + 3.11;
Decimal subdec = 4.02M + 3.11M;

Console.WriteLine($"{subd}");
Console.WriteLine($"{subdec}");

//multiplication
Double multD = 1.03 * 2.04;
Decimal multDec = 1.03M * 2.04M;

Console.WriteLine($"{multD}");
Console.WriteLine($"{multDec}");

//Division
double aa = 6;
double bb = 7;

decimal aaa = 6M;
decimal bbb = 7M;

Double Dres = aa / bb;
Decimal DecRes = aaa / bbb;

Console.WriteLine($"{Dres}");
Console.WriteLine($"{DecRes}");

//Modulus
Double ModD = 5.0 %2;
Decimal ModDec = 5.0M %2M;

Console.WriteLine($"{ModD}");
Console.WriteLine($"{ModDec}");





 
 












