/*
if IPv4 address consists of four numbers separated by dots
and
if Each number must not contain leading zeroes
and
if Each number must range from 0 to 255

then IPv4 address is valid

else IPv4 address isnt valid
*/

string[] ipv4Input = ["107.31.1.5", "255.0.0.255", "555..0.555", "255...255"];
string[] address;  // Prevents empty substrings from being included in the resulting array ("192..168.1.1").
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

// Methods
void ValidateLength() 
{    
    validLength = address.Length == 4;
}

void ValidateZeroes() 
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;  // The return statement terminates execution of the method and returns control to the method caller
        }
    }
    validZeroes = true;
}

void ValidateRange() 
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}

/*
107.31.1.5 is a valid IPv4 address
255.0.0.255 is a valid IPv4 address
555..0.555 is an invalid IPv4 address
255...255 is an invalid IPv4 address
*/