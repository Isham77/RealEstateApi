﻿namespace RealEstateApi.Models
{
    public class Property
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Detail {  get; set; }
        public string Address{ get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public bool IsTrending {  get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }


    }
}
