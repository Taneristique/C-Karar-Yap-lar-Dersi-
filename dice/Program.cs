// See https://aka.ms/new-console-template for more information
using System;
class Program{
    static void Main(){
    Console.WriteLine("Lütfen 1 ve 6 arasında bir tam sayı girin : ");
    int response=Convert.ToInt32(Console.ReadLine());
    if(response<1||response>6){ 
        throw new Exception("Response cannot be lower than 1 and higher than 6"); 
    }
    Console.WriteLine("Zar atılıyor....");
    Random result=new Random();
    int dice=result.Next(1,6);
    if(dice==response){
        Console.WriteLine("tebrikler doğru bildiniz!");
    }
    else{
        Console.WriteLine("Yanıldınız bir daha deneyin!");
    }
    Console.ReadLine();
        }
    
}

