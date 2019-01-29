using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBot.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public int Work_experience { get; set; }
        public string Skills { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }

    public class ProfileDBContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}