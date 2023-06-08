Boolean auth = true;
var remove = "";

var numbers = new List <string> {"1", "2", "3", "4", "5"};

while(auth){
    if (numbers.Count != 2)
    {
        Console.WriteLine("From numbers 1-5, remove 1-3 in order");
        remove = Console.ReadLine();

        foreach (string number in numbers)
        {

            if(remove  != number){
                Console.WriteLine("Please input a valid number  selection");
                Console.Beep();
                break;
                }else if(remove == number){
                    numbers.Remove(remove);                  
                }
            
        Console.WriteLine($"There are {numbers.Count} remaining");
        Console.Beep();
        break;

            }
            
        }else{
    Console.WriteLine("There are less than 3 numbers on the list, Goodbye!");
    auth = false;

        }  
}