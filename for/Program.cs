Console.WriteLine("Введите два разных положительных числа через Enter");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int maximum;
int minimum;

double middle = (numberA + numberB)/2;
if (numberA > numberB) {
    maximum = numberA;
    minimum = numberB;
}
else {
    maximum = numberB;
    minimum = numberA;
}
for(minimum; minimum<=maximum; minimum++)
{
    if (minumum <= middle)
    {
        if (minimum % 2 != 0)
        {
        Console.WriteLine("Нечетное число от минимума до середины " + minimum);
        minimum++;
        }
    }
    else {
        if (minimum % 2 = 0)
        {
            Console.WriteLine("Четное число от минимума до середины " + minimum);
            minimum++;
        }
    }
}
