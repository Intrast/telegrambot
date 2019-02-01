using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TelegramBot.Models
{
    public class WorkExperiense
    {
        public int ID { get; set; }
        public string Level { get; set; }
    }

    public class WorkExperienseContext : DbContext
    {
        public DbSet<WorkExperiense> WorkExsperienses { get; set; }
    }
}