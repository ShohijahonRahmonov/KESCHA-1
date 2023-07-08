using KESCHA.Classes;
// // // Console.WriteLine ("Salom !!!");
// // // Console.Write("Ismingizni kiriting: ");
// // // string name  =  Console.ReadLine();
// // // Console.WriteLine($"Salom { name}");
// // // Console.WriteLine(sizeof(ushort));
// // Console.WriteLine($"Shortni MinQiymati: {short.MinValue}");
// // Console.WriteLine($"Shortni MaxQiymati: {short.MaxValue}");
// // Console.WriteLine($"UShortni MaxQiymati {ushort.MaxValue}");
// // Console.WriteLine($"UShortni MinQiymati {ushort.MinValue}");
// // Console.WriteLine($"Intni MaxQiymati: {int.MaxValue}");
// // Console.WriteLine($"Intni MinQiymati {int.MinValue}");
// // Console.WriteLine($"Uintni MaxQiymati {uint.MaxValue}");
// // Console.WriteLine($"Longni MaxQiymati:{long.MaxValue}");
// // Console.WriteLine($"Longni MinQiymati: {long.MinValue}");
// // Console.WriteLine($" ULongni qiymati: {ulong.MaxValue}");
// // bool  isboy = true;
// // Console.WriteLine(isboy);
//  // bir Malumot turini boshqa malumot turiga  kuchirish usulari:
//  //Implicit casting (aftomstic kuchiradi)
// // float pi = 3.14f;
// // double bigPi = pi;
// // Console.WriteLine(pi);
// // Console.WriteLine(bigPi);
// // short age =23;
// // decimal DecimalAge = age;
// // Console.WriteLine(age);
// // Console.WriteLine(DecimalAge);
// // short a = 34;
// // // toString() casting
// // Console.WriteLine(a.ToString());
// // short abc = 345;
// // Console.WriteLine(abc.ToString());
// //   //explicit casting
// // int floratypes = 343434;
// // short types = (short) floratypes;
// // Console.WriteLine(floratypes);
// // Console.WriteLine(types);



// // double floratype = 34.54;
// // short type = (short) floratype;
// // Console.WriteLine(floratype);
// // Console.WriteLine(type);
// // // Convert.TOInt32 metodi 
// // int randomNumber = Convert.ToInt32("56");
// // Console.WriteLine(randomNumber);
// // int inter = Convert.ToInt16("65");
// // Console.WriteLine(inter);
string Login = "";
do
{
    Console.Write("Enter your Login please: ");
    Login = Console.ReadLine();
} while (Login != "Sh0hijAh0n");

Console.WriteLine("Salom foydalanuvchi botimizga hush kelibsiz!!!");
Console.Write("Ro'yhatdan o'tish uchun ismingizni kiriting: ");
string name = Console.ReadLine();
Console.WriteLine($"Salom {name}");
Console.Write("Yoshingizni kiriting: ");
string Age = Console.ReadLine();
Console.WriteLine("Converting....");
short Ages = Convert.ToInt16(Age);
Console.WriteLine($"{name} {Ages} yoshda!");
//feature
int KeschaAge = 3;
int ageDeference = Ages - KeschaAge;
Console.WriteLine($"Siz Kecshadan {ageDeference} yosh katta ekansiz!");

// Console.WriteLine(sizeof(char));

// char smallA = 'a';
// char capitalA = 'A';
// Console.WriteLine((int)smallA);
// Console.WriteLine((int)capitalA);
// char belgi1 = '$';
// char belgi2 = '%';
// Console.WriteLine($"Belgi1ning qiymati: {(int)belgi1}");
// Console.WriteLine($"Belgi2ning qiymati: {(int)belgi2}");


// Console.Write("Birinchi soni kiriting: ");
// int son1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ikkinchi soni kiriting:");
// int son2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{son1} soni {son2} sonidan katta: {son1 > son2} ");
// Console.WriteLine($"Kecshaning yoshi {name}ning yoshidan kichik: {KeschaAge < Ages} ");
Animal Kescha = new Animal();


if (Ages < KeschaAge)
{
    Console.WriteLine("You are younger!");
}
else if (Ages == KeschaAge)
{
    Console.WriteLine("You are equal!");
}
else
{
    Console.WriteLine("You are older!");
}
// // mantiqiy operatorlar &&, ||, !
// string mesage =
//    KeschaAge >= 0 && Ages >= 0
//      ? "They are numbers positive"
//      : "They are numbers negative";
// System.Console.WriteLine(mesage);
// string mesage2 =
//    KeschaAge >= 0 || Ages >= 0
//      ? "They are numbers positive"
//      : "They are numbers negative";
// System.Console.WriteLine(mesage2);
// string mesage3 =
//     !(Ages >= 0)
//         ? "\"Ages\" number is not positive"
//         : "\"Ages\" number is not negative";
// System.Console.WriteLine(mesage3);
// System.Console.WriteLine("Hello");
// {
//     System.Console.WriteLine("World!");
// }
string kescha = "";
do
{
    Console.WriteLine("To'tiqushning ismini kiriting: ");
    kescha = Console.ReadLine();
} while (kescha != "kescha");
Console.WriteLine($"Salom {name}");
// Array
Console.WriteLine("Let me tell you about my friends! ");
string[] friendsName = new string[4];
friendsName[0] = "Kasee";
friendsName[1] = "Vasya";
friendsName[2] = name;
int[] friendsAge = { 3, 2, Ages };
Console.WriteLine($"{friendsName[0]} is {friendsAge[0]} years old! ");
Console.WriteLine($"{friendsName[1]} is {friendsAge[1]} years old!");
Console.WriteLine($"{friendsName[2]} is {friendsAge[2]} years old!");
Console.WriteLine("They are from \"Russia\" ");
Console.WriteLine("\tWhere do they live now? \n ");
string[] Adress = { "England", "France", "Russia" };
Console.WriteLine($"{friendsName[0]} lives in {Adress[0]} now!");
Console.WriteLine($"{friendsName[1]} lives in {Adress[2]} now!");
Console.WriteLine($"{friendsName[2]} lives in {Adress[1]} now!");
// foreach loop
Console.WriteLine("Keschaning eng yaqin do'stlari: ");
foreach (string friendName in friendsName)
{
    Console.WriteLine(friendName);
}
// for loop
for (int itarition = 0; itarition < friendsName.Length; itarition++)
{
    Console.WriteLine($"{friendsName[itarition]} is {friendsAge[itarition]} years old! ");
}



