﻿// program 1
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





