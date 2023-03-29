using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryPicking.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string? Address { get; set; }
        public string? City { get; set; }

        public Person(int id, string name, string email)
        {
            ArgumentException.ThrowIfNullOrEmpty(name);
            ArgumentException.ThrowIfNullOrEmpty(email);
            if (id <= 0) throw new ArgumentOutOfRangeException("id");

            Id = id;
            Name = name;
            Email = email;
        }
    }
}
