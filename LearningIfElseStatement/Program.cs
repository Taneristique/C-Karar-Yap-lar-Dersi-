//System namespacini dahil et
Console.WriteLine("If ve else in mantiğini yazi tura oyunu ile öğreneceğiz.");
Console.WriteLine("Değerli kullanici az sonra para havaya atilacaktir.");
Console.WriteLine("Yazi seçeneğini seçmek için 1 tura için 0'i seçiniz");

/*Kullanıcıdan Console içerisinde tanımlı Readline metodu ile değer al bu değer 
  string türünde olacaktır.Ancak bu oyunda bizim kullanıcıdan bir tamsayı değeri 
  almamız gerekiyor.O yüzde Cnonvert class'ında tanımlı ToInt32 metodunu kullanarak kullanıcıdan 
  aldığımız değeri tamsayı türüne çeviricez.*/
int kullaniciKarari=Convert.ToInt32(Console.ReadLine()); 

/*Eğer kullanıcı 1 ve 0 harici bir değer girerse Exception sınıfı aracılığıyla hata dön
  ve programı bitir.*/
if(kullaniciKarari!=1 && kullaniciKarari!=0){
    throw new Exception("Girilen değer ancak 1 veya 0 olabilir");
}
Random rand= new Random(); //Random sınıfından bir rand nesnesi türet.
int yaziVeyaTura=rand.Next(0,1); //Random class'ındaki next metodu ile değişkeni 1 veya 0'a eşitle. 

/* Kullanıcı kararı doğru mu yoksa yanlış mı kontrol et ve her iki durumdada ekrana gerekli
   metinleri yazdır. */
if(kullaniciKarari==yaziVeyaTura){
    string cevap=kullaniciKarari==0?"Tura":"Yazi";
    Console.WriteLine("Tebrikler "+cevap+" geldi ve doğru bildiniz)");
}
else{
    Console.WriteLine("Üzgünüz cevabiniz yanliş ama bir daha deneyebilirsiniz");
}
Console.ReadLine(); //Kullanıcıdan herhangi bir değer alarak programı sonlandır.