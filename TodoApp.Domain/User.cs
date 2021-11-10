using System;
using System.Collections.Generic;

namespace TodoApp.Domain
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public UserAddress Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public UserCompany Company { get; set; }
        public List<Todo> Todos { get; set; } = new List<Todo>();

        public class UserAddress
        {
            public int Id { get; set; }
            public string Street { get; set; }
            public string Suite { get; set; }
            public string City { get; set; }
            public string Zipcode { get; set; }
            public Geo Geo { get; set; }
        }

        public class Geo
        {
            public int Id { get; set; }
            public string Lat { get; set; }
            public string Lng { get; set; }
        }

        public class UserCompany
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string CatchPhrase { get; set; }
            public string Bs { get; set; }
        }
    }

    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public List<Todo> Todos { get; set; } = new List<Todo>();
        public Claims Role { get; set; }
    }

    public class Claims
    {
        public int ClaimsId { get; set; }
        public string Name { get; set; }
    }
}
