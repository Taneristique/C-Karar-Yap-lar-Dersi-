class Program{
    static void Main(string[] args){
        Console.WriteLine("Klavyeden bir sayi giriniz");
        int sayi=Convert.ToInt32(Console.ReadLine());
        if(sayi<0){
            Console.WriteLine("Sayi negatif");
        }
        else if(sayi>0){
            Console.WriteLine("Sayi pozitif");
        }
        else{
            Console.WriteLine("Sayi sifira eşit");
        }
        Console.Read();
    }
}