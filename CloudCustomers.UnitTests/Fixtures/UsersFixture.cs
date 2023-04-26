using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new List<User>() {
                    new User() {
                        Id = "id",
                        Name = "Jane",
                        Address = new Address()
                        {
                            Street = "A",
                            City = "B",
                            ZipCode = "D"
                        },
                        Email = "email.com",
                        Password = "Password",
                    }
                };
    }
}
