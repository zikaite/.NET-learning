using System;

namespace BookStore.Models
{
    public class Books
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public Books(string title, string description, int amount)
        {
            Title = title;
            Description = description;
            Amount = amount;
        }

        public string ToBeRemovedBook { get; set; }


        public Books(string removedBookTitle)
        {
            Title = removedBookTitle;
        }
    
    }

}