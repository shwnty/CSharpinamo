bool auth  = true;
string ans = "";
string show = "show";
string add =  "add";
string nameadd = ""; 
string exit = "exit";

var names = new List <string>{};

while(auth){
    Console.WriteLine("What action would you like to do?\n Type show to show the names in the list\n Type add to add names on the list\n Type exit to exit program");
    ans =  Console.ReadLine();
    ans  = ans.ToLower();

    if(ans  == add){
       if(names.Count < 5){
        Console.WriteLine("Enter the name you would like to add: ");
        nameadd = Console.ReadLine();
        names.Add(nameadd);
        Console.WriteLine("The name has been successfully add!");
        Console.Beep();
       }else{
        Console.WriteLine("The List has no more space!");
       }
    }else  if(ans == show){

        if(names.Count == 0){
            Console.WriteLine("There are currently no names on the List");
        }else if(names.Count > 0){
            foreach (var name in names){
            Console.WriteLine($"The name {name} exists in the list!");
        }
        
        }

    }else if(ans == exit){
        auth = false;
    }else if(ans != show || ans != add || ans != exit){
        Console.WriteLine("Please put a valid input!");
    }

}
