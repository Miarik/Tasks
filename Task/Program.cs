Console.WriteLine("Введите два разных положительных числа через Enter");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int nMin;
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
while (nMin < middle) {

}


