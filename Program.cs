const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// extract quantity
string openSpan = "<span>";
string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// replacing the trademark symbol with the registered trademark symbol, removing divs
const string tradeSymbol = "&trade";
const string regSymbol = "&reg";
output = input.Replace(tradeSymbol, regSymbol);

const string openDiv = "<div>";
int openDivStart = output.IndexOf(openDiv);
output = output.Remove(openDivStart, openDiv.Length);

const string closeDiv = "</div>";
int closeDivStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(closeDivStart, closeDiv.Length);


Console.WriteLine(quantity);
Console.WriteLine(output);

/*
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/