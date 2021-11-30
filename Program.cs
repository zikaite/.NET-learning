using System;
using BookStore.Models;
using System.Linq;

var allBooks = new List<Books>();

while (true)
{   
    Console.WriteLine("Please enter your command: 'Add' or 'List' or 'Remove' or 'Update'");
    var command = Console.ReadLine();

    if (command == "Add")
    {
        Console.WriteLine("Please enter the title");
        var title = Console.ReadLine(); 
        //if (allBooks.Where(x => x.Title == title).Count() > 0)

        Console.WriteLine("Please enter the description");
        var description = Console.ReadLine();

        Console.WriteLine("Please enter the amount of books");
        var amount = Convert.ToInt32(Console.ReadLine());
        try
        {            
            var exists = false;
            foreach (var book in allBooks) 
        { 
            if (book.Title == title) exists = true; 
        }
            if (!exists)
            allBooks.Add(new Books(title, description, amount));
            else Console.WriteLine("Book title already exists.");
        }
        catch
        {
            Console.WriteLine("Amount must be a number..");
        }
    }
        

    else if (command == "List")
    {

        foreach (var Books in allBooks)
        {
            Console.WriteLine($"Name: {Books.Title}, Description: {Books.Description}, Amount: {Books.Amount}");
        }
    }
    else if (command == "Remove")
    {
        Console.WriteLine("Which book from the list do you want to remove?");
        foreach (var Books in allBooks)
        {
            Console.WriteLine($"Name: {Books.Title}, Description: {Books.Description}, Amount: {Books.Amount}");
        }
        var removedBookTitle = Console.ReadLine();

        allBooks.RemoveAll(x => x.Title == removedBookTitle);

        Console.WriteLine("Book has been removed. Here is your new list");
        foreach (var Books in allBooks)
        {
            Console.WriteLine($"Name: {Books.Title}, Description: {Books.Description}, Amount: {Books.Amount}");
        }
    }
    else if (command == "Update")
    {       
        Console.WriteLine("What do You want to update? Title, Description or Amount?");
        var commandToUpdate = Console.ReadLine();

        if (commandToUpdate == "Title")
        {
            Console.WriteLine("Type a title for update");
            var updateBookTitle = Console.ReadLine();
            Console.WriteLine("Type new title");
            var newBookTitle = Console.ReadLine();
            allBooks.Where(x => x.Title == updateBookTitle).ToList().ForEach(x => x.Title = newBookTitle);
        }
        else if (commandToUpdate == "Description")
        {
            Console.WriteLine("Type book's title which description do you want to update");
            var updateBookDesc = Console.ReadLine();
            Console.WriteLine("Type new description");
            var newBookDesc = Console.ReadLine();
            allBooks.Where(x => x.Title == updateBookDesc).ToList().ForEach(x => x.Description = newBookDesc);
        }
        else if (commandToUpdate == "Amount")
        {
            Console.WriteLine("Type book's title which amount do you want to update");
            var updateBookAmount = Console.ReadLine();
            Console.WriteLine("Type new amount");
            var newBookAmount = Convert.ToInt32(Console.ReadLine());
            allBooks.Where(x => x.Title == updateBookAmount).ToList().ForEach(x => x.Amount = newBookAmount);
        }
                
    }    
        
}

    
