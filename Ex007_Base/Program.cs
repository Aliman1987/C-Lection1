//Вычислить самую тяжелую гирю

int a = 1;
int b = 12;
int c = 6;
int d = 8;
int e = 4;

int max = a; //Примем индекс первого исследуемого за максимальное значение,

if (a > max ) max = a; //если значение а больше максимального, то а принимаем за максимальное
if (b > max ) max = b;
if (c > max ) max = c;
if (d > max ) max = d;
if (e > max ) max = e;

Console.Write("max = ");
Console.WriteLine(max);