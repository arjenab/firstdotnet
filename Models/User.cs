using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class User
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth{ get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interest { get; set; }
        public string City { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}