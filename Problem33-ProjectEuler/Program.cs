
List<string> fractions = new();

for (double i = 11; i < 99; i++)
{
    if (i % 10 == 0)
        continue;
    for(double j = i+1; j<= 99; j++)
    {
        if (j % 10 == 0)
            continue;
        double Num1 = Convert.ToDouble(i.ToString().Substring(0, 1));
        double Num2 = Convert.ToDouble(i.ToString().Substring(1, 1));
        double Den1 = Convert.ToDouble(j.ToString().Substring(0, 1));
        double Den2 = Convert.ToDouble(j.ToString().Substring(1, 1));
        if((Num1 == Den1 && Num2/Den2 == i/j) ||
            (Num1 == Den2 && Num2 / Den1 == i / j) ||
            (Num2 == Den1 && Num1 / Den2 == i / j) ||
            (Num2 == Den2 && Num1 / Den1 == i / j))
            fractions.Add(i.ToString() + "/" + j.ToString());
    }
}

double totalNum = 1;
double totalDen = 1;

foreach (string fraction in fractions)
{
    totalNum = totalNum * Convert.ToDouble(fraction.Substring(0,2));
    totalDen = totalDen * Convert.ToDouble(fraction.Substring(3, 2));
}

double counter = 2;
while(counter<= Math.Min(totalNum, totalDen))
{
    if(totalNum%counter == 0 && totalDen%counter == 0)
    {
        totalNum = totalNum / counter;
        totalDen = totalDen / counter;
        counter = 2;
    }
    counter++;
}
Console.WriteLine("If the product of these four fractions is given in its lowest common terms, the value of the denominator would be: " + totalDen);
