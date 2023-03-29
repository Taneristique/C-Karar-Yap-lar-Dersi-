class Program{
    static void Main(string[] args){
        Console.WriteLine("2 adet sayı giriniz");
        int not1=Convert.ToInt32(Console.ReadLine());
        int not2=Convert.ToInt32(Console.ReadLine());
        double ortalama=(not1+not2)/2;
        if(ortalama>=50){
            Console.WriteLine("Dersten geçtiniz.");
        }
        else{
            Console.WriteLine("Dersten kaldiniz.");
        }
    }
}
