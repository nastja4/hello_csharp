using System.Text;
// Set console encoding to UTF-8
Console.OutputEncoding = Encoding.UTF8;

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ₫{vnd} VND");
Console.WriteLine($"₫{vnd} VND = ${VndToUsd(vnd)} USD");

// Method returns an integer
int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int) (rate * usd);
}

// Method returns a double
double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}

/*
$23,73 USD = ₫557655 VND
₫557655 VND = $23,73 USD
*/