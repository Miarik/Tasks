Console.WriteLine("Введите два разных положительных числа через Enter");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int nMin;
int nMax;
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
nMin = minimum;
while (nMin <= middle) {
    if (nMin %2 != 0) {
        Console.Write("Нечетное число от минимума до середины ");
        Console.WriteLine(nMin);
        nMin = nMin + 2;
    }
    else {
        nMin++;
    }
}
nMax = maximum;
while (nMax >= middle) {
    if (nMax % 2 == 0) {
        Console.Write("Четное число от середины до максимума ");
        Console.WriteLine(nMax);
        nMax = nMax - 2;
    }
    else {
        nMax--;
    }
}

