string setusername = "";
string setpass = "";
bool authentication = true;
bool accountauth = true;

//account creation
while(authentication){
    
    Console.WriteLine("Enter your Desired Username: ");
    setusername = Console.ReadLine();

    Console.WriteLine("Enter your Desired Password: ");
    setpass = Console.ReadLine();
   
    while(setpass.Length < 6 || setpass.Length > 14){
        Console.WriteLine("The Password must be 6-14 Characters only!");
        Console.WriteLine("Enter your Desired Password: ");
        setpass = Console.ReadLine();
    }

Console.WriteLine("Account has been Successfully created!");
authentication = false;

}

string username;
string password;

while(accountauth){
    Console.WriteLine("Enter your Username: ");
    username = Console.ReadLine();

    Console.WriteLine("Enter your Password: ");
    password = Console.ReadLine();


    while(setusername != username || setpass != password){
        Console.WriteLine("The entered Username or Password is Incorrect!");
        
        Console.WriteLine("Enter your Username: ");
        username = Console.ReadLine();

        Console.WriteLine("Enter your Password: ");
        password = Console.ReadLine();
    }

    Console.WriteLine($"Welcome back {username}!");
    accountauth = false;
    
}