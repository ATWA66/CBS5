//task 3
int x = 5, y = 10, z = 15;
x += y >> x++ * z;
Console.WriteLine(x);
z = ++x & y * 5;
Console.WriteLine(z);   
y /= x + 5 | z;
Console.WriteLine(y);
z = x++ & y * 5;
Console.WriteLine(z);
x = y << x++ ^ z;
Console.WriteLine(x);