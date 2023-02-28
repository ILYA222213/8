using Tut;

public class Program
{
     private static void Main(string[] args)
    {
        Tut.Kiosc kiosc = new Tut.Kiosc("24/7", "ул.Пушкина 24", "4", "Обслуживание клиентов 24/7");
        Tut.Magazin magazin = new Tut.Magazin("У дяди Игоря","ул.Негрова 33", "25", "Каждый день что-то новое!");
        Tut.Minimarcet minimarcet = new Tut.Minimarcet("Натали","ул.Гоголя 54", "45", "Ваш путь к отличным покупкам!");
        Tut.Supermarcit supermarcit = new Tut.Supermarcit("Магнит", "ул.Лермонтова 39", "86", "Только у нас скиндки 50% на все товары!");
    }
    

}
