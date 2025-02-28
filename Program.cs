using System.Text;
Console.OutputEncoding = Encoding.UTF8;


string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "5.000,00 €";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadRight(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine); 

//1234567890123456789012345678901234567890
//769C  Mr. Stephen Ortega      5.000,00 €