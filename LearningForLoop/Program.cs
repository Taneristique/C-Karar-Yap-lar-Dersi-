using System;
class Program{ 
       /*
        This program creates a melody and will work correctly only on windows os.
       */
    static void Main(){ 
        int[] melody={440,466,494,523,554,587,622,659,698,740,784,831,880};
        for(int i=0;i<melody.Length;i++){
        Console.Beep(melody[i],500);
}
    }
}
