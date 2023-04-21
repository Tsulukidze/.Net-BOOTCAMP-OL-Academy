// .Net 6.0

Console.Write("sheiyvane ricxvi atobit sistemashi : ");
int atobiti = Convert.ToInt32(Console.ReadLine());
string orobiti = "";
bool negative = false;

if (atobiti == 0) Console.WriteLine(0);


if (atobiti < 0)
{
    negative = true;
    atobiti *= -1;
}
    
while (atobiti > 0)
{
    orobiti = atobiti % 2 + orobiti;
    atobiti = atobiti / 2;
}

if(negative)
    Console.WriteLine("am ricxvis orobitia   :  -" + orobiti);
else
    Console.WriteLine("am ricxvis orobitia   :  " + orobiti);




