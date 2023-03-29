class KararVerme{
    double  _try; //yatırımcının  tl sermayesi
    double _usd; //yatırımcının  dolar sermayesi
    double _priceUsd; //1 doların tl karşılığı
    public KararVerme(double _price,double _tryc,double _usdc){ //yapıcı method(constructor)
        _priceUsd=_price;
        _try=_tryc;
        _usd=_usdc;
        _usdAl(_priceUsd); //sınıf metodu
    }
    private void _usdAl(double _price){
        double changement;
        Console.WriteLine("Capital Before Purchase\n"+"_try :"+Convert.ToString(_try)+"usd :"+Convert.ToString(_usd));
        if(_price==16.00){
            changement=100.00;
            _usd+=changement; //buy usd
            _try-=changement*_price; //sell try
        }
        else if(_price<20.00){
            changement=50.00;
            _usd+=changement;//_usd=_usd+changement;
            _try-=changement*_price;//_try-=_try-changement*_price;
        }
        else{
            changement=25.00;
            _usd+=changement;
            _try-=changement*_price;
        }
        Console.WriteLine(Convert.ToString(changement)+" usd bought\nCapital After Purchase");
        Console.WriteLine("usd:"+Convert.ToString(_usd)+"\ntry:"+Convert.ToString(_try));
        }
    }



class Program{
    static void Main(){
        Console.WriteLine("Tl Sermayenizi Giriniz(örneğin 25,04) : ");
        double tlCapital=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("USD Sermayenizi Giriniz : ");
        double usdCapital=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Güncel Dolar Kurunu Giriniz : ");
        double usdPrice=Convert.ToDouble(Console.ReadLine());
        KararVerme yatirimci=new KararVerme(usdPrice,tlCapital,usdCapital);
    }
}