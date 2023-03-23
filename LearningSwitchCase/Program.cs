using System;
//https://www.w3schools.blog/c-char-input  explains how to get character input from user in c#
//https://learn.microsoft.com/en-us/dotnet/api/system.char.toupper?view=net-8.0 uppercase a char
//https://stackoverflow.com/questions/16265247/printing-all-contents-of-array-in-c-sharp an alternative to for loop
class Program{
    public  static void learnSwitch(){
        Console.WriteLine("Please give a positive integer between 1 and 6 then we will give you an interesting information");
        uint _value=(uint)Convert.ToInt32(Console.ReadLine());  //get int from user than convert int to uint explicit type casting
        switch(_value){
            case 1:
                Console.WriteLine("In 1956 people raised against communist regime of Hungary.");
                break;
            case 2:
                Console.WriteLine("In 2014 a film called Pawn Sacrifice done for the memory of legendary chess player Bobby Fischer.");
                break;
            case 3:
                Console.WriteLine("In chess french opening knight variation plays with following notation : 1)e4 e6 1)Nf3");
                break;
            case 4:
                Console.WriteLine("In chess there is an opening called Rapport-Jobova System which is 1)d4 d5 2)Nc3 Nf6 3)Bf4");
                break;
            case 5:
                Console.WriteLine("The aim of chess is controlling or destroying center with an effective piece development and having pressure on kingside.");
                break;
            default:
                Console.WriteLine("Currently a big hack happened here is it's logs https://etherscan.io/address/0xb41c5af5fd73a766666a3f163985f682e868ba19");
                break;
        }
    }
    public static void Main(){  
        learnSwitch();
        /*Major gam data*/
        string[] doMajor={"c","d","e","f","g","a","b","c"};
        string[] reMajor={"d","e","f#","g","a","b","c#","d"};
        string[] miMajor={"e","f#","g#","a","b","c#","d#","e"};
        string[] faMajor={"f","g","a","bb","c","d","e","f"};
        string[] solMajor={"g","a","b","c","d","e","f#","g"};
        string[] laMajor={"a","b","c#","d","e","f#","g#","a"};
        string[] siMajor={"b","c#","d#","e","f#","g#","a#","b"};
        /*Ask user which game he wants to know and assign the given value to the decision variable*/
        Console.WriteLine("Dear user please give me which major gam would you want to learn with a capital letter e.g(C if you want to say Do Major)");
        char decision=Char.ToUpper(Convert.ToChar(Console.ReadKey().KeyChar)); //get input from keyword and make it uppercase 
        switch(decision){ //decide operation to do for each different possibilities using switch case 
            case 'C':
                Console.WriteLine("\nDo Major");
                doMajor.ToList().ForEach(Console.Write); //convert array to list than write each element with ForEach method 
                break;
            case 'D':
                Console.WriteLine("\nRe Major");
                reMajor.ToList().ForEach(Console.Write);
                break;
            case 'E':
                Console.WriteLine("\nMi Major");
                miMajor.ToList().ForEach(Console.Write);
                break;
            case 'F':
                Console.WriteLine("\nFa Major");
                faMajor.ToList().ForEach(Console.Write);
                break;
            case 'G':
                Console.WriteLine("\nSol Major");
                solMajor.ToList().ForEach(Console.Write);
                break;
            case 'A':
                Console.WriteLine("\nLa Major");
                laMajor.ToList().ForEach(Console.Write);              
                break;
            case 'B':
                Console.WriteLine("\nSi Major"); 
                siMajor.ToList().ForEach(Console.Write); 
                break;
            default: //in case user press a wrong key default case will work
                Console.WriteLine("\nUser did not give a valid value but I will show do Major by default");
                miMajor.ToList().ForEach(Console.Write);
                break;
        }
        Console.ReadLine(); //Close application when user press enter
    }
}
