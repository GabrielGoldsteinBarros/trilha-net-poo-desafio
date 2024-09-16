using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123456", "Nokia Model", "111111111111111", 64);
        Smartphone iphone = new Iphone("7891011", "iPhone Model", "222222222222222", 128);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
