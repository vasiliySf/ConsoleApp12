using System;

namespace ConsoleApp12;
class Program
{
    static void Main(string[] args)
    {
        List<User> users = new List<User>();
        string login;
        User muser = new User();

        users.Add(new User("Petrov", "Петров Петр Петрович", false));
        users.Add(new User("Ivanov", "Иванов Иван Иванович", true));
        users.Add(new User("Smirnov", "Смирнов Игорь Сергеевич", false));
        try
        {
            Console.WriteLine("Введите логин!");
            login = Console.ReadLine();

            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    muser = user;
                    break;
                }
            }
            Console.WriteLine($"Привет, {muser.Name}! ");

            if (!muser.IsPremium)
            {
                muser.ShowAds();
            }
        }
        catch (Exception ex)
        { Console.WriteLine(ex.ToString()); }

    }
}
