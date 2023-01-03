using System;
using SQLite;

namespace FitnessApp.Models
{
    [Table("Fitness")]
    public class Fitness
	{
        [PrimaryKey]
        public string Email { get; set; }

        
        public string FName { get; set; }
        
        public string LName { get; set; }
       
        public string Password { get; set; }
        
        public string Mobile { get; set; }

    }
}

