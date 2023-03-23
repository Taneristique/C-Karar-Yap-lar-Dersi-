using System;
int[] jingleBells={440,466,494,523,554,587,622,659,698,740,784,831,880};
for(int i=0;i<jingleBells.Length;i++){
    Console.Beep(jingleBells[i],50);
}