﻿
namespace ConsoleApp12
{
    internal class User
    {
           public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        public User()
        {

        }
        public User(string Login, string Name, bool IsPremium)
        {
             this.Login = Login;
             this.Name = Name;
             this.IsPremium = IsPremium;
        }
        public void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
    
}
