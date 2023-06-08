// difference of and or operations

// and operations
int a = 6;
int b = 6;
int c = 12;

if((a + b > 10) && (a == b)){
    Console.WriteLine("The Sum is Greater than 12 and a and b are equal to c");
}else{
     Console.WriteLine("ulol hahahah mali");
     }

if((a + b < 10) && (a == b)){
    Console.WriteLine("The Sum is Greater than 12 and a and b are equal to c");
}else{
     Console.WriteLine("ulol hahahah mali");
     }

//or operations
if((a + b > 10) || (a + b == c)){
    Console.WriteLine("The Sum is Greater than 12 and a and b are equal to c");
}else{
     Console.WriteLine("ulol hahahah mali");
     }

if((a + b < 10) || (a + b == c)){
    Console.WriteLine("The Sum is Greater than 12 and a and b are equal to c");
}else{
     Console.WriteLine("ulol hahahah mali");
     }
    
// Console.WriteLine(args[])
int aa = 10;
int bb = 10;
int cc = 1;

if(aa + bb == 20 && aa + bb < cc){
    Console.WriteLine("ekwal lang");
}else{
    Console.WriteLine("Putanginamo");
}


for(int  i = 1; i <= 20; i++){
    if(i % 3 == 0){
        Console.WriteLine($"The number {i} is divisible by 3");
    }
}
