using JsonFake.Lib.Models;

namespace JsonFake.Lib.Test;

public class UserAPI_Test
{
    [Fact]
    public void GetUserById_GoodTest()
    {
        var userApi = new UserAPI();
        var expectedUser = new User()
        {
            Id = 2,
            Name = "Ervin Howell",
            Username = "Antonette",
            Email = "Shanna@melissa.tv",
            Address = new Address()
            {
                Street = "Victor Plains",
                Suite = "Suite 879",
                City = "Wisokyburgh",
                Zipcode = "90566-7771",
                Geo = new Geo()
                {
                    Lat = "-43.9509",
                    Lng = "-34.4618"
                }
            },
            Phone = "010-692-6593 x09125",
            Website = "anastasia.net",
            Company = new Company()
            {
                Name = "Deckow-Crist",
                CatchPhrase = "Proactive didactic contingency",
                Bs = "synergize scalable supply-chains"
            }
        };
        var actualUser = userApi.GetUserById(2);
        
        Assert.Equal(expectedUser, actualUser);
    }
}