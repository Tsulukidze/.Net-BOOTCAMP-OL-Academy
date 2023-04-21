// .Net 6.0

string user = "tt";
string password = "t123";
string inputUser;
string inputPass;


for (int i = 0; i<5; i++)
{
    Console.Write("Sheiyvane momxmarebeli   :  ");
    inputUser = Console.ReadLine();
    Console.Write("Sheiyvane paroli   :  ");
    inputPass = Console.ReadLine();

    if (user == inputUser && password == inputPass)
    {
        for (int j = 0; j < 5; j++)
            Console.WriteLine("warmateba");
        break;
    }
        
    else
    {
        if (i == 3) 
            Console.WriteLine("\nYuradgebit es bolo cdaa ");
        else if
            (i == 4) 
                Console.WriteLine("\nShecdoma");
        else
            Console.WriteLine("\nKidev ertxel Scadet ");

    }
        

}




