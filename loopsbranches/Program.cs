bool auth = true;
string yes = "yes";
string no =  "no";
string ans = "";
while(auth){

Console.WriteLine("Baluga ba si lalay");
ans = Console.ReadLine();

if(ans == yes){
    Console.WriteLine("Tama,  pacool kid pa haha"); 
}else(ans != yes || ans !=  no){
    while(true){
        Console.WriteLine("baluga ba si lalay?");
        ans = Console.ReadLine();

        if(ans == yes){
            Console.WriteLine("Tama haha, Pacool kid pa si gago");
        }else if(ans != yes || ans != no){
            Console.WriteLine("put a valid input");
            ans = Console.ReadLine();
        }else{
            Console.WriteLine("hahahah bobo ka ba")
        }
        auth = false;
    }
}

auth  = false;
}