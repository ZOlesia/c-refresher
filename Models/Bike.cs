using System;

namespace bicycles.Models
{
    public class Bike
    {
        public int BikeId { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public string Img { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User Seller { get; set; }

        public Bike()
        {
            this.CreatedAt = this.UpdatedAt = DateTime.Now;
        }
    }
}