

//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xa=1;
int ya=1; 
int xb=1;
int yb=30;
int xc=30;
int yc=30;
      




int x=xa, y=ya;
int count = 0;

while (count < 10)
{
int vershina = new Random().Next(0, 3);
if (vershina == 0)
{
x = (x + xa) / 2;
y = (y + ya) / 2;
}

if (vershina == 1)
{
    x = (x + xb) / 2;
    y = (y + yb) / 2;
}

if (vershina == 2)
{
    x = (x + xc) / 2;
    y = (y + yc) / 2;
}
count = count + 1;
}
Console.WriteLine(x);
Console.WriteLine(y);