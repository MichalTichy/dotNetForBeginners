using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    public class Database
    {
        public static Database GetDatabase()
        {
            return new Database();
        }

        public IEnumerable<Person> Employes { get; set; } = new List<Person>()
        {
            new Person() {
                FirstName = "Humphrey",
                LastName = "Appleby",
                Age = 55,
                Role = "úředník",
                Id = 1,
                ManagerId = 2
            },
            new Person() {
                FirstName = "Jim",
                LastName = "Hacker",
                Age = 53,
                Role = "politik",
                Id = 2
            },
            new Person() {
                FirstName = "Bernard",
                LastName = "Woolley",
                Age = 45,
                Role = "úředník",
                Id = 3,
                ManagerId = 2
            }
        };
    }
}
