long a, b, c, d;
string str  = Console.ReadLine();
var arr = str.Split(" ");
a = Convert.ToInt64(arr[0]);
b = Convert.ToInt64(arr[1]);
c = Convert.ToInt64(arr[2]);
d = Convert.ToInt64(arr[3]);

long res = a * b * c * d;

Console.WriteLine(res);
