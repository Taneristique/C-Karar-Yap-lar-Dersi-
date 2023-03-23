

class Program{
    public static void learningWhile(){
        int index=1;
        Console.WriteLine("Draw a triangle with while");
        while (true)//will work
        {   
           if(index==12){break;}//breakpoint
           Console.WriteLine(new String('-', index));
           index++;
        }

        while(false){//won't work because condition is false
            if(index==0){break;}
            Console.WriteLine(new String('*',index));
            index--;
        }
    }    
    public static void learningDoWhile(){
        int index=1;
        Console.WriteLine("Draw a triangle with while");
        do{
           if(index==7){break;}//breakpoint
           Console.WriteLine(new String('-', index));
           index++;
        }while(index<12);
        do{
           if(index==0){break;}//breakpoint
           Console.WriteLine("It works... but just for once!");
           Console.WriteLine(new String('-', index));
           index--;
        }while(false);
    }


    public static void Main(){
        learningWhile();
        learningDoWhile();
    }
}