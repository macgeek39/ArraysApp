

int[] age = new int[6];

age[0] = 3;
age[1] = 4;
age[2] = 5;
age[3] = 6;
age[4] = 7;
age[5] = 8;

Console.WriteLine($"There are the age {age[0]}, {age[1]}, {age[2]}, {age[3]}, {age[4]}, {age[5]},");

age[3] = 9;

Console.WriteLine($"The Fourth persons age is {age[3]}");

string data = "Tim, Bob, John, Oliver, Sue";
string[] firstName = data.Split(',');

Console.WriteLine(firstName[firstName.Length -1]);
Console.WriteLine(firstName.Length);

string[] lastName = new string[] { "Kool", "Lee", "Love" };