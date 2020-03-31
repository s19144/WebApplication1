using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> students;

        static MockDbService()
        {
            students = new List<Student>
            {
                new Student {IdStudent=1,FirstName="Jan",LastName="Covalski",indexnumber="s1234"},
                new Student {IdStudent=2,FirstName="Anna",LastName="Grob",indexnumber="s4321"},
                new Student {IdStudent=3,FirstName="Gred",LastName="Brini",indexnumber="s5431"},
            };

        }
        public IEnumerable<Student> GetStudents()
        {
            return students;
        }
    }
}
