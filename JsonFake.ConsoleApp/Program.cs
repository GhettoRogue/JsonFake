using JsonFake.Lib;

Console.Write("Введите id пользователя: ");
var id = Convert.ToInt32(Console.ReadLine());
var userApi = new UserAPI();
var user = userApi.GetUserById(id);

if (user is null)
{
    Console.WriteLine("Такого пользователя нет!");
    return;
}

Console.WriteLine($"{user.Id}: {user.Name}, {user.Email}");

