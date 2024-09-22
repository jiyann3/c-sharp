Console.Write("Sayi gir:");
int sayi = Convert.ToInt32(Console.ReadLine());

if(sayi<=0){
    if (sayi <0){
        Console.WriteLine("Pozitif bir sayi gir");
    }
 else if(sayi==0){
    Console.WriteLine("0 Sayısı girilemez");
 }
}

else if(sayi %10== 0){
    Console.WriteLine("Girdiğiniz sayı 10'un katıdır");
}

else{
    Console.WriteLine("Girdiğiniz sayı 10'un katı değildir");
}