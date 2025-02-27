using System.Globalization;
using System.Text;

// Set console encoding to UTF-8
Console.OutputEncoding = Encoding.UTF8;
CultureInfo germanCulture = new("de-DE");


decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})\n");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units\n");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}\n");

decimal price2 = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice).ToString("C", germanCulture), price2.ToString("C", germanCulture));
yourDiscount += $"A discount of {((price2 - salePrice)/price2):P2}!";
Console.WriteLine(yourDiscount);