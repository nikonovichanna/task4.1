int ibase = Promt("Введите основание: ");
int exponent = Promt("Введите показатель степени: ");
System.Console.WriteLine($"Число {ibase} в степени {exponent} = {Power(ibase, exponent)}");

int Promt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result =int.Parse(readInput);
    return result;
}

int Power(int ibase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= ibase;
    }
    return power;
}



