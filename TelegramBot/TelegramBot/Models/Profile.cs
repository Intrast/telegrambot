using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBot.Models
{
    public class Profile
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The length of the string must be from 3 to 50 characters")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The length of the string must be from 3 to 50 characters")]
        public string Surname { get; set; }
        public int Age { get; set; }
        public int City { get; set; }
        [Required]
        [RegularExpression(@"^[0-9\-\+]{10,13}$", ErrorMessage = "Invalid phone number")]
        public string Phone_number { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The length of the string must be from 3 to 50 characters")]
        public string Skype { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid address")]
        public string Email { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The length of the string must be from 3 to 50 characters")]
        public string LinkedIn { get; set; }
        public string Skills { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Created_at { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Updated_at { get; set; }
    }

    public class ProfileContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}