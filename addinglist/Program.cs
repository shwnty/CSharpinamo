bool auth  = true;
string ans = "";
string show = "show";
string add =  "add";
string nameadd = ""; 
string exit = "exit";
string search = "search";
string namesearch = "";

var names = new List <string>{};

while(auth){
    Console.WriteLine("What action would you like to do?\nType show to show the names in the list\nType add to add names on the list\nType exit to exit program\nType search if you would like to search a name in the List");
    ans =  Console.ReadLine();
    ans  = ans.ToLower();
    names.Sort();

    if(ans == add){
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

    }else if(ans == search){
        
        Console.WriteLine("Put the name you wanted to search:");
        namesearch = Console.ReadLine();
        var iname = names.IndexOf(namesearch);
    
            if(iname != -1){
                Console.WriteLine($"The name {namesearch} is at index {iname}");
            }else if(iname == -1){
                Console.WriteLine("The name you've searched is not on this List!");  
            }
        
        
        }else if(ans != show && ans != add && ans != exit && ans != search){
        Console.WriteLine("Please put a valid input!");
    }else if(ans == exit){
        auth = false;
    }

}
