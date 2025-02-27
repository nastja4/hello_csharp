string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIDsArray = orderStream.Split(',');
Array.Sort(orderIDsArray);

foreach (var order in orderIDsArray)
{
    Console.WriteLine(order.Length == 4 ? order : (order + "\t- Error"));     
}