﻿namespace FrontBackEShopers.Models
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public override string ToString()
        {
            return $"{CategoryId} {CategoryName}";
        }
    }
    public class CategoriesFirst
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public override string ToString()
        {
            return $"{CategoryId} {CategoryName}";
        }
    }
}
