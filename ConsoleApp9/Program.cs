Console.WriteLine("Lütfen bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi == 10)
{
    Console.WriteLine("girilen sayı 10'a eşittir.");
}
else if (sayi < 10)
{
    Console.WriteLine("girilen sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine("girilen sayı 10'dan büyüktür");
}

if (sayi % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");

}
else
{
    Console.WriteLine("girilen sayı tektir");
}

