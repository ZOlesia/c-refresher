using System;
using System.Collections.Generic;

namespace bicycles.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Bike> MyBikes { get; set; }
        

        public User()
        {
            this.CreatedAt = this.UpdatedAt = DateTime.Now;
            this.MyBikes = new List<Bike>();
        }
    }
}




